using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Quake
    {
        #region general stats
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

        [JsonProperty("instantRespawn")]
        public bool InstantRespawn { get; set; }

        [JsonProperty("highest_killstreak")]
        public long HighestKillstreak { get; set; }

        [JsonProperty("headshots")]
        public long Headshots { get; set; }

        [JsonProperty("distance_travelled")]
        public long DistanceTravelled { get; set; }

        [JsonProperty("shots_fired")]
        public long ShotsFired { get; set; }

        [JsonProperty("kills_timeattack")]
        public long KillsTimeattack { get; set; }

        [JsonProperty("kills_dm")]
        public long KillsDm { get; set; }

        [JsonProperty("hat")]
        public string Hat { get; set; }
        #endregion

        #region teams
        [JsonProperty("wins_teams")]
        public long WinsTeams { get; set; }

        [JsonProperty("kills_teams")]
        public long KillsTeams { get; set; }

        [JsonProperty("deaths_teams")]
        public long DeathsTeams { get; set; }

        [JsonProperty("killstreaks_teams")]
        public long KillstreaksTeams { get; set; }

        [JsonProperty("distance_travelled_teams")]
        public long DistanceTravelledTeams { get; set; }

        [JsonProperty("shots_fired_teams")]
        public long ShotsFiredTeams { get; set; }

        [JsonProperty("headshots_teams")]
        public long HeadshotsTeams { get; set; }

        [JsonProperty("kills_dm_teams")]
        public long KillsDmTeams { get; set; }
        #endregion

        #region weapon
        [JsonProperty("barrel")]
        public string Barrel { get; set; }

        [JsonProperty("case")]
        public string Case { get; set; }

        [JsonProperty("killsound")]
        public string Killsound { get; set; }

        [JsonProperty("muzzle")]
        public string Muzzle { get; set; }

        [JsonProperty("sight")]
        public string Sight { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("beam")]
        public string Beam { get; set; }
        #endregion
    }
}
