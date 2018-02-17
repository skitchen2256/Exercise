using Newtonsoft.Json;

namespace HelloWorldAPI.Models
{
    public class Message
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}