using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Ratings
{
    [JsonProperty("positive")]
    public int? Positive { get; set; }

    [JsonProperty("negative")]
    public int? Negative { get; set; }

    [JsonProperty("neutral")]
    public int? Neutral { get; set; }
}