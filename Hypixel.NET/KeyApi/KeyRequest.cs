using Hypixel.NET.KeyApi.Record;
using Newtonsoft.Json;

namespace Hypixel.NET.KeyApi
{
    public class KeyRequest : IKeyRequest
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("record")]
        public IRecord Record { get; private set; }
    }
}