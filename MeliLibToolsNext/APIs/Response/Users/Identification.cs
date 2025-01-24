using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Identification
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }
}