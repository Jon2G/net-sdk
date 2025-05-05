using MeliLibToolsNext.APIs.LegoInterfaces;
using MeliLibToolsNext.APIs.Request.Products;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Request.Items
{
    public class AttributeCombination : IHaveStringId
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("value_id")]
        public string? ValueId { get; set; }

        [JsonProperty("value_name")]
        public string? ValueName { get; set; }

        [JsonProperty("values")]
        public List<Value> Values { get; set; }

        [JsonProperty("value_type")]
        public string? ValueType { get; set; }
    }
}
