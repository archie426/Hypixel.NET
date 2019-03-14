using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Arcade
    {
        #region general
        [JsonProperty("coins")]
        public double Coins { get; set; }
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
        public int ThrowOutKills { get; set; }

        [JsonProperty("deaths_throw_out")]
        public int ThrowOutDeaths { get; set; }
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
        [JsonProperty("headshots_dayone")]
        public long HeadshotsDayone { get; set; }

        [JsonProperty("kills_dayone")]
        public long KillsDayone { get; set; }

        [JsonProperty("wins_dayone")]
        public long WinsDayone { get; set; }

        [JsonProperty("fastest_time_10_zombies_deadend_normal")]
        public long FastestTime10_ZombiesDeadendNormal { get; set; }

        [JsonProperty("best_round_zombies")]
        public long BestRoundZombies { get; set; }

        [JsonProperty("fastest_time_10_zombies")]
        public long FastestTime10_Zombies { get; set; }

        [JsonProperty("players_revived_zombies")]
        public long PlayersRevivedZombies { get; set; }

        [JsonProperty("headshots_zombies")]
        public long HeadshotsZombies { get; set; }

        [JsonProperty("deaths_zombies")]
        public long DeathsZombies { get; set; }

        [JsonProperty("bullets_shot_zombies")]
        public long BulletsShotZombies { get; set; }

        [JsonProperty("times_knocked_down_zombies")]
        public long TimesKnockedDownZombies { get; set; }

        [JsonProperty("doors_opened_zombies")]
        public long DoorsOpenedZombies { get; set; }

        [JsonProperty("zombie_kills_zombies")]
        public long ZombieKillsZombies { get; set; }

        [JsonProperty("bullets_hit_zombies")]
        public long BulletsHitZombies { get; set; }

        [JsonProperty("best_round_zombies_deadend")]
        public long BestRoundZombiesDeadend { get; set; }

        [JsonProperty("best_round_zombies_deadend_rip")]
        public long BestRoundZombiesDeadendRip { get; set; }

        [JsonProperty("deaths_zombies_deadend_rip")]
        public long DeathsZombiesDeadendRip { get; set; }

        [JsonProperty("zombie_kills_zombies_deadend")]
        public long ZombieKillsZombiesDeadend { get; set; }

        [JsonProperty("total_rounds_survived_zombies_deadend")]
        public long TotalRoundsSurvivedZombiesDeadend { get; set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_rip")]
        public long TotalRoundsSurvivedZombiesDeadendRip { get; set; }

        [JsonProperty("windows_repaired_zombies_deadend_rip")]
        public long WindowsRepairedZombiesDeadendRip { get; set; }

        [JsonProperty("total_rounds_survived_zombies")]
        public long TotalRoundsSurvivedZombies { get; set; }

        [JsonProperty("windows_repaired_zombies")]
        public long WindowsRepairedZombies { get; set; }

        [JsonProperty("deaths_zombies_deadend")]
        public long DeathsZombiesDeadend { get; set; }

        [JsonProperty("times_knocked_down_zombies_deadend_rip")]
        public long TimesKnockedDownZombiesDeadendRip { get; set; }

        [JsonProperty("zombie_kills_zombies_deadend_rip")]
        public long ZombieKillsZombiesDeadendRip { get; set; }

        [JsonProperty("basic_zombie_kills_zombies")]
        public long BasicZombieKillsZombies { get; set; }

        [JsonProperty("times_knocked_down_zombies_deadend")]
        public long TimesKnockedDownZombiesDeadend { get; set; }

        [JsonProperty("windows_repaired_zombies_deadend")]
        public long WindowsRepairedZombiesDeadend { get; set; }

        [JsonProperty("best_round_zombies_deadend_normal")]
        public long BestRoundZombiesDeadendNormal { get; set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_normal")]
        public long TotalRoundsSurvivedZombiesDeadendNormal { get; set; }

        [JsonProperty("magma_cube_zombie_kills_zombies")]
        public long MagmaCubeZombieKillsZombies { get; set; }

        [JsonProperty("players_revived_zombies_deadend_normal")]
        public long PlayersRevivedZombiesDeadendNormal { get; set; }

        [JsonProperty("zombie_kills_zombies_deadend_normal")]
        public long ZombieKillsZombiesDeadendNormal { get; set; }

        [JsonProperty("times_knocked_down_zombies_deadend_normal")]
        public long TimesKnockedDownZombiesDeadendNormal { get; set; }

        [JsonProperty("deaths_zombies_deadend_normal")]
        public long DeathsZombiesDeadendNormal { get; set; }

        [JsonProperty("blaze_zombie_kills_zombies")]
        public long BlazeZombieKillsZombies { get; set; }

        [JsonProperty("tnt_baby_zombie_kills_zombies")]
        public long TntBabyZombieKillsZombies { get; set; }

        [JsonProperty("doors_opened_zombies_deadend_normal")]
        public long DoorsOpenedZombiesDeadendNormal { get; set; }

        [JsonProperty("magma_zombie_kills_zombies")]
        public long MagmaZombieKillsZombies { get; set; }

        [JsonProperty("fire_zombie_kills_zombies")]
        public long FireZombieKillsZombies { get; set; }

        [JsonProperty("wolf_zombie_kills_zombies")]
        public long WolfZombieKillsZombies { get; set; }

        [JsonProperty("pig_zombie_zombie_kills_zombies")]
        public long PigZombieZombieKillsZombies { get; set; }

        [JsonProperty("windows_repaired_zombies_deadend_normal")]
        public long WindowsRepairedZombiesDeadendNormal { get; set; }

        [JsonProperty("empowered_zombie_kills_zombies")]
        public long EmpoweredZombieKillsZombies { get; set; }

        [JsonProperty("doors_opened_zombies_deadend")]
        public long DoorsOpenedZombiesDeadend { get; set; }

        [JsonProperty("players_revived_zombies_deadend")]
        public long PlayersRevivedZombiesDeadend { get; set; }

        [JsonProperty("zombies_hideTutorials")]
        public bool ZombiesHideTutorials { get; set; }

        [JsonProperty("fastest_time_20_zombies")]
        public long FastestTime20_Zombies { get; set; }

        [JsonProperty("fastest_time_20_zombies_deadend_normal")]
        public long FastestTime20_ZombiesDeadendNormal { get; set; }

        [JsonProperty("skelefish_zombie_kills_zombies")]
        public long SkelefishZombieKillsZombies { get; set; }

        [JsonProperty("guardian_zombie_kills_zombies")]
        public long GuardianZombieKillsZombies { get; set; }

        [JsonProperty("tnt_zombie_kills_zombies")]
        public long TntZombieKillsZombies { get; set; }

        [JsonProperty("silverfish_zombie_kills_zombies")]
        public long SilverfishZombieKillsZombies { get; set; }

        [JsonProperty("endermite_zombie_kills_zombies")]
        public long EndermiteZombieKillsZombies { get; set; }

        [JsonProperty("inferno_zombie_kills_zombies")]
        public long InfernoZombieKillsZombies { get; set; }

        [JsonProperty("ender_zombie_kills_zombies")]
        public long EnderZombieKillsZombies { get; set; }

        [JsonProperty("fastest_time_30_zombies")]
        public long FastestTime30_Zombies { get; set; }

        [JsonProperty("fastest_time_30_zombies_deadend_normal")]
        public long FastestTime30_ZombiesDeadendNormal { get; set; }

        [JsonProperty("wins_zombies")]
        public long WinsZombies { get; set; }

        [JsonProperty("wins_zombies_deadend")]
        public long WinsZombiesDeadend { get; set; }

        [JsonProperty("wins_zombies_deadend_normal")]
        public long WinsZombiesDeadendNormal { get; set; }

        [JsonProperty("windows_repaired_zombies_alienarcadium")]
        public long WindowsRepairedZombiesAlienarcadium { get; set; }

        [JsonProperty("total_rounds_survived_zombies_alienarcadium")]
        public long TotalRoundsSurvivedZombiesAlienarcadium { get; set; }

        [JsonProperty("zombie_kills_zombies_alienarcadium")]
        public long ZombieKillsZombiesAlienarcadium { get; set; }

        [JsonProperty("skeleton_zombie_kills_zombies")]
        public long SkeletonZombieKillsZombies { get; set; }

        [JsonProperty("deaths_zombies_alienarcadium")]
        public long DeathsZombiesAlienarcadium { get; set; }

        [JsonProperty("rainbow_zombie_kills_zombies")]
        public long RainbowZombieKillsZombies { get; set; }

        [JsonProperty("giant_zombie_kills_zombies")]
        public long GiantZombieKillsZombies { get; set; }

        [JsonProperty("space_blaster_zombie_kills_zombies")]
        public long SpaceBlasterZombieKillsZombies { get; set; }

        [JsonProperty("chgluglu_zombie_kills_zombies")]
        public long ChglugluZombieKillsZombies { get; set; }

        [JsonProperty("times_knocked_down_zombies_alienarcadium")]
        public long TimesKnockedDownZombiesAlienarcadium { get; set; }

        [JsonProperty("ghast_zombie_kills_zombies")]
        public long GhastZombieKillsZombies { get; set; }

        [JsonProperty("worm_small_zombie_kills_zombies")]
        public long WormSmallZombieKillsZombies { get; set; }

        [JsonProperty("worm_zombie_kills_zombies")]
        public long WormZombieKillsZombies { get; set; }

        [JsonProperty("sentinel_zombie_kills_zombies")]
        public long SentinelZombieKillsZombies { get; set; }

        [JsonProperty("space_grunt_zombie_kills_zombies")]
        public long SpaceGruntZombieKillsZombies { get; set; }

        [JsonProperty("blob_zombie_kills_zombies")]
        public long BlobZombieKillsZombies { get; set; }

        [JsonProperty("clown_zombie_kills_zombies")]
        public long ClownZombieKillsZombies { get; set; }

        [JsonProperty("prop_hunt_hider_wins_hide_and_seek")]
        public long PropHuntHiderWinsHideAndSeek { get; set; }

        [JsonProperty("best_round_zombies_alienarcadium")]
        public long BestRoundZombiesAlienarcadium { get; set; }

        [JsonProperty("best_round_zombies_alienarcadium_normal")]
        public long BestRoundZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("fastest_time_10_zombies_alienarcadium_normal")]
        public long FastestTime10_ZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("doors_opened_zombies_alienarcadium")]
        public long DoorsOpenedZombiesAlienarcadium { get; set; }

        [JsonProperty("zombie_kills_zombies_alienarcadium_normal")]
        public long ZombieKillsZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("windows_repaired_zombies_alienarcadium_normal")]
        public long WindowsRepairedZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("total_rounds_survived_zombies_alienarcadium_normal")]
        public long TotalRoundsSurvivedZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("times_knocked_down_zombies_alienarcadium_normal")]
        public long TimesKnockedDownZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("doors_opened_zombies_alienarcadium_normal")]
        public long DoorsOpenedZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("players_revived_zombies_alienarcadium")]
        public long PlayersRevivedZombiesAlienarcadium { get; set; }

        [JsonProperty("deaths_zombies_alienarcadium_normal")]
        public long DeathsZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("players_revived_zombies_alienarcadium_normal")]
        public long PlayersRevivedZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("fastest_time_20_zombies_alienarcadium_normal")]
        public long FastestTime20_ZombiesAlienarcadiumNormal { get; set; }

        [JsonProperty("iron_golem_zombie_kills_zombies")]
        public long IronGolemZombieKillsZombies { get; set; }

        [JsonProperty("mega_magma_zombie_kills_zombies")]
        public long MegaMagmaZombieKillsZombies { get; set; }

        [JsonProperty("mega_blob_zombie_kills_zombies")]
        public long MegaBlobZombieKillsZombies { get; set; }

        [JsonProperty("the_old_one_zombie_kills_zombies")]
        public long TheOldOneZombieKillsZombies { get; set; }

        [JsonProperty("giant_rainbow_zombie_kills_zombies")]
        public long GiantRainbowZombieKillsZombies { get; set; }

        [JsonProperty("charged_creeper_zombie_kills_zombies")]
        public long ChargedCreeperZombieKillsZombies { get; set; }

        [JsonProperty("broodmother_zombie_kills_zombies")]
        public long BroodmotherZombieKillsZombies { get; set; }

        [JsonProperty("fastest_time_20_zombies_deadend_hard")]
        public long FastestTime20_ZombiesDeadendHard { get; set; }

        [JsonProperty("best_round_zombies_deadend_hard")]
        public long BestRoundZombiesDeadendHard { get; set; }

        [JsonProperty("fastest_time_10_zombies_deadend_hard")]
        public long FastestTime10_ZombiesDeadendHard { get; set; }

        [JsonProperty("windows_repaired_zombies_deadend_hard")]
        public long WindowsRepairedZombiesDeadendHard { get; set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_hard")]
        public long TotalRoundsSurvivedZombiesDeadendHard { get; set; }

        [JsonProperty("players_revived_zombies_deadend_hard")]
        public long PlayersRevivedZombiesDeadendHard { get; set; }

        [JsonProperty("deaths_zombies_deadend_hard")]
        public long DeathsZombiesDeadendHard { get; set; }

        [JsonProperty("zombie_kills_zombies_deadend_hard")]
        public long ZombieKillsZombiesDeadendHard { get; set; }

        [JsonProperty("times_knocked_down_zombies_deadend_hard")]
        public long TimesKnockedDownZombiesDeadendHard { get; set; }

        [JsonProperty("doors_opened_zombies_deadend_hard")]
        public long DoorsOpenedZombiesDeadendHard { get; set; }

        [JsonProperty("fastest_time_30_zombies_deadend_hard")]
        public long FastestTime30_ZombiesDeadendHard { get; set; }

        [JsonProperty("wins_zombies_deadend_hard")]
        public long WinsZombiesDeadendHard { get; set; }

        [JsonProperty("players_revived_zombies_deadend_rip")]
        public long PlayersRevivedZombiesDeadendRip { get; set; }

        [JsonProperty("doors_opened_zombies_deadend_rip")]
        public long DoorsOpenedZombiesDeadendRip { get; set; }
        #endregion

        #region hide and seek
        [JsonProperty("party_pooper_hider_wins_hide_and_seek")]
        public int HideAndSeekHiderWins { get; set; }

        [JsonProperty("party_pooper_seeker_wins_hide_and_seek")]
        public int HideAndSeekSeekerWins { get; set; }
        #endregion
    }
}