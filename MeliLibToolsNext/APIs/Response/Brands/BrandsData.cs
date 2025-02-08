using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Response.Brands
{
    public class BrandsData:IHaveTags
    {
        [JsonProperty("cust_id")]
        public int? CustId { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("brands")]
        public List<Brand> Brands { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }
    }

}
