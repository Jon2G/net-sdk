using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Unrated
{
    [JsonProperty("total")]
    public object Total { get; set; }

    [JsonProperty("paid")]
    public object Paid { get; set; }
}