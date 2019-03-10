using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.Player.Stats
{
    public class Stats
    {
        [JsonProperty("Arena")]
        public Dictionary<string, long> Arena { get; set; }

        [JsonProperty("HungerGames")]
        public HungerGames HungerGames { get; set; }

        [JsonProperty("Paintball")]
        public Paintball Paintball { get; set; }

        [JsonProperty("Quake")]
        public Quake Quake { get; set; }

        [JsonProperty("TNTGames")]
        public TntGames TntGames { get; set; }

        [JsonProperty("UHC")]
        public Uhc Uhc { get; set; }

        [JsonProperty("VampireZ")]
        public VampireZ VampireZ { get; set; }

        [JsonProperty("Walls")]
        public Dictionary<string, long> Walls { get; set; }

        [JsonProperty("Walls3")]
        public Walls3 Walls3 { get; set; }

        [JsonProperty("GingerBread")]
        public GingerBread GingerBread { get; set; }

        [JsonProperty("Arcade")]
        public Arcade Arcade { get; set; }

        [JsonProperty("SkyWars")]
        public Dictionary<string, SkyWarValue> SkyWars { get; set; }

        [JsonProperty("TrueCombat")]
        public TrueCombat TrueCombat { get; set; }

        [JsonProperty("Battleground")]
        public Battleground Battleground { get; set; }

        [JsonProperty("MCGO")]
        public Mcgo Mcgo { get; set; }

        [JsonProperty("SuperSmash")]
        public SuperSmash SuperSmash { get; set; }

        [JsonProperty("SpeedUHC")]
        public SpeedUhc SpeedUhc { get; set; }

        [JsonProperty("SkyClash")]
        public SkyClash SkyClash { get; set; }

        [JsonProperty("Legacy")]
        public Legacy Legacy { get; set; }

        [JsonProperty("Bedwars")]
        public Bedwars Bedwars { get; set; }

        [JsonProperty("MurderMystery")]
        public MurderMystery MurderMystery { get; set; }

        [JsonProperty("Duels")]
        public Duels Duels { get; set; }

        [JsonProperty("BuildBattle")]
        public BuildBattle BuildBattle { get; set; }
    }
}
