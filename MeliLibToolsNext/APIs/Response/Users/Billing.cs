using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Billing
{
    [JsonProperty("allow")]
    public bool? Allow { get; set; }

    [JsonProperty("codes")]
    public List<object> Codes { get; set; }
}