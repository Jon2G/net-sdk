using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Transactions
{
    [JsonProperty("period")]
    public string Period { get; set; }

    [JsonProperty("total")]
    public int? Total { get; set; }

    [JsonProperty("completed")]
    public int? Completed { get; set; }

    [JsonProperty("canceled")]
    public BuyerReputationTransactions? Canceled { get; set; }

    [JsonProperty("ratings")]
    public Ratings Ratings { get; set; }

    [JsonProperty("unrated")]
    public BuyerReputationTransactions? Unrated { get; set; }

    [JsonProperty("not_yet_rated")]
    public BuyerReputationTransactions? NotYetRated { get; set; }
}