using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA.Models
{
    public class LogMessage
    {
        public string comment { get; set; }


        [JsonProperty("event")]
        public string jsonEvent { get; set; }

        public int cell_id = 1;
    }
}
