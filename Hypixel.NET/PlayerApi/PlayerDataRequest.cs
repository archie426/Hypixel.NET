using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi
{
    public class PlayerDataRequest : IPlayerDataRequest
    {
        [JsonProperty("player")]
        public IPlayer Player { get; private set; }

        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        public bool FromCache { get; set; }
    }
}