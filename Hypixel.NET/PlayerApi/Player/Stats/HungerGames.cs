using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.Player.Stats
{
    public class HungerGames
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("monthly_kills_a")]
        public long MonthlyKillsA { get; set; }

        [JsonProperty("weekly_kills_b")]
        public long WeeklyKillsB { get; set; }

        [JsonProperty("weekly_kills_a")]
        public long WeeklyKillsA { get; set; }

        [JsonProperty("scout")]
        public long Scout { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("armorer")]
        public long Armorer { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("lastTourneyAd")]
        public long LastTourneyAd { get; set; }
    }
}
