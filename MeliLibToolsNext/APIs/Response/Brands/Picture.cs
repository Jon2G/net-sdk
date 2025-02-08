using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Brands;

public class Picture : IHaveName, IHaveStringId,IHaveUrl
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("secure_url")]
    public object SecureUrl { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("size")]
    public string Size { get; set; }

    [JsonProperty("max_size")]
    public string MaxSize { get; set; }

    [JsonProperty("quality")]
    public string Quality { get; set; }
}