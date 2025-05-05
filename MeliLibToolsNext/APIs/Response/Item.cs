using MeliLibToolsNext.APIs.LegoInterfaces;
using MeliLibToolsNext.APIs.Response.Brands;
using MeliLibToolsNext.APIs.Response.Products;
using MeliLibToolsNext.APIs.Response.Users;
using Newtonsoft.Json;
using MeliLibToolsNext.APIs.Request.Items;

namespace MeliLibToolsNext.APIs.Response
{
    public class Item :IHaveStringId,IHaveStringStatus
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("site_id")]
        public string? SiteId { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("seller_id")]
        public long? SellerId { get; set; }

        [JsonProperty("category_id")]
        public string? CategoryId { get; set; }

        [JsonProperty("official_store_id")]
        public object OfficialStoreId { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("base_price")]
        public double? BasePrice { get; set; }

        [JsonProperty("original_price")]
        public object OriginalPrice { get; set; }

        [JsonProperty("currency_id")]
        public string? CurrencyId { get; set; }

        [JsonProperty("initial_quantity")]
        public int? InitialQuantity { get; set; }

        [JsonProperty("buying_mode")]
        public string? BuyingMode { get; set; }

        [JsonProperty("listing_type_id")]
        public string? ListingTypeId { get; set; }

        [JsonProperty("condition")]
        public string? Condition { get; set; }

        [JsonProperty("permalink")]
        public string? Permalink { get; set; }

        [JsonProperty("thumbnail_id")]
        public string? ThumbnailId { get; set; }

        [JsonProperty("thumbnail")]
        public string? Thumbnail { get; set; }
        [JsonProperty("video_id")]
        public object VideoId { get; set; }

        [JsonProperty("descriptions")]
        public List<object> Descriptions { get; set; }

        [JsonProperty("accepts_mercadopago")]
        public bool? AcceptsMercadopago { get; set; }

        [JsonProperty("non_mercado_pago_payment_methods")]
        public List<object> NonMercadoPagoPaymentMethods { get; set; }
        [JsonProperty("seller_contact")]
        public object SellerContact { get; set; }
        [JsonProperty("coverage_areas")]
        public List<object> CoverageAreas { get; set; }
        [JsonProperty("listing_source")]
        public string? ListingSource { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("sub_status")]
        public List<object> SubStatus { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("warranty")]
        public string? Warranty { get; set; }

        [JsonProperty("catalog_product_id")]
        public string CatalogProductId { get; set; }

        [JsonProperty("domain_id")]
        public string? DomainId { get; set; }

        [JsonProperty("parent_item_id")]
        public object ParentItemId { get; set; }

        [JsonProperty("deal_ids")]
        public List<object> DealIds { get; set; }

        [JsonProperty("automatic_relist")]
        public bool? AutomaticRelist { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [JsonProperty("health")]
        public double? Health { get; set; }

        [JsonProperty("catalog_listing")]
        public bool? CatalogListing { get; set; }

        [JsonProperty("sale_terms")]
        public List<ValueIdNameStruct> SaleTerms { get; set; }

        [JsonProperty("pictures")]
        public List<Picture> Pictures { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }
        [JsonProperty("seller_address")]
        public AddressData SellerAddress { get; set; }
        [JsonProperty("location")]
        public object Location { get; set; }
        [JsonProperty("attributes")]
        public List<AttributeCombination> Attributes { get; set; }
        [JsonProperty("variations")]
        public List<Variation> Variations { get; set; }
    }
}
