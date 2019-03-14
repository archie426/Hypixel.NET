using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Paintball
    {
        [JsonProperty("shots_fired")]
        public long ShotsFired { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("killstreaks")]
        public long Killstreaks { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("favorite_slots")]
        public string FavoriteSlots { get; set; }

        [JsonProperty("showKillPrefix")]
        public bool ShowKillPrefix { get; set; }
    }
}
