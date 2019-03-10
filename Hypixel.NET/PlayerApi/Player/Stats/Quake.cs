using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Quake
    {
        [JsonProperty("barrel")]
        public string Barrel { get; set; }

        [JsonProperty("case")]
        public string Case { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("hat")]
        public string Hat { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("killstreaks")]
        public long Killstreaks { get; set; }

        [JsonProperty("muzzle")]
        public string Muzzle { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("sight")]
        public string Sight { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("kills_teams")]
        public long KillsTeams { get; set; }

        [JsonProperty("killstreaks_teams")]
        public long KillstreaksTeams { get; set; }

        [JsonProperty("deaths_teams")]
        public long DeathsTeams { get; set; }

        [JsonProperty("wins_teams")]
        public long WinsTeams { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("monthly_kills_b")]
        public long MonthlyKillsB { get; set; }

        [JsonProperty("weekly_kills_b")]
        public long WeeklyKillsB { get; set; }

        [JsonProperty("weekly_kills_a")]
        public long WeeklyKillsA { get; set; }

        [JsonProperty("monthly_kills_a")]
        public long MonthlyKillsA { get; set; }

        [JsonProperty("compass_selected")]
        public bool CompassSelected { get; set; }

        [JsonProperty("alternative_gun_cooldown_indicator")]
        public bool AlternativeGunCooldownIndicator { get; set; }

        [JsonProperty("enable_sound")]
        public bool EnableSound { get; set; }

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

        [JsonProperty("kills_since_update_feb_2017")]
        public long KillsSinceUpdateFeb2017 { get; set; }

        [JsonProperty("showKillPrefix")]
        public bool ShowKillPrefix { get; set; }

        [JsonProperty("showDashCooldown")]
        public bool ShowDashCooldown { get; set; }

        [JsonProperty("distance_travelled_teams")]
        public long DistanceTravelledTeams { get; set; }

        [JsonProperty("kills_since_update_feb_2017_teams")]
        public long KillsSinceUpdateFeb2017_Teams { get; set; }

        [JsonProperty("shots_fired_teams")]
        public long ShotsFiredTeams { get; set; }

        [JsonProperty("headshots_teams")]
        public long HeadshotsTeams { get; set; }

        [JsonProperty("messageOthers' Kills/deaths")]
        public bool MessageOthersKillsDeaths { get; set; }

        [JsonProperty("messageKillstreaks")]
        public bool MessageKillstreaks { get; set; }

        [JsonProperty("messageCoin Messages")]
        public bool MessageCoinMessages { get; set; }

        [JsonProperty("messageYour Kills")]
        public bool MessageYourKills { get; set; }

        [JsonProperty("messageMulti-kills")]
        public bool MessageMultiKills { get; set; }

        [JsonProperty("messagePowerup Collections")]
        public bool MessagePowerupCollections { get; set; }

        [JsonProperty("messageYour Deaths")]
        public bool MessageYourDeaths { get; set; }

        [JsonProperty("kills_dm_teams")]
        public long KillsDmTeams { get; set; }

        [JsonProperty("kills_timeattack")]
        public long KillsTimeattack { get; set; }

        [JsonProperty("kills_dm")]
        public long KillsDm { get; set; }
    }
}
