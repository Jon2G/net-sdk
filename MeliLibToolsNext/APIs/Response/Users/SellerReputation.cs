using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class SellerReputation
{
    [JsonProperty("level_id")]
    public object LevelId { get; set; }

    [JsonProperty("power_seller_status")]
    public object PowerSellerStatus { get; set; }

    [JsonProperty("transactions")]
    public Transactions Transactions { get; set; }
}