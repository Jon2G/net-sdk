using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class NotYetRated
{
    [JsonProperty("total")]
    public object Total { get; set; }

    [JsonProperty("paid")]
    public object Paid { get; set; }

    [JsonProperty("units")]
    public object Units { get; set; }
}