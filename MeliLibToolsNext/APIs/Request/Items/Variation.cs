using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Request.Items
{
    public class Variation : IHaveLongId
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("attribute_combinations")]
        public List<AttributeCombination> AttributeCombinations { get; set; }

        [JsonProperty("sale_terms")]
        public List<object> SaleTerms { get; set; }

        [JsonProperty("picture_ids")]
        public List<string> PictureIds { get; set; }

        [JsonProperty("catalog_product_id")]
        public object CatalogProductId { get; set; }
    }
}
