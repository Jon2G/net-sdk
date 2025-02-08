using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class SellerReputation : IHaveTags
{
    [JsonProperty("level_id")]
    public string? LevelId { get; set; }

    /// <summary>
    /// Alias for LevelId
    /// </summary>
    [JsonProperty("reputation_level_id")]
    public string? ReputationLevelId
    {
        set => LevelId = value;
        get => LevelId;
    }

    [JsonProperty("power_seller_status")]
    public object PowerSellerStatus { get; set; }

    [JsonProperty("transactions")]
    public SellerReputationTransactions Transactions { get; set; }

    [JsonProperty("tags")]
    public List<string>? Tags { get; set; }
}