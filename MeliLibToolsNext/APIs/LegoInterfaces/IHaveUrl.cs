using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveUrl
    {
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
