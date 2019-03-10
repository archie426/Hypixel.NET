using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class VampireZ
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("human_deaths")]
        public long HumanDeaths { get; set; }

        [JsonProperty("vampire_deaths")]
        public long VampireDeaths { get; set; }

        [JsonProperty("zombie_kills")]
        public long ZombieKills { get; set; }

        [JsonProperty("gold_bought")]
        public long GoldBought { get; set; }

        [JsonProperty("vampire_kills")]
        public long VampireKills { get; set; }

        [JsonProperty("updated_stats")]
        public bool UpdatedStats { get; set; }

        [JsonProperty("most_vampire_kills")]
        public long MostVampireKills { get; set; }

        [JsonProperty("human_wins")]
        public long HumanWins { get; set; }

        [JsonProperty("monthly_human_wins_b")]
        public long MonthlyHumanWinsB { get; set; }

        [JsonProperty("weekly_human_wins_a")]
        public long WeeklyHumanWinsA { get; set; }

        [JsonProperty("most_vampire_kills_new")]
        public long MostVampireKillsNew { get; set; }
    }
}