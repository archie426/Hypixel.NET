using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SuperSmash
    {
        [JsonProperty("smash_level_total")]
        public long SmashLevelTotal { get; set; }

        [JsonProperty("lastLevel_THE_BULK")]
        public long LastLevelTheBulk { get; set; }

        [JsonProperty("smashLevel")]
        public long SmashLevel { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }
    }
}