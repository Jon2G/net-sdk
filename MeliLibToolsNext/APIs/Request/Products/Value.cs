using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Request.Products
{
    public class Value
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("struct")]
        public Struct Struct { get; set; }
    }
}
