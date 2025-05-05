using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveName
    {
        [JsonProperty("name")]
        public string Name { get; }
    }
}
