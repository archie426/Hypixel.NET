﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public class Leaderboard : ILeaderboard
    {
        [JsonProperty("TNTGAMES")]
        public List<ILeaderboardData> TntGames { get; set; }

        [JsonProperty("WALLS")]
        public List<ILeaderboardData> Walls { get; set; }

        [JsonProperty("QUAKECRAFT")]
        public List<ILeaderboardData> Quake { get; set; }

        [JsonProperty("SKYWARS")]
        public List<ILeaderboardData> SkyWars { get; set; }

        [JsonProperty("VAMPIREZ")]
        public List<ILeaderboardData> VampireZ { get; set; }

        [JsonProperty("WALLS3")]
        public List<ILeaderboardData> Walls3 { get; set; }

        [JsonProperty("SKYCLASH")]
        public List<ILeaderboardData> SkyClash { get; set; }

        [JsonProperty("BEDWARS")]
        public List<ILeaderboardData> BedWars { get; set; }

        [JsonProperty("BUILD_BATTLE")]
        public List<ILeaderboardData> BuildBattle { get; set; }

        [JsonProperty("UHC")]
        public List<ILeaderboardData> Uhc { get; set; }

        [JsonProperty("PAINTBALL")]
        public List<ILeaderboardData> PaintBall { get; set; }

        [JsonProperty("SUPER_SMASH")]
        public List<ILeaderboardData> Smash { get; set; }

        [JsonProperty("TRUE_COMBAT")]
        public List<ILeaderboardData> TrueCombat { get; set; }

        [JsonProperty("MCGO")]
        public List<ILeaderboardData> CopsAndCrims { get; set; }

        [JsonProperty("SURVIVAL_GAMES")]
        public List<ILeaderboardData> BlitzSg { get; set; }

        [JsonProperty("BATTLEGROUND")]
        public List<ILeaderboardData> Warlords { get; set; }

        [JsonProperty("MURDER_MYSTERY")]
        public List<ILeaderboardData> MurderMystery { get; set; }

        [JsonProperty("ARENA")]
        public List<ILeaderboardData> Arena { get; set; }

        [JsonProperty("SPEED_UHC")]
        public List<ILeaderboardData> SpeedUhc { get; set; }

        [JsonProperty("ARCADE")]
        public List<ILeaderboardData> Arcade { get; set; }

        [JsonProperty("DUELS")]
        public List<ILeaderboardData> Duels { get; set; }

        [JsonProperty("GINGERBREAD")]
        public List<ILeaderboardData> TurboKartRacers { get; set; }
    }
}