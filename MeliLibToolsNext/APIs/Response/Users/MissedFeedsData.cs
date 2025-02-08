using MeliLibToolsNext.APIs.LegoInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.Response.Users
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Headers
    {
        [JsonProperty("accept")]
        public string Accept { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("content-length")]
        public int? ContentLength { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("connection")]
        public string Connection { get; set; }
    }

    public class Message
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("application_id")]
        public object ApplicationId { get; set; }

        [JsonProperty("attempts")]
        public int? Attempts { get; set; }

        [JsonProperty("sent")]
        public DateTime? Sent { get; set; }

        [JsonProperty("received")]
        public DateTime? Received { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }

    public class Request : IHaveUrl
    {
        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class Response
    {
        [JsonProperty("req_time")]
        public int? ReqTime { get; set; }

        [JsonProperty("http_code")]
        public int? HttpCode { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }
    }

    public class MissedFeedsData
    {
        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }
    }

}
