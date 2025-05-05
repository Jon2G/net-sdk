using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response
{
    public class Response
    {
        public Response()
        {
            
        }
    }

    public class Response<T>(T? data) : Response
    {
        public T? Data { get; } = data;
    }

    public class BodyResponse<T>(T? data) : Response,IHaveMessage,IHaveStringError,IHaveStringStatus,IHaveCause
    {
        [JsonProperty("code")]
        public int? Code { get; set; }
        [JsonProperty("body")]
        public T? Data { get; } = data;

        public string Message { get; set; }
        public string Error { get; set; }
        public string? Status { get; set; }
        public List<object> Cause { get; set; }
    }
}
