using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class TrueCombat
    {
        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("items_enchanted")]
        public long ItemsEnchanted { get; set; }

        [JsonProperty("crazywalls_deaths_team_chaos")]
        public long CrazywallsDeathsTeamChaos { get; set; }

        [JsonProperty("arrows_shot")]
        public long ArrowsShot { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("crazywalls_games_team_chaos")]
        public long CrazywallsGamesTeamChaos { get; set; }

        [JsonProperty("arrows_hit")]
        public long ArrowsHit { get; set; }

        [JsonProperty("crazywalls_losses_team_chaos")]
        public long CrazywallsLossesTeamChaos { get; set; }

        [JsonProperty("survived_players")]
        public long SurvivedPlayers { get; set; }

        [JsonProperty("kills_weekly_a")]
        public long KillsWeeklyA { get; set; }

        [JsonProperty("crazywalls_losses_solo_chaos")]
        public long CrazywallsLossesSoloChaos { get; set; }

        [JsonProperty("crazywalls_games_solo_chaos")]
        public long CrazywallsGamesSoloChaos { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("crazywalls_deaths_solo_chaos")]
        public long CrazywallsDeathsSoloChaos { get; set; }

        [JsonProperty("crazywalls_kills_solo_chaos")]
        public long CrazywallsKillsSoloChaos { get; set; }

        [JsonProperty("crazywalls_kills_monthly_a_solo_chaos")]
        public long CrazywallsKillsMonthlyASoloChaos { get; set; }

        [JsonProperty("crazywalls_kills_weekly_a_solo_chaos")]
        public long CrazywallsKillsWeeklyASoloChaos { get; set; }

        [JsonProperty("kills_monthly_a")]
        public long KillsMonthlyA { get; set; }

        [JsonProperty("crazywalls_kills_monthly_b_team_chaos")]
        public long CrazywallsKillsMonthlyBTeamChaos { get; set; }

        [JsonProperty("crazywalls_kills_team_chaos")]
        public long CrazywallsKillsTeamChaos { get; set; }

        [JsonProperty("crazywalls_kills_weekly_a_team_chaos")]
        public long CrazywallsKillsWeeklyATeamChaos { get; set; }

        [JsonProperty("kills_monthly_b")]
        public long KillsMonthlyB { get; set; }

        [JsonProperty("golden_skulls")]
        public long GoldenSkulls { get; set; }

        [JsonProperty("kills_weekly_b")]
        public long KillsWeeklyB { get; set; }

        [JsonProperty("crazywalls_kills_monthly_a_team_chaos")]
        public long CrazywallsKillsMonthlyATeamChaos { get; set; }

        [JsonProperty("crazywalls_kills_weekly_b_team_chaos")]
        public long CrazywallsKillsWeeklyBTeamChaos { get; set; }

        [JsonProperty("crazywalls_wins_team_chaos")]
        public long CrazywallsWinsTeamChaos { get; set; }

        [JsonProperty("skulls_gathered")]
        public long SkullsGathered { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("giant_zombie")]
        public long GiantZombie { get; set; }

        [JsonProperty("solo_chaos_super_luck")]
        public long SoloChaosSuperLuck { get; set; }

        [JsonProperty("gold_dust")]
        public long GoldDust { get; set; }

        [JsonProperty("kit_basic_chaos_armorer")]
        public long KitBasicChaosArmorer { get; set; }

        [JsonProperty("kit_basic_chaos_knight")]
        public long KitBasicChaosKnight { get; set; }

        [JsonProperty("activeKit_Team_chaos")]
        public string ActiveKitTeamChaos { get; set; }

        [JsonProperty("crazywalls_kills_weekly_b_solo_chaos")]
        public long CrazywallsKillsWeeklyBSoloChaos { get; set; }

        [JsonProperty("crazywalls_kills_monthly_b_solo_chaos")]
        public long CrazywallsKillsMonthlyBSoloChaos { get; set; }

        [JsonProperty("activeKit_Solo_chaos")]
        public string ActiveKitSoloChaos { get; set; }

        [JsonProperty("crazywalls_wins_solo_chaos")]
        public long CrazywallsWinsSoloChaos { get; set; }
    }
}