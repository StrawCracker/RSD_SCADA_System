using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSDSCADA
{
    public class PLCClient
    {
        private readonly string ip = "192.168.100.13";
        private readonly int port = 10000;

        private static PLCClient client = null;



        private TcpClient tcpClient = new TcpClient();

        private PLCClient()
        {

            
                try
                {
                    tcpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                    tcpClient.Connect(ip, port);

                }
                catch (Exception e)
                {

                    //Program.GetVM().logWriteLine("Couldn't connect to the PLC!!!!!!");
                }
            

            

            
        }

        public static PLCClient Get()
        {
            if (client == null)
                client = new PLCClient();

            return client;
                     

        }


        public void sendString(string str)
        {
            if(!tcpClient.Connected)
            {
                Program.GetVM().logWriteLine("No connection!!");
                return;

            }

            NetworkStream stream = tcpClient.GetStream();

            byte[] converted = Encoding.UTF8.GetBytes(str);
            stream.Write(converted, 0, converted.Count());



        }

        public void readData()
        {
            if (!tcpClient.Connected)
                return;

            //Program.GetVM().logWriteLine("Rx connected");
            string str = "";
            NetworkStream stream = tcpClient.GetStream();
            
            if (!stream.CanRead )
                return;
            byte[] data = new byte[1024];
            
            int numBytesRead = stream.Read(data, 0, data.Length);
            if (numBytesRead > 0)
            {
                str = Encoding.ASCII.GetString(data, 0, numBytesRead);
            }


            var strList = str.Split('\n');

            foreach (var message in strList)
            {

                handleRecivedData(message);
            }



        }

        public void handleRecivedData(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;

            if(str== "new order")
            {
                sendNewOrder();

            }

            if(str== "finish order")
            {
                MESClient.finishOrder(true);
                
            }


            Program.GetVM().logWriteLine($"PLC Rx: {str}");

            var regex = new Regex(@"PackML: (.+)", RegexOptions.IgnoreCase);

            var match = regex.Match(str);

            if(match.Success)
            {
                //group 0 = PackML: Idle
                //group 1 = Idle

                //Send stuff to MES
                var state = match.Groups[1].Value;

                MESClient.Log("PML_"+ state, "No comment");

                Program.GetVM().Status= state;

                if((state=="Aborting"|| state == "Stopping")&& Program.GetVM().CurrentOrder.id!=-1)
                {

                    Program.GetVM().logWriteLine("Deleting current order.");
                    MESClient.finishOrder(false);
                    //Program.GetVM().CurrentOrder = null;
                    //Program.GetVM().CurrentOrderKey = "";
                    //MESClient.currentOrderName = null;
                    //MESClient.currentOrderKey = null;

                }


            }


        }

        public async Task sendNewOrder()
        {
            var newOrder = await MESClient.GetNewOrder();

            sendString($"o{newOrder.blue}{newOrder.red}{newOrder.yellow}");

        }


    }
}
