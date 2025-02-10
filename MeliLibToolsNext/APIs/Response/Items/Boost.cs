using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Items;

public class Boost
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
}