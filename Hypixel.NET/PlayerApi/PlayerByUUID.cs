using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi
{
    public class PlayerByUuid
    {
        [JsonProperty("player")]
        public Player.Player Player { get; set; }

        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        public bool FromCache { get; set; }
    }
}
