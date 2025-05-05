using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users
{

    public class ListingDetail
    {
        [JsonProperty("listing_type_id")]
        public string ListingTypeId { get; set; }

        [JsonProperty("available_listings")]
        public int? AvailableListings { get; set; }

        [JsonProperty("used_listings")]
        public int? UsedListings { get; set; }

        [JsonProperty("remaining_listings")]
        public int? RemainingListings { get; set; }
    }

    public class PromotionPack
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("promotion_pack_id")]
        public string PromotionPackId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("package_type")]
        public string PackageType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_start")]
        public DateTime? DateStart { get; set; }

        [JsonProperty("date_expires")]
        public DateTime? DateExpires { get; set; }

        [JsonProperty("date_stopped")]
        public object DateStopped { get; set; }

        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [JsonProperty("engagement_type")]
        public string EngagementType { get; set; }

        [JsonProperty("charge_id")]
        public int? ChargeId { get; set; }

        [JsonProperty("remaining_listings")]
        public int? RemainingListings { get; set; }

        [JsonProperty("used_listings")]
        public int? UsedListings { get; set; }

        [JsonProperty("listing_details")]
        public List<ListingDetail> ListingDetails { get; set; }
    }

}
