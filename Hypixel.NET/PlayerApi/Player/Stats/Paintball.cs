using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Paintball
    {
        #region general stats
        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("killstreaks")]
        public int Killstreaks { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("shots_fired")]
        public int ShotsFired { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("hat")]
        public string Hat { get; set; }
        #endregion

        #region upgrades
        [JsonProperty("adrenaline")]
        public int AdrenalineLevel { get; set; }

        [JsonProperty("endurance")]
        public int EnduranceLevel { get; set; }

        [JsonProperty("forcefieldTime")]
        public int ForcefieldTime { get; set; }

        [JsonProperty("fortune")]
        public int FortuneLevel { get; set; }

        [JsonProperty("godfather")]
        public int GodfatherLevel { get; set; }

        [JsonProperty("superluck")]
        public int SuperluckLevel { get; set; }

        [JsonProperty("transfusion")]
        public int TransfusionLevel { get; set; }
        #endregion
    }
}
