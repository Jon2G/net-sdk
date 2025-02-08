using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveCause
    {
        [JsonProperty("cause")]
        public List<object> Cause { get; set; }
    }
}
