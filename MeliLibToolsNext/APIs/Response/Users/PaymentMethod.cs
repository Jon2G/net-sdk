using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeliLibToolsNext.APIs.LegoInterfaces;

namespace MeliLibToolsNext.APIs.Response.Users
{
    public class PaymentMethod : IHaveThumbnail, IHaveStringId
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payment_type_id")]
        public string PaymentTypeId { get; set; }

        [JsonProperty("thumbnail")]
        public string? Thumbnail { get; set; }

        [JsonProperty("secure_thumbnail")]
        public string SecureThumbnail { get; set; }

    }
}
