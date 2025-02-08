using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
