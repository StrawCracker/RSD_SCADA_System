using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA.Models
{
    class OrdersResponse
    {

        public List<Order> orders { get; set; } = new List<Order>();
    }
}
