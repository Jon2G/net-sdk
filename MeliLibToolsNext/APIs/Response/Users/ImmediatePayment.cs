using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class ImmediatePayment
{
    [JsonProperty("required")]
    public bool? Required { get; set; }

    [JsonProperty("reasons")]
    public List<object> Reasons { get; set; }
}