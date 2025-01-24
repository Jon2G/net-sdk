using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Brands;

public class Picture
{
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("secure_url")]
    public object SecureUrl { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("size")]
    public string Size { get; set; }
}