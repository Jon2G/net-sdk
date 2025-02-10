using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Items
{
    public class PriceToWin
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("current_price")]
        public int? CurrentPrice { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("price_to_win")]
        public double? PriceToWinAmount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("consistent")]
        public bool? Consistent { get; set; }

        [JsonProperty("visit_share")]
        public string VisitShare { get; set; }

        [JsonProperty("competitors_sharing_first_place")]
        public int? CompetitorsSharingFirstPlace { get; set; }

        [JsonProperty("reason")]
        public List<object> Reason { get; set; }

        [JsonProperty("catalog_product_id")]
        public string CatalogProductId { get; set; }

        [JsonProperty("boosts")]
        public List<Boost> Boosts { get; set; }

        [JsonProperty("winner")]
        public Winner Winner { get; set; }
    }
}
