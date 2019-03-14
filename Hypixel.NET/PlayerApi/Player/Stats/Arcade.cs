using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Arcade
    {
        #region general

        [JsonProperty("coins")]
        public int Coins { get; set; }

        #endregion

        #region creeper attack

        [JsonProperty("max_wave")]
        public int MaxWave { get; set; }

        #endregion

        #region hypixel says/santa says

        [JsonProperty("rounds_santa_says")]
        public int RoundsSantaSays { get; set; }

        [JsonProperty("rounds_simon_says")]
        public int SimonSaysRounds { get; set; }

        [JsonProperty("wins_simon_says")]
        public int SimonSaysWins { get; set; }

        #endregion

        #region dragonwars

        [JsonProperty("kills_dragonwars2")]
        public int Dragonwars2Kills { get; set; }

        [JsonProperty("wins_dragonwars2")]
        public int Dragonwars2Wins { get; set; }

        #endregion

        #region hole in the wall

        [JsonProperty("hitw_record_q")]
        public int HoleInTheWallRecordQualifier { get; set; }

        [JsonProperty("hitw_record_f")]
        public int HoleInTheWallRecordFinalScore { get; set; }

        [JsonProperty("rounds_hole_in_the_wall")]
        public int RoundsHoleInTheWall { get; set; }

        [JsonProperty("wins_hole_in_the_wall")]
        public long WinsHoleInTheWall { get; set; }

        #endregion

        #region farmhunt

        [JsonProperty("poop_collected")]
        public int PoopCollected { get; set; }

        [JsonProperty("wins_farm_hunt")]
        public long WinsFarmHunt { get; set; }

        #endregion
        
        #region galaxy wars

        [JsonProperty("sw_kills")]
        public int GalaxyWarsKills { get; set; }

        [JsonProperty("sw_shots_fired")]
        public int GalaxyWarsShotsFired{ get; set; }

        [JsonProperty("sw_rebel_kills")]
        public int GalaxyWarsRebelKills { get; set; }

        [JsonProperty("sw_deaths")]
        public int GalaxyWarsDeaths { get; set; }

        [JsonProperty("sw_empire_kills")]
        public int GalaxyWarsEmpireKills { get; set; }


        #endregion

        #region partygames

        [JsonProperty("wins_party")]
        public int PartyGamesWins { get; set; }

        #endregion

        #region miniwalls

        [JsonProperty("miniwalls_activeKit")]
        public string MiniwallsActiveKit { get; set; }

        [JsonProperty("arrows_hit_mini_walls")]
        public int ArrowsHitMiniWalls { get; set; }

        [JsonProperty("final_kills_mini_walls")]
        public int FinalKillsMiniWalls { get; set; }

        [JsonProperty("kills_mini_walls")]
        public int KillsMiniWalls { get; set; }

        [JsonProperty("wins_mini_walls")]
        public int WinsMiniWalls { get; set; }

        [JsonProperty("wither_kills_mini_walls")]
        public int WitherKillsMiniWalls { get; set; }

        [JsonProperty("deaths_mini_walls")]
        public int DeathsMiniWalls { get; set; }

        [JsonProperty("arrows_shot_mini_walls")]
        public int ArrowsShotMiniWalls { get; set; }

        [JsonProperty("wither_damage_mini_walls")]
        public int WitherDamageMiniWalls { get; set; }

        #endregion

        #region soccer

        [JsonProperty("powerkicks_soccer")]
        public long SoccerPowerkicks { get; set; }

        [JsonProperty("goals_soccer")]
        public long SoccerGoals { get; set; }

        [JsonProperty("wins_soccer")]
        public long SoccerWins { get; set; }

        [JsonProperty("kicks_soccer")]
        public long KicksSoccer { get; set; }

        #endregion

        #region throwout

        [JsonProperty("kills_throw_out")]
        public long ThrowOutKills { get; set; }

        [JsonProperty("deaths_throw_out")]
        public long ThrowOutDeaths { get; set; }

        #endregion

        #region bounty hunters

        [JsonProperty("kills_oneinthequiver")]
        public long BountyHunterKills { get; set; }

        [JsonProperty("bounty_kills_oneinthequiver")]
        public long BountyHunterBountyKills { get; set; }

        [JsonProperty("deaths_oneinthequiver")]
        public long BountyHunterDeaths { get; set; }

        #endregion

        #region zombies

        #endregion

        #region hide and seek

        #endregion
    }
}