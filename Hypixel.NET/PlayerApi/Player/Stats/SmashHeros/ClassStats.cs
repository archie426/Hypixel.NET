using Hypixel.NET.PlayerApi.Player.Stats.SmashHeros.Heros;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SmashHeros
{
    public class ClassStats
    {
        [JsonProperty("THE_BULK")]
        public TheBulk TheBulk { get; set; }

        [JsonProperty("CAKE_MONSTER")]
        public CakeMonster CakeMonster { get; set; }

        [JsonProperty("GENERAL_CLUCK")]
        public GeneralCluck GeneralCluck { get; set; }

        [JsonProperty("BOTMUN")]
        public Botmun Botmun { get; set; }

        [JsonProperty("FROSTY")]
        public Frosty Frosty { get; set; }

        [JsonProperty("TINMAN")]
        public Tinman Tinman { get; set; }

        [JsonProperty("MARAUDER")]
        public Marauder Marauder { get; set; }

        [JsonProperty("GOKU")]
        public Goku Goku { get; set; }

        [JsonProperty("SPODERMAN")]
        public Spoderman Spoderman { get; set; }

        [JsonProperty("PUG")]
        public Pug Pug { get; set; }

        [JsonProperty("SKULLFIRE")]
        public Skullfire Skullfire { get; set; }

        [JsonProperty("SHOOP_DA_WHOOP")]
        public ShoopDaWhoop ShoopDaWhoop { get; set; }

        [JsonProperty("DUSK_CRAWLER")]
        public DuskCrawler DuskCrawler { get; set; }

        [JsonProperty("SERGEANT_SHIELD")]
        public SergeantShield SergeantShield { get; set; }

        [JsonProperty("SANIC")]
        public Sanic Sanic { get; set; }

        [JsonProperty("GREEN_HOOD")]
        public GreenHood GreenHood { get; set; }
    }
}