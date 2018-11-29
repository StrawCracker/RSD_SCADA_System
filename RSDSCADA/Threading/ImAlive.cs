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
        public Thread TCPThread { get; set; }
        public ImAlive()
        {
            UptimeThread = new Thread(ImAliveThread);
            UptimeThread.Start();

            TCPThread = new Thread(ReadTCPThread);
            TCPThread.Start();
        }

        ~ImAlive()//Not used
        {
            UptimeThread.Abort();
            TCPThread.Abort();
        }

        public void ImAliveThread()
        {
            DateTime start = DateTime.Now;
            var WaitTime = new TimeSpan(0, 0, 0, 0, 10);

            while (true)
            {
                //Test there is connection to the PLC here
                

                //UpdateUptime(start - DateTime.Now)
                Thread.Sleep(WaitTime);
                Program.GetVM().Uptime=DateTime.Now-start;
                Program.GetVM().RunTime=WaitTime;//Shitty implementation yes


            }

        }

        public void ReadTCPThread()
        {
            while (true)
            {
                PLCClient.Get().readData();
            }

        }
    }
}
