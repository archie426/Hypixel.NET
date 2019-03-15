using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class TrueCombat
    {
        #region general stats
        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("survived_players")]
        public int SurvivedPlayers { get; set; }

        [JsonProperty("items_enchanted")]
        public int ItemsEnchanted { get; set; }

        [JsonProperty("arrows_shot")]
        public int ArrowsShot { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("skulls_gathered")]
        public int SkullsGathered { get; set; }

        [JsonProperty("golden_skulls")]
        public int GoldenSkulls { get; set; }

        [JsonProperty("giant_zombie")]
        public int GiantZombie { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("activeKit_Team")]
        public string ActiveKitTeam { get; set; }

        [JsonProperty("activeKit_Solo")]
        public string ActiveKitSolo { get; set; }

        [JsonProperty("giant_zombie_legendaries")]
        public int GiantZombieLegendaries { get; set; }

        [JsonProperty("giant_zombie_rares")]
        public int GiantZombieRares { get; set; }

        [JsonProperty("activeKit_Solo_chaos")]
        public string ActiveKitSoloChaos { get; set; }

        [JsonProperty("gold_dust")]
        public int GoldDust { get; set; }

        [JsonProperty("activeKit_Team_chaos")]
        public string ActiveKitTeamChaos { get; set; }

        [JsonProperty("arrows_hit")]
        public int ArrowsHit { get; set; }
        #endregion

        #region crazywalls chaos
        [JsonProperty("crazywalls_losses_solo_chaos")]
        public int CrazywallsLossesSoloChaos { get; set; }

        [JsonProperty("crazywalls_games_solo_chaos")]
        public int CrazywallsGamesSoloChaos { get; set; }

        [JsonProperty("crazywalls_deaths_solo_chaos")]
        public int CrazywallsDeathsSoloChaos { get; set; }

        [JsonProperty("crazywalls_kills_weekly_b_solo_chaos")]
        public int CrazywallsKillsWeeklyBSoloChaos { get; set; }

        [JsonProperty("crazywalls_kills_solo_chaos")]
        public int CrazywallsKillsSoloChaos { get; set; }

        [JsonProperty("crazywalls_games_team_chaos")]
        public int CrazywallsGamesTeamChaos { get; set; }

        [JsonProperty("crazywalls_losses_team_chaos")]
        public int CrazywallsLossesTeamChaos { get; set; }

        [JsonProperty("crazywalls_deaths_team_chaos")]
        public int CrazywallsDeathsTeamChaos { get; set; }

        [JsonProperty("crazywalls_kills_team_chaos")]
        public int CrazywallsKillsTeamChaos { get; set; }

        [JsonProperty("crazywalls_wins_solo_chaos")]
        public int CrazywallsWinsSoloChaos { get; set; }

        [JsonProperty("crazywalls_wins_team_chaos")]
        public int CrazywallsWinsTeamChaos { get; set; }
        #endregion

        #region crazywalls general
        [JsonProperty("crazywalls_losses_solo")]
        public int CrazywallsLossesSolo { get; set; }

        [JsonProperty("crazywalls_deaths_solo")]
        public int CrazywallsDeathsSolo { get; set; }

        [JsonProperty("crazywalls_games_solo")]
        public int CrazywallsGamesSolo { get; set; }

        [JsonProperty("crazywalls_deaths_team")]
        public int CrazywallsDeathsTeam { get; set; }

        [JsonProperty("crazywalls_losses_team")]
        public int CrazywallsLossesTeam { get; set; }

        [JsonProperty("crazywalls_games_team")]
        public int CrazywallsGamesTeam { get; set; }

        [JsonProperty("crazywalls_kills_solo")]
        public int CrazywallsKillsSolo { get; set; }

        [JsonProperty("crazywalls_kills_team")]
        public int CrazywallsKillsTeam { get; set; }

        [JsonProperty("crazywalls_wins_team")]
        public int CrazywallsWinsTeam { get; set; }

        #endregion

        #region upgrades		
        [JsonProperty("team_blazing_arrow")]
        public int TeamBlazingArrowLevel { get; set; }

        [JsonProperty("solo_chaos_tomb_robber")]
        public int SoloChaosTombRobberLevel { get; set; }

        [JsonProperty("solo_chaos_rusher")]
        public int SoloChaosRusherLevel { get; set; }

        [JsonProperty("team_bounty_hunter")]
        public int TeamBountyHunterLevel { get; set; }

        [JsonProperty("team_swiftness")]
        public int TeamSwiftnessLevel { get; set; }

        [JsonProperty("team_adrenaline")]
        public int TeamAdrenalineLevel { get; set; }

        [JsonProperty("solo_berserk")]
        public int SoloBerserkLevel { get; set; }

        [JsonProperty("team_vampirism")]
        public int TeamVampirismLevel { get; set; }

        [JsonProperty("solo_vampirism")]
        public int SoloVampirismLevel { get; set; }

        [JsonProperty("solo_chaos_berserk")]
        public int SoloChaosBerserkLevel { get; set; }

        [JsonProperty("solo_chaos_super_luck")]
        public int SoloChaosSuperLuckLevel { get; set; }

        [JsonProperty("solo_precision")]
        public int SoloPrecisionLevel { get; set; }

        [JsonProperty("team_precision")]
        public int TeamPrecisionLevel { get; set; }

        [JsonProperty("solo_chaos_blazing_arrow")]
        public int SoloChaosBlazingArrowLevel { get; set; }

        [JsonProperty("solo_chaos_adrenaline")]
        public int SoloChaosAdrenalineLevel { get; set; }

        [JsonProperty("solo_rusher")]
        public int SoloRusherLevel { get; set; }

        [JsonProperty("solo_swiftness")]
        public int SoloSwiftnessLevel { get; set; }

        [JsonProperty("solo_blazing_arrow")]
        public int SoloBlazingArrowLevel { get; set; }

        [JsonProperty("team_rusher")]
        public int TeamRusherLevel { get; set; }

        [JsonProperty("team_berserk")]
        public int TeamBerserkLevel { get; set; }

        [JsonProperty("team_smart_mining")]
        public int TeamSmartMiningLevel { get; set; }

        [JsonProperty("team_last_stand")]
        public int TeamLastStandLevel { get; set; }

        [JsonProperty("solo_adrenaline")]
        public int SoloAdrenalineLevel { get; set; }

        [JsonProperty("solo_speed_mining")]
        public int SoloSpeedMiningLevel { get; set; }

        [JsonProperty("solo_bounty_hunter")]
        public int SoloBountyHunterLevel { get; set; }

        [JsonProperty("solo_lucky_drops")]
        public int SoloLuckyDropsLevel { get; set; }

        [JsonProperty("solo_chaos_vampirism")]
        public int SoloChaosVampirismLevel { get; set; }

        [JsonProperty("team_tomb_robber")]
        public int TeamTombRobberLevel { get; set; }

        [JsonProperty("crafting_lucky_gold_ingots")]
        public int CraftingLuckyGoldIngotsLevel { get; set; }

        [JsonProperty("crafting_lucky_enchanted_book_sharpness")]
        public int CraftingLuckyEnchantedBookSharpnessLevel { get; set; }

        [JsonProperty("crafting_lucky_rejuvenate")]
        public int CraftingLuckyRejuvenateLevel { get; set; }

        [JsonProperty("crafting_lucky_brawler")]
        public int CraftingLuckyBrawlerLevel { get; set; }

        [JsonProperty("crafting_lucky_ender_pearls")]
        public int CraftingLuckyEnderPearlsLevel { get; set; }

        [JsonProperty("solo_smart_mining")]
        public int SoloSmartMiningLevel { get; set; }

        [JsonProperty("team_knowledge")]
        public int TeamKnowledgeLevel { get; set; }

        [JsonProperty("solo_chaos_knowledge")]
        public int SoloChaosKnowledgeLevel { get; set; }

        [JsonProperty("crafting_lucky_cobwebs")]
        public int CraftingLuckyCobwebsLevel { get; set; }

        [JsonProperty("solo_chaos_businessman")]
        public int SoloChaosBusinessmanLevel { get; set; }

        [JsonProperty("solo_chaos_bounty_hunter")]
        public int SoloChaosBountyHunterLevel { get; set; }

        [JsonProperty("solo_chaos_annoy-o-mite")]
        public int SoloChaosAnnoyOMiteLevel { get; set; }

        [JsonProperty("solo_knowledge")]
        public int SoloKnowledgeLevel { get; set; }

        [JsonProperty("crafting_lucky_enchanted_book_power")]
        public int CraftingLuckyEnchantedBookPowerLevel { get; set; }

        [JsonProperty("crafting_lucky_eagle_eye")]
        public int CraftingLuckyEagleEyeLevel { get; set; }

        [JsonProperty("crafting_lucky_lava_bucket")]
        public int CraftingLuckyLavaBucketLevel { get; set; }

        [JsonProperty("crafting_normal_enchanted_book_protection")]
        public int CraftingNormalEnchantedBookProtectionLevel { get; set; }

        [JsonProperty("crafting_normal_enchanted_book_sharpness")]
        public int CraftingNormalEnchantedBookSharpnessLevel { get; set; }

        [JsonProperty("crafting_normal_enchanted_book_power")]
        public int CraftingNormalEnchantedBookPowerLevel { get; set; }

        [JsonProperty("crafting_normal_gold_ingots")]
        public int CraftingNormalGoldIngotsLevel { get; set; }

        [JsonProperty("solo_tomb_robber")]
        public int SoloTombRobberLevel { get; set; }

        [JsonProperty("crazywalls_wins_solo")]
        public int CrazywallsWinsSolo { get; set; }

        [JsonProperty("crafting_normal_heal_potion")]
        public int CraftingNormalHealPotionLevel { get; set; }

        [JsonProperty("team_annoy-o-mite")]
        public int TeamAnnoyOMiteLevel { get; set; }

        [JsonProperty("crafting_normal_random_item")]
        public int CraftingNormalRandomItemLevel { get; set; }

        [JsonProperty("crafting_normal_cobwebs")]
        public int CraftingNormalCobwebsLevel { get; set; }

        [JsonProperty("crafting_normal_lava_bucket")]
        public int CraftingNormalLavaBucketLevel { get; set; }

        [JsonProperty("crafting_normal_enchanted_book_punch")]
        public int CraftingNormalEnchantedBookPunchLevel { get; set; }

        [JsonProperty("solo_annoy-o-mite")]
        public int SoloAnnoyOMiteLevel { get; set; }

        [JsonProperty("team_speed_mining")]
        public int TeamSpeedMiningLevel { get; set; }

        [JsonProperty("team_group_heal")]
        public int TeamGroupHealLevel { get; set; }

        [JsonProperty("team_smarty_pants")]
        public int TeamSmartyPantsLevel { get; set; }

        [JsonProperty("crafting_lucky_enchanted_book_punch")]
        public int CraftingLuckyEnchantedBookPunchLevel { get; set; }

        [JsonProperty("solo_chaos_speed_mining")]
        public int SoloChaosSpeedMiningLevel { get; set; }

        [JsonProperty("solo_chaos_smarty_pants")]
        public int SoloChaosSmartyPantsLevel { get; set; }

        [JsonProperty("solo_smarty_pants")]
        public int SoloSmartyPantsLevel { get; set; }

        [JsonProperty("solo_chaos_treasure_hunter")]
        public int SoloChaosTreasureHunterLevel { get; set; }

        [JsonProperty("solo_scavenger")]
        public int SoloScavengerLevel { get; set; }

        [JsonProperty("team_scavenger")]
        public int TeamScavengerLevel { get; set; }
        #endregion

        #region kits
        [JsonProperty("kit_basic_chaos_looter")]
        public int KitBasicChaosLooter { get; set; }

        [JsonProperty("kit_basic_chaos_gladiator")]
        public int KitBasicChaosGladiator { get; set; }

        [JsonProperty("kit_basic_chaos_armorer")]
        public int KitBasicChaosArmorer { get; set; }

        [JsonProperty("kit_basic_chaos_weaponsmith")]
        public int KitBasicChaosWeaponsmith { get; set; }
        #endregion
    }
}