using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Brands;

public class Brand: IHaveName,IHaveTags
{
    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("official_store_id")]
    public int? OfficialStoreId { get; set; }

    [JsonProperty("categories_ids")]
    public List<string> CategoriesIds { get; set; }

    [JsonProperty("fantasy_name")]
    public string FantasyName { get; set; }

    [JsonProperty("site_id")]
    public string SiteId { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("pictures")]
    public List<Picture> Pictures { get; set; }

    [JsonProperty("relevance_position")]
    public int? RelevancePosition { get; set; }
}