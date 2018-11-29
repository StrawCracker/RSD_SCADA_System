using Newtonsoft.Json;
using RSDSCADA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA
{
    public static class MESClient
    {
        private static readonly string baseUrl = "http://192.168.100.200";

        public static string currentOrderName = "";
        public static string currentOrderKey = "";

        private static HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            return client;

        }

        public static List<Order> GetOrders()
        {

            var client = GetClient();

            var response = client.GetAsync("orders").Result;

            var responseStr = response.Content.ReadAsStringAsync().Result;

            var orders = JsonConvert.DeserializeObject<OrdersResponse>(responseStr);


            return orders.orders;
        }


        public static Order GetOrder(string orderName)
        {
            //Shitty function don't use       
            var client = GetClient();

            var response = client.GetAsync($"orders/{orderName}").Result;

            var responseStr = response.Content.ReadAsStringAsync().Result;

            var order = JsonConvert.DeserializeObject<Order>(responseStr);


            return order;

        }


        public static bool StartOrder(string orderName)
        {
            if (!string.IsNullOrEmpty(currentOrderName) || !string.IsNullOrEmpty(currentOrderKey))
                return false;

            try
            {
                var client = GetClient();

                var response = client.PutAsync($"orders/{orderName}", new StringContent("")).Result;

                var responseStr = response.Content.ReadAsStringAsync().Result;

                var putOrderResp = JsonConvert.DeserializeObject<PutOrderResponse>(responseStr);

                if (!response.IsSuccessStatusCode || string.IsNullOrEmpty(putOrderResp.ticket))
                    throw new Exception();

                currentOrderName = orderName;
                currentOrderKey = putOrderResp.ticket;
                return true;


            }
            catch (Exception e)
            {
                //Shit fucked up, no problem

                currentOrderKey = "";
                currentOrderName = "";
                return false;

            }
        }


        static List<String> EventTypes = new List<string> {
            "PML_Idle",
            "PML_Execute",
            "PML_Complete",
            "PML_Held",
            "PML_Suspended",
            "PML_Aborted",
            "PML_Stopped",
            "Order_Start",
            "Order_Done"
            };

        public static async Task Log(string PackMl, string comment)
        {


            if (!EventTypes.Contains(PackMl))
                return;


            try
            {
                var client = GetClient();

                var log = new LogMessage { jsonEvent = PackMl, comment = comment };


                var res =await client.PostAsync("log", new StringContent(JsonConvert.SerializeObject(log), Encoding.UTF8, "application/json"));


                //var str = await res.Content.ReadAsStringAsync();

                if (res.StatusCode != System.Net.HttpStatusCode.OK)
                    Program.GetVM().logWriteLine("Bad response from logging to MES..");

            }
            catch (Exception)
            {

                throw;
            }


        }



        public static bool EndCurrentOrder()
        {
            try
            {
                var client = GetClient();

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(new { ticket= currentOrderKey}), Encoding.UTF8, "application/json"),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{client.BaseAddress}orders/{currentOrderName}")
                };


                var response = client.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    currentOrderKey = "";
                    currentOrderName = "";

                    return true;

                }
             
                
            }
            catch (Exception e)
            {

                return false;
            }


            return false;
        }



        public static async Task<Order> GetNewOrder()
        {
            
            //Code for getting a new order

            if (!string.IsNullOrEmpty(currentOrderKey))
            {
                Program.GetVM().logWriteLine("Can't get new order when one is already ongoing");
            }

            Order selectedOrder=null;

            while (selectedOrder==null)
            {


                try
                {
                    var orders = GetOrders();

                    var maxValue = orders.Max(o => o.rating());

                    selectedOrder = orders.First(o => o.rating() == maxValue);
                }
                catch (Exception)
                {
                   
                    Program.GetVM().logWriteLine("Couldn't get orders, trying again.");
                    selectedOrder = null;
                    continue;
                }

                if(! StartOrder(selectedOrder.id.ToString()))
                {
                    selectedOrder = null;
                    Program.GetVM().logWriteLine("Couldn't start new order, trying again.");
                }
            }

            Program.GetVM().CurrentOrder = selectedOrder;
            Program.GetVM().CurrentOrderKey = currentOrderKey;


            Log("Order_Start", "No comment");

            return selectedOrder;
        }

        static public async Task finishOrder(bool doneCorrect)
        {
            Log("Order_Done", "No comment");
            if(!EndCurrentOrder())
                Program.GetVM().logWriteLine("Failed to delete order");


            

            if(Program.GetVM().OrderTime > new TimeSpan(0,1,0))
            {
                Program.GetVM().logWriteLine($"To slow order {Program.GetVM().OrderTimeStr} - 10 points");
                Program.GetVM().CurrentOrder.Ontime = false;
            }

            Program.GetVM().CurrentOrder.CorrectOrder = doneCorrect;

            //Check for invoke....
            Program.GetVM().AddDoneOrder(Program.GetVM().CurrentOrder);





            Program.GetVM().CurrentOrder = null;
            Program.GetVM().CurrentOrderKey = currentOrderKey;

        }
        


    }
}
