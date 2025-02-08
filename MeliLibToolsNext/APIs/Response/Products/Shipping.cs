using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Response.Products
{
    public class Shipping:IHaveTags
    {   [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("free_shipping")]
        public bool? FreeShipping { get; set; }

        [JsonProperty("logistic_type")]
        public string LogisticType { get; set; }

        [JsonProperty("store_pick_up")]
        public bool? StorePickUp { get; set; }
    }
}
