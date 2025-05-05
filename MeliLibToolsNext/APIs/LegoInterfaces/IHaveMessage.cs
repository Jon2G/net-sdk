using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
