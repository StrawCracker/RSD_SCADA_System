using RSDSCADA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Info.DataBindings.Add("Text", vM, "Info");

            Order.DataBindings.Add("Text", vM, "CurrentOrderName");
            Ticket.DataBindings.Add("Text", vM, "CurrentOrderKey");
            Blue.DataBindings.Add("Text", vM, "CurrentOrder.bricks.blue");
            Red.DataBindings.Add("Text", vM, "CurrentOrder.bricks.red");
            Yellow.DataBindings.Add("Text", vM, "CurrentOrder.bricks.yellow");
            Time.DataBindings.Add("Text", vM, "OrderTimeStr");


            //this.ViewModelBindingSource.DataSource = viewmodel;
            //this.InitializeDataBindings();


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
            //Test when an order comes in

            var order = new Order
            {
                bricks = new Brick
                {
                    blue = 2,
                    red = 3,
                    yellow = 1
                },
                status = "Ready",
                time = DateTime.Now
            };

            //Fake order number and Ticket

            

            var vm = Program.GetVM();
            
            vm.CurrentOrder = order;
            vm.Status = "Exceuting";
            vm.Info = "Creating your order now!";

            vm.CurrentOrderName = MESClient.currentOrderName;
            vm.CurrentOrderKey = MESClient.currentOrderKey;


        }
    }
}
