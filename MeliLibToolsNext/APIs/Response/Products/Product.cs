﻿using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Products
{
    public class Product : IHaveStringId, IHaveName
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("domain_id")]
        public string DomainId { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }
        [JsonProperty("buy_box_winner")]
        public BuyBoxWinner? BuyBoxWinner { get; set; }
    }
}
