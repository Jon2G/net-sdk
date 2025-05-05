using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveTags
    {

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }
    }
}
