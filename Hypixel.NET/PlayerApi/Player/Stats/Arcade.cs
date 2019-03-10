using Newtonsoft.Json;

namespace Hypixel.NET.Player.Stats
{
    public class Arcade
    {
        [JsonProperty("max_wave")]
        public long MaxWave { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("rounds_santa_says")]
        public long RoundsSantaSays { get; set; }

        [JsonProperty("kills_dragonwars2")]
        public long KillsDragonwars2 { get; set; }

        [JsonProperty("hitw_record_q")]
        public long HitwRecordQ { get; set; }

        [JsonProperty("hitw_record_f")]
        public long HitwRecordF { get; set; }

        [JsonProperty("rounds_hole_in_the_wall")]
        public long RoundsHoleInTheWall { get; set; }

        [JsonProperty("poop_collected")]
        public long PoopCollected { get; set; }

        [JsonProperty("monthly_coins_b")]
        public long MonthlyCoinsB { get; set; }

        [JsonProperty("weekly_coins_b")]
        public long WeeklyCoinsB { get; set; }

        [JsonProperty("weekly_coins_a")]
        public long WeeklyCoinsA { get; set; }

        [JsonProperty("wins_party")]
        public long WinsParty { get; set; }

        [JsonProperty("monthly_coins_a")]
        public long MonthlyCoinsA { get; set; }

        [JsonProperty("miniwalls_activeKit")]
        public string MiniwallsActiveKit { get; set; }

        [JsonProperty("arrows_hit_mini_walls")]
        public long ArrowsHitMiniWalls { get; set; }

        [JsonProperty("final_kills_mini_walls")]
        public long FinalKillsMiniWalls { get; set; }

        [JsonProperty("kills_mini_walls")]
        public long KillsMiniWalls { get; set; }

        [JsonProperty("wins_mini_walls")]
        public long WinsMiniWalls { get; set; }

        [JsonProperty("wither_kills_mini_walls")]
        public long WitherKillsMiniWalls { get; set; }

        [JsonProperty("deaths_mini_walls")]
        public long DeathsMiniWalls { get; set; }

        [JsonProperty("arrows_shot_mini_walls")]
        public long ArrowsShotMiniWalls { get; set; }

        [JsonProperty("wither_damage_mini_walls")]
        public long WitherDamageMiniWalls { get; set; }

        [JsonProperty("wins_party_3")]
        public long WinsParty3 { get; set; }

        [JsonProperty("rounds_simon_says")]
        public long RoundsSimonSays { get; set; }

        [JsonProperty("powerkicks_soccer")]
        public long PowerkicksSoccer { get; set; }

        [JsonProperty("goals_soccer")]
        public long GoalsSoccer { get; set; }

        [JsonProperty("wins_soccer")]
        public long WinsSoccer { get; set; }

        [JsonProperty("kills_throw_out")]
        public long KillsThrowOut { get; set; }

        [JsonProperty("deaths_throw_out")]
        public long DeathsThrowOut { get; set; }

        [JsonProperty("kills_oneinthequiver")]
        public long KillsOneinthequiver { get; set; }

        [JsonProperty("bounty_kills_oneinthequiver")]
        public long BountyKillsOneinthequiver { get; set; }

        [JsonProperty("deaths_oneinthequiver")]
        public long DeathsOneinthequiver { get; set; }

        [JsonProperty("wins_farm_hunt")]
        public long WinsFarmHunt { get; set; }

        [JsonProperty("kicks_soccer")]
        public long KicksSoccer { get; set; }

        [JsonProperty("wins_hole_in_the_wall")]
        public long WinsHoleInTheWall { get; set; }
    }
}