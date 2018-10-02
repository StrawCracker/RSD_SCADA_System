using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSDSCADA.Threading
{
    public class ImAlive
    {
        public Thread UptimeThread { get; set; }
        public ImAlive()
        {
            UptimeThread = new Thread(ImAliveThread);
            UptimeThread.Start();
        }

        ~ImAlive()//Not used
        {
            UptimeThread.Abort();
        }

        public void ImAliveThread()
        {
            DateTime start = DateTime.Now;

            while (true)
            {
                //Test there is connection to the PLC here


                //UpdateUptime(start - DateTime.Now)
                Thread.Sleep(100);
                Program.GetVM().Uptime=DateTime.Now-start;
                
            }

        }
    }
}
