using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class VampireZ
    {
        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("explosive_killer")]
        public int ExplosiveKiller { get; set; }

        [JsonProperty("fireproofing")]
        public int Fireproofing { get; set; }

        [JsonProperty("gold_booster")]
        public int GoldBooster { get; set; }

        [JsonProperty("gold_starter")]
        public int GoldStarter { get; set; }

        [JsonProperty("human_deaths")]
        public int HumanDeaths { get; set; }

        [JsonProperty("human_kills")]
        public int HumanKills { get; set; }

        [JsonProperty("human_wins")]
        public int HumanWins { get; set; }

        [JsonProperty("most_vampire_kills")]
        public int MostVampireKills { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("vampire_deaths")]
        public int VampireDeaths { get; set; }

        [JsonProperty("vampire_doubler")]
        public int VampireDoubler { get; set; }

        [JsonProperty("vampire_kills")]
        public int VampireKills { get; set; }

        [JsonProperty("vampiric_minion")]
        public int VampiricMinion { get; set; }

        [JsonProperty("zombie_doubler")]
        public int ZombieDoubler { get; set; }

        [JsonProperty("zombie_kills")]
        public int ZombieKills { get; set; }

        [JsonProperty("transfusion")]
        public int Transfusion { get; set; }

        [JsonProperty("renfield")]
        public int Renfield { get; set; }

        [JsonProperty("frankensteins_monster")]
        public int FrankensteinsMonster { get; set; }

        [JsonProperty("gold_bought")]
        public int GoldBought { get; set; }

        [JsonProperty("vampire_wins")]
        public int VampireWins { get; set; }
    }
}