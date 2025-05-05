using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveThumbnail
    {
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; }
    }
}
