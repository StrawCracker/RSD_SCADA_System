using RSDSCADA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSDSCADA
{
    public partial class Form1 : Form
    {
        public Form1(Form1ViewModel vM)
        {
            InitializeComponent();



            //Cell status binding
            Status.DataBindings.Add("Text", vM, "status");
            Uptime.DataBindings.Add("Text", vM, "Uptime",true, DataSourceUpdateMode.OnPropertyChanged,new TimeSpan(0,0,0), @"hh\:mm\:ss");
            //Info.DataBindings.Add("Text", vM, "Info");

            Order.DataBindings.Add("Text", vM, "CurrentOrder.id");
            Ticket.DataBindings.Add("Text", vM, "CurrentOrderKey");
            Blue.DataBindings.Add("Text", vM, "CurrentOrder.blue");
            Red.DataBindings.Add("Text", vM, "CurrentOrder.red");
            Yellow.DataBindings.Add("Text", vM, "CurrentOrder.yellow");
            Time.DataBindings.Add("Text", vM, "OrderTimeStr");

            OEE_Availability.DataBindings.Add("Text", vM, "RunTime", true, DataSourceUpdateMode.OnPropertyChanged, new TimeSpan(0, 0, 0), @"hh\:mm\:ss");
            OEE_Availability_Proc.DataBindings.Add("Text", vM, "OEE_Availability_Proc_str");
            OEE_Performance.DataBindings.Add("Text", vM, "OEE_Performance_Str");
            OEE_Performance_Proc.DataBindings.Add("Text",vM, "OEE_Performance_Proc_str");
            OEE_Quality.DataBindings.Add("Text",vM, "OEE_Quality");
            OEE_Quality_Proc.DataBindings.Add("Text",vM, "OEE_Quality_Proc_str");
            OEE_PROC.DataBindings.Add("Text",vM, "OEE_Proc");

            Start.DataBindings.Add("Enabled",vM, "EnableStart");
            Hold.DataBindings.Add("Enabled",vM,"EnableHold");
            Clear.DataBindings.Add("Enabled",vM, "EnableClearing");



            Log.DataBindings.Add("Text", vM, "log");

            dataGridView1.DataSource = vM.AllOrdersDone;
            dataGridView1.CellValueChanged += CellValueChangeEventHandler;

            OrderPoints.DataBindings.Add("Text", vM, "Points");

            //dataGridView1.DataBindings.Add("DataMember", vM, "AllOrdersDone");


            //this.ViewModelBindingSource.DataSource = viewmodel;
            //this.InitializeDataBindings();


        }

        private void CellValueChangeEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex+" Value has changed!!");
            Program.GetVM().Update("AllOrdersDone");
            
            
        }

        public void UpdateUptime(TimeSpan timeSpan)
        {
            Uptime.Text = timeSpan.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {

            PLCClient.Get().sendString("G");
            Program.GetVM().logWriteLine("Start command");

            ////Test when an order comes in

            //var order = new Order
            //{
            //    bricks = new Brick
            //    {
            //        blue = 2,
            //        red = 3,
            //        yellow = 1
            //    },
            //    status = "Ready",
            //    time = DateTime.Now
            //};

            ////Fake order number and Ticket



            //var vm = Program.GetVM();

            //vm.CurrentOrder = order;
            //vm.Status = "Exceuting";
            //vm.Info = "Creating your order now!";

            //vm.CurrentOrderName = MESClient.currentOrderName;
            //vm.CurrentOrderKey = MESClient.currentOrderKey;


        }

        private void Stop_Click(object sender, EventArgs e)
        {
            PLCClient.Get().sendString("S");
            Program.GetVM().logWriteLine("Stop command");
        }

        private void Hold_Click(object sender, EventArgs e)
        {
            PLCClient.Get().sendString("H");
            Program.GetVM().logWriteLine("Hold command");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PLCClient.Get().sendString("C");
            Program.GetVM().logWriteLine("Clear command");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Task.Run(() => { MESClient.GetNewOrder().Wait(); Task.Delay(new TimeSpan(0, 0, 20)).Wait(); MESClient.finishOrder(true).Wait(); });


            

            
        }
    }
}
