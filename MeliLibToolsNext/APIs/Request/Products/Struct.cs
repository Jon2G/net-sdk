using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Request.Products
{
    public class Struct
    {
        [JsonProperty("number")] 
        public double? Number { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
