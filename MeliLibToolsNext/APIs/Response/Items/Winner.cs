using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Items;

public class Winner
{
    [JsonProperty("item_id")]
    public string ItemId { get; set; }

    [JsonProperty("price")]
    public int? Price { get; set; }

    [JsonProperty("currency_id")]
    public string CurrencyId { get; set; }

    [JsonProperty("boosts")]
    public List<Boost> Boosts { get; set; }
}