using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Mcgo
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("bombs_defused")]
        public long BombsDefused { get; set; }

        [JsonProperty("kills_deathmatch")]
        public long KillsDeathmatch { get; set; }

        [JsonProperty("game_wins")]
        public long GameWins { get; set; }

        [JsonProperty("bombs_planted")]
        public long BombsPlanted { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("game_wins_deathmatch")]
        public long GameWinsDeathmatch { get; set; }

        [JsonProperty("grenadeKills")]
        public long GrenadeKills { get; set; }

        [JsonProperty("headshot_kills")]
        public long HeadshotKills { get; set; }

        [JsonProperty("pocket_change")]
        public long PocketChange { get; set; }

        [JsonProperty("grenade_kills")]
        public long McgoGrenadeKills { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("shots_fired")]
        public long ShotsFired { get; set; }

        [JsonProperty("round_wins")]
        public long RoundWins { get; set; }

        [JsonProperty("criminal_kills")]
        public long CriminalKills { get; set; }
    }
}