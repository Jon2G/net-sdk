using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class Status
{
    [JsonProperty("site_status")]
    public string SiteStatus { get; set; }

    [JsonProperty("list")]
    public List List { get; set; }

    [JsonProperty("buy")]
    public Buy Buy { get; set; }

    [JsonProperty("sell")]
    public Sell Sell { get; set; }

    [JsonProperty("billing")]
    public Billing Billing { get; set; }

    [JsonProperty("mercadopago_tc_accepted")]
    public bool? MercadopagoTcAccepted { get; set; }

    [JsonProperty("mercadopago_account_type")]
    public string MercadopagoAccountType { get; set; }

    [JsonProperty("mercadoenvios")]
    public string Mercadoenvios { get; set; }

    [JsonProperty("immediate_payment")]
    public bool? ImmediatePayment { get; set; }

    [JsonProperty("confirmed_email")]
    public bool? ConfirmedEmail { get; set; }

    [JsonProperty("user_type")]
    public string UserType { get; set; }

    [JsonProperty("required_action")]
    public string RequiredAction { get; set; }
}