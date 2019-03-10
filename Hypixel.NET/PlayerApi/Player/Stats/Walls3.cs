using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Walls3
    {
        [JsonProperty("chosen_class")]
        public string ChosenClass { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("deaths_Skeleton")]
        public long DeathsSkeleton { get; set; }

        [JsonProperty("deaths_Zombie")]
        public long DeathsZombie { get; set; }

        [JsonProperty("finalDeaths")]
        public long FinalDeaths { get; set; }

        [JsonProperty("finalKills")]
        public long FinalKills { get; set; }

        [JsonProperty("finalKills_Skeleton")]
        public long FinalKillsSkeleton { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_Skeleton")]
        public long KillsSkeleton { get; set; }

        [JsonProperty("kills_Zombie")]
        public long KillsZombie { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_Skeleton")]
        public long LossesSkeleton { get; set; }

        [JsonProperty("losses_Zombie")]
        public long LossesZombie { get; set; }

        [JsonProperty("monthly_finalKills_Skeleton_b")]
        public long MonthlyFinalKillsSkeletonB { get; set; }

        [JsonProperty("mutations_visibility")]
        public bool MutationsVisibility { get; set; }

        [JsonProperty("skeleton_a")]
        public long SkeletonA { get; set; }

        [JsonProperty("skeleton_b")]
        public long SkeletonB { get; set; }

        [JsonProperty("skeleton_c")]
        public long SkeletonC { get; set; }

        [JsonProperty("skeleton_d")]
        public long SkeletonD { get; set; }

        [JsonProperty("skeleton_g")]
        public long SkeletonG { get; set; }

        [JsonProperty("weeklyDeaths")]
        public long WeeklyDeaths { get; set; }

        [JsonProperty("weeklyDeaths_Skeleton")]
        public long WeeklyDeathsSkeleton { get; set; }

        [JsonProperty("weeklyDeaths_Zombie")]
        public long WeeklyDeathsZombie { get; set; }

        [JsonProperty("weeklyKills")]
        public long WeeklyKills { get; set; }

        [JsonProperty("weeklyKills_Skeleton")]
        public long WeeklyKillsSkeleton { get; set; }

        [JsonProperty("weeklyKills_Zombie")]
        public long WeeklyKillsZombie { get; set; }

        [JsonProperty("weeklyLosses")]
        public long WeeklyLosses { get; set; }

        [JsonProperty("weeklyLosses_Skeleton")]
        public long WeeklyLossesSkeleton { get; set; }

        [JsonProperty("weeklyLosses_Zombie")]
        public long WeeklyLossesZombie { get; set; }

        [JsonProperty("weeklyWins")]
        public long WeeklyWins { get; set; }

        [JsonProperty("weeklyWins_Skeleton")]
        public long WeeklyWinsSkeleton { get; set; }

        [JsonProperty("weekly_finalKills_Skeleton_a")]
        public long WeeklyFinalKillsSkeletonA { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("wins_Skeleton")]
        public long WinsSkeleton { get; set; }

        [JsonProperty("zombie_b")]
        public long ZombieB { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("plays_standard")]
        public long PlaysStandard { get; set; }

        [JsonProperty("finalAssists")]
        public long FinalAssists { get; set; }

        [JsonProperty("assists_Skeleton")]
        public long AssistsSkeleton { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("finalAssists_Skeleton")]
        public long FinalAssistsSkeleton { get; set; }

        [JsonProperty("deaths_new")]
        public long DeathsNew { get; set; }

        [JsonProperty("kills_new_Skeleton")]
        public long KillsNewSkeleton { get; set; }

        [JsonProperty("deaths_new_Skeleton")]
        public long DeathsNewSkeleton { get; set; }

        [JsonProperty("kills_new")]
        public long KillsNew { get; set; }

        [JsonProperty("zombie_kills")]
        public long ZombieKills { get; set; }

        [JsonProperty("skeleton_deaths")]
        public long SkeletonDeaths { get; set; }

        [JsonProperty("zombie_losses")]
        public long ZombieLosses { get; set; }

        [JsonProperty("total_final_kills")]
        public long TotalFinalKills { get; set; }

        [JsonProperty("zombie_deaths")]
        public long ZombieDeaths { get; set; }

        [JsonProperty("skeleton_final_assists")]
        public long SkeletonFinalAssists { get; set; }

        [JsonProperty("skeleton_wins")]
        public long SkeletonWins { get; set; }

        [JsonProperty("skeleton_total_final_kills_standard")]
        public long SkeletonTotalFinalKillsStandard { get; set; }

        [JsonProperty("skeleton_total_final_kills")]
        public long SkeletonTotalFinalKills { get; set; }

        [JsonProperty("total_final_kills_standard")]
        public long TotalFinalKillsStandard { get; set; }

        [JsonProperty("skeleton_wins_standard")]
        public long SkeletonWinsStandard { get; set; }

        [JsonProperty("skeleton_kills")]
        public long SkeletonKills { get; set; }

        [JsonProperty("skeleton_losses")]
        public long SkeletonLosses { get; set; }

        [JsonProperty("final_kills")]
        public long Walls3FinalKills { get; set; }

        [JsonProperty("skeleton_final_kills")]
        public long SkeletonFinalKills { get; set; }

        [JsonProperty("final_kills_standard")]
        public long FinalKillsStandard { get; set; }

        [JsonProperty("skeleton_final_kills_standard")]
        public long SkeletonFinalKillsStandard { get; set; }
    }
}