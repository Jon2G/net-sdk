using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs.LegoInterfaces;
using MeliLibToolsNext.APIs.Response.Users;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Products
{
    public class BuyBoxWinner:IHaveTags,IHaveItemOverrideAttributes
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("seller_id")]
        public int? SellerId { get; set; }

        [JsonProperty("price")]
        public int? Price { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("warranty")]
        public string Warranty { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("official_store_id")]
        public string? OfficialStoreId { get; set; }

        [JsonProperty("original_price")]
        public object OriginalPrice { get; set; }

        [JsonProperty("listing_type_id")]
        public string ListingTypeId { get; set; }

        [JsonProperty("accepts_mercadopago")]
        public bool? AcceptsMercadopago { get; set; }

        [JsonProperty("international_delivery_mode")]
        public string InternationalDeliveryMode { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("inventory_id")]
        public string InventoryId { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }
        [JsonProperty("shipping")]
        public Shipping? Shipping { get; set; }
        [JsonProperty("sale_terms")]
        public List<ValueIdNameStruct>? SaleTerms { get; set; }

        [JsonProperty("seller_address")]
        public AddressData? SellerAddress { get; set; }
        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }

        [JsonProperty("item_override_attributes")]
        public List<object>? ItemOverrideAttributes { get; set; }

        [JsonProperty("seller")]
        public SellerReputation Seller { get; set; }

        [JsonProperty("deal_ids")]
        public List<string>? DealIds { get; set; }
    }
}
