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
        private static readonly string baseUrl = "https://dmi.dk";

        public static string currentOrderName = "TestName";
        public static string currentOrderKey = "TestKey";

        private static HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            return client;

        }

        public static List<string> GetOrders()
        {

            var client = GetClient();

            var response = client.GetAsync("orders").Result;

            var responseStr= response.Content.ReadAsStringAsync().Result;

            var orders = JsonConvert.DeserializeObject<OrdersResponse>(responseStr);


            return orders.orders;
        }


        public static Order GetOrder(string orderName)
        {
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

                var response =client.PutAsync($"orders/{orderName}",new StringContent("")).Result;

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

        public static bool EndCurrentOrder()
        {
            try
            {
                var client = GetClient();

                var response = client.DeleteAsync($"orders/{currentOrderName}/{currentOrderKey}").Result;

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
        


    }
}
