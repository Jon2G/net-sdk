using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Sell
{
    [JsonProperty("allow")]
    public bool? Allow { get; set; }

    [JsonProperty("codes")]
    public List<object> Codes { get; set; }

    [JsonProperty("immediate_payment")]
    public ImmediatePayment ImmediatePayment { get; set; }
}