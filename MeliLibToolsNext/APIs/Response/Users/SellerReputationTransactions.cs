using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users
{
    public class SellerReputationTransactions
    {
        [JsonProperty("canceled")]
        public int? Canceled { get; set; }

        [JsonProperty("completed")]
        public int? Completed { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("ratings")]
        public Ratings Ratings { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }
    }
}
