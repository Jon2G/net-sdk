using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class AlternativePhone
{
    [JsonProperty("area_code")]
    public string AreaCode { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }

    [JsonProperty("extension")]
    public string Extension { get; set; }
}