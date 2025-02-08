using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveStringError
    {    [JsonProperty("error")]
        public string Error { get; set; }
    }
}
