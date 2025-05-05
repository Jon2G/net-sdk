using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Applications
{
    public class ApplicationData : IHaveThumbnail, IHaveLongId,IHaveName,IHaveUrl
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        [JsonProperty("catalog_product_id")]
        public object CatalogProductId { get; set; }

        [JsonProperty("item_id")]
        public object ItemId { get; set; }

        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("currency_id")]
        public object CurrencyId { get; set; }

        [JsonProperty("need_authorization")]
        public bool? NeedAuthorization { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("sandbox_mode")]
        public bool? SandboxMode { get; set; }

        [JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        [JsonProperty("project_id")]
        public object ProjectId { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("max_requests_per_hour")]
        public int? MaxRequestsPerHour { get; set; }

        [JsonProperty("scopes")]
        public List<object> Scopes { get; set; }

        [JsonProperty("domains")]
        public List<object> Domains { get; set; }
    }
}
