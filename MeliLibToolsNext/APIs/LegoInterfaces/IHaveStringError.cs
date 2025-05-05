using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveStringError
    {    [JsonProperty("error")]
        public string Error { get; set; }
    }
}
