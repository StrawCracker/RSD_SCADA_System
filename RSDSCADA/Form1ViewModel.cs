using RSDSCADA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        public Form1ViewModel()
        {
            //AllOrdersDone.Add(new Order { id=1, blue=0, red=1, yellow=2, CorrectOrder=true, Ontime=true });
            //AllOrdersDone.Add(new Order { id = 2, blue = 2, red = 3, yellow = 1, CorrectOrder = true, Ontime = false });
            //AllOrdersDone.Add(new Order { id = 3, blue = 2, red = 1, yellow = 0, CorrectOrder = false, Ontime = true });

            //Task.Run(async () => { await Task.Delay(10000); Update("AllOrdersDone"); });
        }

        private Order currentOrder;

        private Order nullOrder = new Order { blue = 0, red = 0, yellow = 0, id = -1, status = "No order" };

        public Order CurrentOrder
        {
            get {
                if (currentOrder == null)
                    return nullOrder;
                else
                    return currentOrder; }
            set { currentOrder = value; OrderStarted = DateTime.Now; Update("OrderTimeStr"); }
        }


        private DateTime OrderStarted { get; set; }


        public TimeSpan OrderTime => DateTime.Now - OrderStarted;

        public string OrderTimeStr
        {
            get
            {
                if (CurrentOrder == null)
                    return "--:--:--";

                return OrderTime.ToString(@"hh\:mm\:ss");
            }
        }


        private string status = "";

        public string Status
        {
            get { return status; }
            set { status = value; Update("Status"); }
        }


        //private string info;

        //public string Info
        //{
        //    get { return info; }
        //    set { info = value; Update("Info"); }
        //}



        private TimeSpan uptime;

        public TimeSpan Uptime
        {
            get { return uptime; }
            set { uptime = value; Update("Uptime"); Update("OEE_Availability_Proc"); }
        }


        private TimeSpan runTime;

        public TimeSpan RunTime
        {
            get { return runTime; }
            set
            {
                if (Status.Contains("Execute"))
                {

                    runTime += value;
                    Update("RunTime");
                }
            }
        }


        public string OEE_Proc
        {
            get
            {
                var Proc = OEE_Availability_Proc * OEE_Performance_Proc * OEE_Quality_Proc;

                if (Proc == 0)
                    return "0.0%"; 


                return $"{((double)Proc/(double)10000).ToString("0.0")}%";
            }

        }

        private double OEE_Availability_Proc
        {
            get
            {
                if (runTime.Ticks == 0 || uptime.Ticks == 0)
                    return 0;
                return (((double)runTime.Ticks / (double)uptime.Ticks) * 100);
            }
        }

        public string OEE_Availability_Proc_str => OEE_Availability_Proc.ToString("0.0") + "%";


        private TimeSpan OEE_OrderTime = new TimeSpan(0, 0, 25);

        private int OEE_OrdersShouldBeDone
        {
            get
            {
                if (OEE_OrderTime.Ticks == 0 || runTime.Ticks == 0)
                    return 0;

                return (int)(runTime.Ticks / OEE_OrderTime.Ticks);
            }
        }


        public string OEE_Performance_Str => $"{ordersDone}/{OEE_OrdersShouldBeDone}";

        private double OEE_Performance_Proc
        {
            get
            {
                if (ordersDone == 0 || OEE_OrdersShouldBeDone == 0)
                    return 0.0;

                return ((double)ordersDone / (double)OEE_OrdersShouldBeDone) * 100;
            }
        }

        public string OEE_Performance_Proc_str => OEE_Performance_Proc.ToString("0.0") + "%";


        public string OEE_Quality => $"{goodOrdersDone}/{ordersDone}";

        private double OEE_Quality_Proc
        {
            get
            {
                if (ordersDone == 0 || goodOrdersDone == 0)
                    return 0.0;

                return ((double)goodOrdersDone / (double)ordersDone) * 100;
            }
        }

        public string OEE_Quality_Proc_str => OEE_Quality_Proc.ToString("0.0") + "%";

        

        private int ordersDone => AllOrdersDone.Count;

        private int goodOrdersDone => AllOrdersDone.Where(o=>o.CorrectOrder).Count();




        private string currentOrderName;

        public string CurrentOrderName
        {
            get { return currentOrderName; }
            set { currentOrderName = value; Update("CurrentOrderName"); }
        }

        private string currentOrderKey;

        public string CurrentOrderKey
        {
            get { return currentOrderKey; }
            set { currentOrderKey = value; Update("CurrentOrderKey"); }
        }

        public string log { get; private set; } = "";

        public void logWriteLine(string str)
        {
            log = $"{DateTime.Now} - {str}\r\n" + log;

            Update("log");

        }

        public bool EnableStart
        {
            get {
                if (Status=="Idle" || Status == "Held" || Status == "Suspended")
                    return true;
                else
                    return false;
            }
        }

        public bool EnableClearing => Status=="Aborted"?true:false;

        public bool EnableHold => Status == "Execute" ? true : false;



        public BindingList<Order> AllOrdersDone { get; } = new BindingList<Order>();

        public int Points => AllOrdersDone.Sum(ord => (int)ord.points);

        public void AddDoneOrder(Order order)
        {

            if(Program.GetForm().InvokeRequired)
            {
                Program.GetForm().Invoke(new Action(() => AllOrdersDone.Add(order)));
            }
            else
            {
                AllOrdersDone.Add(order);
            }


            Update("AllOrdersDone");

            Update("ordersDone");
            Update("goodOrdersDone");
        }

        public void Update(string text)
        {
            if (Program.GetForm() == null)
                return;

            //Threading is a bitch
            if (Program.GetForm().InvokeRequired)
                try//Clean exit
                {
                    Program.GetForm().Invoke(new Action(() => NotifyPropertyChanged(text)));
                }
                catch (Exception)
                { }//Don't care
            else
                NotifyPropertyChanged(text);
        }


        public event PropertyChangedEventHandler PropertyChanged;



        public void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
