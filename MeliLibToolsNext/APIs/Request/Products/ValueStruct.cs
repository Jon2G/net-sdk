using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Request.Products
{
    public class ValueStruct
    {
        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
