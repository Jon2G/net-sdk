using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class BuyerReputation:IHaveTags
{
    [JsonProperty("canceled_transactions")]
    public int? CanceledTransactions { get; set; }

    [JsonProperty("transactions")]
    public Transactions Transactions { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }
}