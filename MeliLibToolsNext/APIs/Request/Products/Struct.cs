using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Request.Products
{
    public class Struct
    {
        [JsonProperty("number")] 
        public int? Number { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
