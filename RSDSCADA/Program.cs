using RSDSCADA.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSDSCADA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Start default stuff
            ViewModel = new Form1ViewModel();
            SCADAForm = new Form1(ViewModel);
            var LifetimeThread=new ImAlive();


            //Run Main
            Application.Run(SCADAForm);
            LifetimeThread.UptimeThread.Abort();
        }


        private static Form1 SCADAForm;
        private static Form1ViewModel ViewModel;

        static public Form1 GetForm()
        {

            return SCADAForm;
        }

        static public Form1ViewModel GetVM() => ViewModel;


    }
}
