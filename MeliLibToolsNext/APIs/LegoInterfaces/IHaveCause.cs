using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveCause
    {
        [JsonProperty("cause")]
        public List<object> Cause { get; set; }
    }
}
