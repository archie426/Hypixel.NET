using Newtonsoft.Json;

namespace Hypixel.NET.KeyApi
{
    public class GetKey
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("record")]
        public Record.Record Record { get; set; }
    }
}