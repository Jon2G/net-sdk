using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveName
    {
        [JsonProperty("name")]
        public string Name { get; }
    }
}
