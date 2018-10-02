using RSDSCADA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA
{
    public class Form1ViewModel : INotifyPropertyChanged
    {


        private Order currentOrder;

        public Order CurrentOrder
        {
            get { return currentOrder; }
            set { currentOrder = value; OrderStarted = DateTime.Now; Update("OrderTimeStr"); }
        }


        private DateTime OrderStarted { get; set; }




        public string OrderTimeStr
            { get
            {
                if (CurrentOrder == null)
                    return "--:--:--";

                return (DateTime.Now-OrderStarted).ToString(@"hh\:mm\:ss");
            }}


        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; Update("Status"); }
        }
        

        private string info;

        public string Info
        {
            get { return info; }
            set { info = value; Update("Info"); }
        }



        private TimeSpan uptime;

        public TimeSpan Uptime
        {
            get { return uptime; }
            set { uptime = value; Update("Uptime"); }
        }


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




        public void Update(string text)
        {

            
            //Threading is a bitch
            if (Program.GetForm().InvokeRequired)
                try//Clean exit
                {
                    Program.GetForm().Invoke(new Action(() => NotifyPropertyChanged(text)));
                }
                catch (Exception)
                {}//Don't care
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
