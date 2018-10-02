using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA.Models
{
    public class Order
    {

        public DateTime time { get; set; }

        public string status { get; set; }

        public Brick bricks { get; set; }
    }
}
