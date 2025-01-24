using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Response.Users
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class User
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("registration_date")]
        public string RegistrationDate { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("country_id")]
        public string CountryId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("identification")]
        public Identification Identification { get; set; }

        [JsonProperty("address")]
        public AddressData Address { get; set; }

        [JsonProperty("phone")]
        public Phone Phone { get; set; }

        [JsonProperty("alternative_phone")]
        public AlternativePhone AlternativePhone { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("logo")]
        public object Logo { get; set; }

        [JsonProperty("points")]
        public int? Points { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("seller_experience")]
        public string SellerExperience { get; set; }

        [JsonProperty("seller_reputation")]
        public SellerReputation SellerReputation { get; set; }

        [JsonProperty("buyer_reputation")]
        public BuyerReputation BuyerReputation { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("credit")]
        public Credit Credit { get; set; }
    }
}
