using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class BuyerReputationTransactions
{
    [JsonProperty("total")]
    public int? Total { get; set; }

    [JsonProperty("paid")]
    public int? Paid { get; set; }

    [JsonProperty("units")]
    public int? Units { get; set; }
}