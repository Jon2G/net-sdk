using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Credit
{
    [JsonProperty("consumed")]
    public int? Consumed { get; set; }

    [JsonProperty("credit_level_id")]
    public string CreditLevelId { get; set; }
}