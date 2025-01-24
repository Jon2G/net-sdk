using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

public class AddressData
{
    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("zip_code")]
    public string ZipCode { get; set; }
}