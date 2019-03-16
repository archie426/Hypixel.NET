using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Bedwars
    {
        #region general
        [JsonProperty("Experience")]
        public int Experience { get; set; }

        [JsonProperty("spray_glyph_field")]
        public string SprayGlyphField { get; set; }

        [JsonProperty("activeDeathCry")]
        public string ActiveDeathCry { get; set; }

        [JsonProperty("activeKillEffect")]
        public string ActiveKillEffect { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("activeVictoryDance")]
        public string ActiveVictoryDance { get; set; }

        [JsonProperty("spray_storage_new")]
        public string SprayStorage { get; set; }

        [JsonProperty("winstreak")]
        public int Winstreak { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("activeNPCSkin")]
        public string ActiveNpcSkin { get; set; }

        [JsonProperty("activeIslandTopper")]
        public string ActiveIslandTopper { get; set; }

        [JsonProperty("activeProjectileTrail")]
        public string ActiveProjectileTrail { get; set; }

        [JsonProperty("glyph_storage_new")]
        public string GlyphStorage { get; set; }

        [JsonProperty("activeSprays")]
        public string ActiveSprays { get; set; }

        [JsonProperty("activeBedDestroy")]
        public string ActiveBedDestroySound { get; set; }

        [JsonProperty("activeGlyph")]
        public string ActiveGlyph { get; set; }
        #endregion

        #region loot boxes
        [JsonProperty("bedwars_boxes")]
        public int BedwarsBoxes { get; set; }

        [JsonProperty("bedwars_box")]
        public int BedwarsBox { get; set; }

        [JsonProperty("chest_history")]
        public string ChestHistory { get; set; }

        [JsonProperty("bedwars_box_commons")]
        public int BedwarsBoxCommons { get; set; }

        [JsonProperty("bedwars_box_rares")]
        public int BedwarsBoxRares { get; set; }

        [JsonProperty("chest_history_new")]
        public List<string> ChestHistoryNew { get; set; }

        [JsonProperty("bedwars_box_legendaries")]
        public int BedwarsBoxLegendaries { get; set; }

        [JsonProperty("bedwars_box_epics")]
        public int BedwarsBoxEpics { get; set; }

        [JsonProperty("Bedwars_openedChests")]
        public int BedwarsOpenedChests { get; set; }

        [JsonProperty("Bedwars_openedCommons")]
        public int BedwarsOpenedCommons { get; set; }

        [JsonProperty("Bedwars_openedRares")]
        public int BedwarsOpenedRares { get; set; }

        [JsonProperty("Bedwars_openedEpics")]
        public int BedwarsOpenedEpics { get; set; }

        [JsonProperty("Bedwars_openedLegendaries")]
        public int BedwarsOpenedLegendaries { get; set; }

        [JsonProperty("bedwars_lunar_boxes")]
        public int BedwarsLunarBoxes { get; set; }

        [JsonProperty("bedwars_easter_boxes")]
        public int BedwarsEasterBoxes { get; set; }

        #endregion

        #region overall stats
        [JsonProperty("final_deaths_bedwars")]
        public int FinalDeathsBedwars { get; set; }

        [JsonProperty("gold_resources_collected_bedwars")]
        public int GoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("emerald_resources_collected_bedwars")]
        public int EmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("resources_collected_bedwars")]
        public int ResourcesCollectedBedwars { get; set; }

        [JsonProperty("games_played_bedwars")]
        public int GamesPlayedBedwars { get; set; }

        [JsonProperty("entity_attack_final_kills_bedwars")]
        public int EntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("beds_lost_bedwars")]
        public int BedsLostBedwars { get; set; }

        [JsonProperty("kills_bedwars")]
        public int KillsBedwars { get; set; }

        [JsonProperty("entity_attack_kills_bedwars")]
        public int EntityAttackKillsBedwars { get; set; }

        [JsonProperty("fall_final_deaths_bedwars")]
        public int FallFinalDeathsBedwars { get; set; }

        [JsonProperty("losses_bedwars")]
        public int LossesBedwars { get; set; }

        [JsonProperty("items_purchased_bedwars")]
        public int BedwarsItemsPurchasedBedwars { get; set; }

        [JsonProperty("final_kills_bedwars")]
        public int FinalKillsBedwars { get; set; }

        [JsonProperty("iron_resources_collected_bedwars")]
        public int IronResourcesCollectedBedwars { get; set; }

        [JsonProperty("beds_broken_bedwars")]
        public int BedsBrokenBedwars { get; set; }

        [JsonProperty("_items_purchased_bedwars")]
        public int ItemsPurchasedBedwars { get; set; }

        [JsonProperty("void_kills_bedwars")]
        public int VoidKillsBedwars { get; set; }

        [JsonProperty("deaths_bedwars")]
        public int DeathsBedwars { get; set; }

        [JsonProperty("fall_deaths_bedwars")]
        public int FallDeathsBedwars { get; set; }

        [JsonProperty("permanent _items_purchased_bedwars")]
        public int PermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("wins_bedwars")]
        public int WinsBedwars { get; set; }

        [JsonProperty("void_final_kills_bedwars")]
        public int VoidFinalKillsBedwars { get; set; }

        [JsonProperty("entity_attack_deaths_bedwars")]
        public int EntityAttackDeathsBedwars { get; set; }

        [JsonProperty("diamond_resources_collected_bedwars")]
        public int DiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("entity_attack_final_deaths_bedwars")]
        public int EntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("void_deaths_bedwars")]
        public int VoidDeathsBedwars { get; set; }

        [JsonProperty("entity_explosion_final_kills_bedwars")]
        public int EntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_kills_bedwars")]
        public int EntityExplosionKillsBedwars { get; set; }

        [JsonProperty("void_final_deaths_bedwars")]
        public int VoidFinalDeathsBedwars { get; set; }

        [JsonProperty("fall_kills_bedwars")]
        public int FallKillsBedwars { get; set; }

        [JsonProperty("fall_final_kills_bedwars")]
        public int FallFinalKillsBedwars { get; set; }

        [JsonProperty("projectile_deaths_bedwars")]
        public int ProjectileDeathsBedwars { get; set; }

        [JsonProperty("projectile_kills_bedwars")]
        public int ProjectileKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_deaths_bedwars")]
        public int EntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("projectile_final_kills_bedwars")]
        public int ProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_final_deaths_bedwars")]
        public int EntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("projectile_final_deaths_bedwars")]
        public int ProjectileFinalDeathsBedwars { get; set; }

        [JsonProperty("fire_tick_deaths_bedwars")]
        public int FireTickDeathsBedwars { get; set; }

        [JsonProperty("wrapped_present_resources_collected_bedwars")]
        public int WrappedPresentResourcesCollectedBedwars { get; set; }

        [JsonProperty("fire_tick_kills_bedwars")]
        public int FireTickKillsBedwars { get; set; }

        [JsonProperty("fire_kills_bedwars")]
        public int FireKillsBedwars { get; set; }

        [JsonProperty("fire_tick_final_kills_bedwars")]
        public int FireTickFinalKillsBedwars { get; set; }
        #endregion

        #region solos
        [JsonProperty("eight_one_beds_lost_bedwars")]
        public int SolosBedsLostBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_final_kills_bedwars")]
        public int SolosEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_deaths_bedwars")]
        public int SolosDeathsBedwars { get; set; }

        [JsonProperty("eight_one_void_deaths_bedwars")]
        public int SolosVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_one_games_played_bedwars")]
        public int SolosGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_one_final_kills_bedwars")]
        public int SolosFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_beds_broken_bedwars")]
        public int SolosBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_one_iron_resources_collected_bedwars")]
        public int SolosIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_emerald_resources_collected_bedwars")]
        public int SolosEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_items_purchased_bedwars")]
        public int SolosItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_diamond_resources_collected_bedwars")]
        public int SolosDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_permanent _items_purchased_bedwars")]
        public int SolosPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_kills_bedwars")]
        public int SolosEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_one_void_final_kills_bedwars")]
        public int SolosVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_wins_bedwars")]
        public int SolosWinsBedwars { get; set; }

        [JsonProperty("eight_one_kills_bedwars")]
        public int SolosKillsBedwars { get; set; }

        [JsonProperty("eight_one_resources_collected_bedwars")]
        public int SolosResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_gold_resources_collected_bedwars")]
        public int SolosGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_final_deaths_bedwars")]
        public int SolosFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_final_deaths_bedwars")]
        public int SolosEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_losses_bedwars")]
        public int SolosLossesBedwars { get; set; }

        [JsonProperty("eight_one_fall_kills_bedwars")]
        public int SolosFallKillsBedwars { get; set; }

        [JsonProperty("eight_one_projectile_kills_bedwars")]
        public int SolosProjectileKillsBedwars { get; set; }

        [JsonProperty("eight_one_void_kills_bedwars")]
        public int SolosVoidKillsBedwars { get; set; }

        [JsonProperty("eight_one_void_final_deaths_bedwars")]
        public int SolosVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_deaths_bedwars")]
        public int SolosEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_one_fall_final_kills_bedwars")]
        public int SolosFallFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_fall_deaths_bedwars")]
        public int SolosFallDeathsBedwars { get; set; }

        [JsonProperty("eight_one_projectile_final_kills_bedwars")]
        public int SolosProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_entity_explosion_kills_bedwars")]
        public int SolosEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("eight_one_projectile_deaths_bedwars")]
        public int SolosProjectileDeathsBedwars { get; set; }

        [JsonProperty("eight_one_winstreak")]
        public int SolosWinstreak { get; set; }
        #endregion

        #region duos
        [JsonProperty("eight_two_void_deaths_bedwars")]
        public int DuosVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_two_beds_broken_bedwars")]
        public int DuosBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_two_emerald_resources_collected_bedwars")]
        public int DuosEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_permanent _items_purchased_bedwars")]
        public int DuosPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_resources_collected_bedwars")]
        public int DuosResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_diamond_resources_collected_bedwars")]
        public int DuosDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_fall_deaths_bedwars")]
        public int DuosFallDeathsBedwars { get; set; }

        [JsonProperty("eight_two_kills_bedwars")]
        public int DuosKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_final_kills_bedwars")]
        public int DuosEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_kills_bedwars")]
        public int DuosEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_two_iron_resources_collected_bedwars")]
        public int DuosIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_final_deaths_bedwars")]
        public int DuosFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_void_final_deaths_bedwars")]
        public int DuosVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_deaths_bedwars")]
        public int DuosDeathsBedwars { get; set; }

        [JsonProperty("eight_two_games_played_bedwars")]
        public int DuosGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_items_purchased_bedwars")]
        public int DuosItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_beds_lost_bedwars")]
        public int DuosBedsLostBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_deaths_bedwars")]
        public int DuosEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_two_void_final_kills_bedwars")]
        public int DuosVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_gold_resources_collected_bedwars")]
        public int DuosGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_final_kills_bedwars")]
        public int DuosFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_losses_bedwars")]
        public int DuosLossesBedwars { get; set; }

        [JsonProperty("eight_two_fall_final_kills_bedwars")]
        public int DuosFallFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_wins_bedwars")]
        public int DuosWinsBedwars { get; set; }

        [JsonProperty("eight_two_fall_kills_bedwars")]
        public int DuosFallKillsBedwars { get; set; }

        [JsonProperty("eight_two_void_kills_bedwars")]
        public int DuosVoidKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_final_deaths_bedwars")]
        public int DuosEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_fall_final_deaths_bedwars")]
        public int DuosFallFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_final_kills_bedwars")]
        public int DuosProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_explosion_final_kills_bedwars")]
        public int DuosEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_kills_bedwars")]
        public int DuosProjectileKillsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_deaths_bedwars")]
        public int DuosProjectileDeathsBedwars { get; set; }

        [JsonProperty("eight_two_winstreak")]
        public int DuosWinstreak { get; set; }

        [JsonProperty("eight_two_fire_kills_bedwars")]
        public int DuosFireKillsBedwars { get; set; }
        #endregion

        #region trios
        [JsonProperty("four_three_iron_resources_collected_bedwars")]
        public int TriosIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_final_deaths_bedwars")]
        public int TriosEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_games_played_bedwars")]
        public int TriosGamesPlayedBedwars { get; set; }

        [JsonProperty("four_three_fall_deaths_bedwars")]
        public int TriosFallDeathsBedwars { get; set; }

        [JsonProperty("four_three_emerald_resources_collected_bedwars")]
        public int TriosEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_beds_lost_bedwars")]
        public int TriosBedsLostBedwars { get; set; }

        [JsonProperty("four_three_gold_resources_collected_bedwars")]
        public int TriosGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_deaths_bedwars")]
        public int TriosDeathsBedwars { get; set; }

        [JsonProperty("four_three_beds_broken_bedwars")]
        public int TriosBedsBrokenBedwars { get; set; }

        [JsonProperty("four_three_losses_bedwars")]
        public int TriosLossesBedwars { get; set; }

        [JsonProperty("four_three_items_purchased_bedwars")]
        public int TriosItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_final_deaths_bedwars")]
        public int TriosFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_resources_collected_bedwars")]
        public int TriosResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_void_final_kills_bedwars")]
        public int TriosVoidFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_wins_bedwars")]
        public int TriosWinsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_final_kills_bedwars")]
        public int TriosEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_void_deaths_bedwars")]
        public int TriosVoidDeathsBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_deaths_bedwars")]
        public int TriosEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_three_permanent _items_purchased_bedwars")]
        public int TriosPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_final_kills_bedwars")]
        public int TriosEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_final_kills_bedwars")]
        public int TriosFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_diamond_resources_collected_bedwars")]
        public int TriosDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_void_kills_bedwars")]
        public int TriosVoidKillsBedwars { get; set; }

        [JsonProperty("four_three_fall_final_kills_bedwars")]
        public int TriosFallFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_kills_bedwars")]
        public int TriosKillsBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_kills_bedwars")]
        public int TriosEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_kills_bedwars")]
        public int TriosEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_three_void_final_deaths_bedwars")]
        public int TriosVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_deaths_bedwars")]
        public int TriosEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("four_three_projectile_kills_bedwars")]
        public int TriosProjectileKillsBedwars { get; set; }

        [JsonProperty("four_three_fall_kills_bedwars")]
        public int TriosFallKillsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_final_deaths_bedwars")]
        public int TriosEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_fall_final_deaths_bedwars")]
        public int TriosFallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_projectile_final_kills_bedwars")]
        public int TriosProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_wrapped_present_resources_collected_bedwars")]
        public int TriosWrappedPresentResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_fire_tick_deaths_bedwars")]
        public int TriosFireTickDeathsBedwars { get; set; }

        [JsonProperty("four_three_winstreak")]
        public int TriosWinstreak { get; set; }

        #endregion

        #region fours
        [JsonProperty("four_four_beds_broken_bedwars")]
        public int FoursBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_kills_bedwars")]
        public int FoursKillsBedwars { get; set; }

        [JsonProperty("four_four_final_deaths_bedwars")]
        public int FoursFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_gold_resources_collected_bedwars")]
        public int FoursGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_beds_lost_bedwars")]
        public int FoursBedsLostBedwars { get; set; }

        [JsonProperty("four_four_losses_bedwars")]
        public int FoursLossesBedwars { get; set; }

        [JsonProperty("four_four_iron_resources_collected_bedwars")]
        public int FoursIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_fall_final_deaths_bedwars")]
        public int FoursFallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_resources_collected_bedwars")]
        public int FoursResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_items_purchased_bedwars")]
        public int FoursItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_kills_bedwars")]
        public int FoursEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_final_kills_bedwars")]
        public int FoursFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_emerald_resources_collected_bedwars")]
        public int FoursEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_permanent _items_purchased_bedwars")]
        public int FoursPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_void_kills_bedwars")]
        public int FoursVoidKillsBedwars { get; set; }

        [JsonProperty("four_four_fall_deaths_bedwars")]
        public int FoursFallDeathsBedwars { get; set; }

        [JsonProperty("four_four_deaths_bedwars")]
        public int FoursDeathsBedwars { get; set; }

        [JsonProperty("four_four_wins_bedwars")]
        public int FoursWinsBedwars { get; set; }

        [JsonProperty("four_four_void_final_kills_bedwars")]
        public int FoursVoidFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_deaths_bedwars")]
        public int FoursEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_four_diamond_resources_collected_bedwars")]
        public int FoursDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_kills_bedwars")]
        public int FoursEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_four_void_deaths_bedwars")]
        public int FoursVoidDeathsBedwars { get; set; }

        [JsonProperty("four_four_void_final_deaths_bedwars")]
        public int FoursVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_fall_kills_bedwars")]
        public int FoursFallKillsBedwars { get; set; }

        [JsonProperty("four_four_fall_final_kills_bedwars")]
        public int FoursFallFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_projectile_deaths_bedwars")]
        public int FoursProjectileDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_final_deaths_bedwars")]
        public int FoursEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_final_kills_bedwars")]
        public int FoursEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_deaths_bedwars")]
        public int FoursEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_final_deaths_bedwars")]
        public int FoursEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_projectile_kills_bedwars")]
        public int FoursProjectileKillsBedwars { get; set; }

        [JsonProperty("four_four_projectile_final_kills_bedwars")]
        public int FoursProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_projectile_final_deaths_bedwars")]
        public int FoursProjectileFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_fire_tick_deaths_bedwars")]
        public int FoursFireTickDeathsBedwars { get; set; }

        [JsonProperty("four_four_wrapped_present_resources_collected_bedwars")]
        public int FoursWrappedPresentResourcesCollected { get; set; }

        [JsonProperty("four_four_winstreak")]
        public int FoursWinstreak { get; set; }

        [JsonProperty("four_four_fire_tick_kills_bedwars")]
        public int FoursFireTickKillsBedwars { get; set; }

        [JsonProperty("four_four_fire_tick_final_kills_bedwars")]
        public int FoursFireTickFinalKillsBedwars { get; set; }
        #endregion

        #region castle bedwars mode
        [JsonProperty("castle_winstreak")]
        public int CastleWinstreak { get; set; }

        [JsonProperty("castle_beds_lost_bedwars")]
        public int CastleBedsLostBedwars { get; set; }

        [JsonProperty("castle_permanent _items_purchased_bedwars")]
        public int CastlePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_deaths_bedwars")]
        public int CastleDeathsBedwars { get; set; }

        [JsonProperty("castle_beds_broken_bedwars")]
        public int CastleBedsBrokenBedwars { get; set; }

        [JsonProperty("castle_games_played_bedwars")]
        public int CastleGamesPlayedBedwars { get; set; }

        [JsonProperty("castle_wins_bedwars")]
        public int CastleWinsBedwars { get; set; }

        [JsonProperty("castle_fall_kills_bedwars")]
        public int CastleFallKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_kills_bedwars")]
        public int CastleEntityAttackKillsBedwars { get; set; }

        [JsonProperty("castle_items_purchased_bedwars")]
        public int CastleItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_diamond_resources_collected_bedwars")]
        public int CastleDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_gold_resources_collected_bedwars")]
        public int CastleGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_resources_collected_bedwars")]
        public int CastleResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_void_deaths_bedwars")]
        public int CastleVoidDeathsBedwars { get; set; }

        [JsonProperty("castle_iron_resources_collected_bedwars")]
        public int CastleIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_void_kills_bedwars")]
        public int CastleVoidKillsBedwars { get; set; }

        [JsonProperty("castle_kills_bedwars")]
        public int CastleKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_final_kills_bedwars")]
        public int CastleEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_deaths_bedwars")]
        public int CastleEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("castle_emerald_resources_collected_bedwars")]
        public int CastleEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_final_kills_bedwars")]
        public int CastleFinalKillsBedwars { get; set; }

        [JsonProperty("castle_void_final_kills_bedwars")]
        public int CastleVoidFinalKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_final_deaths_bedwars")]
        public int CastleEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_final_deaths_bedwars")]
        public int CastleFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_final_kills_bedwars")]
        public int CastleEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("castle_fall_deaths_bedwars")]
        public int CastleFallDeathsBedwars { get; set; }

        [JsonProperty("castle_void_final_deaths_bedwars")]
        public int CastleVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_losses_bedwars")]
        public int CastleLossesBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_kills_bedwars")]
        public int CastleEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("castle_fall_final_kills_bedwars")]
        public int CastleFallFinalKillsBedwars { get; set; }

        [JsonProperty("castle_projectile_deaths_bedwars")]
        public int CastleProjectileDeathsBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_deaths_bedwars")]
        public int CastleEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("castle_suffocation_deaths_bedwars")]
        public int CastleSuffocationDeathsBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_final_deaths_bedwars")]
        public int CastleEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_fall_final_deaths_bedwars")]
        public int CastleFallFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_projectile_final_kills_bedwars")]
        public int CastleProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("castle_projectile_kills_bedwars")]
        public int CastleProjectileKillsBedwars { get; set; }

        [JsonProperty("castle_fire_tick_deaths_bedwars")]
        public int CastleFireTickDeathsBedwars { get; set; }

        [JsonProperty("castle_projectile_final_deaths_bedwars")]
        public int CastleProjectileFinalDeathsBedwars { get; set; }
        #endregion

        #region rush bedwars mode
        [JsonProperty("eight_one_rush_winstreak")]
        public int SolosRushWinstreak { get; set; }

        [JsonProperty("eight_one_rush_kills_bedwars")]
        public int SolosRushKillsBedwars { get; set; }

        [JsonProperty("eight_one_rush_beds_broken_bedwars")]
        public int SolosRushBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_one_rush_items_purchased_bedwars")]
        public int SolosRushItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_rush_games_played_bedwars")]
        public int SolosRushGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_one_rush_deaths_bedwars")]
        public int SolosRushDeathsBedwars { get; set; }

        [JsonProperty("eight_one_rush_entity_attack_final_kills_bedwars")]
        public int SolosRushEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_rush_emerald_resources_collected_bedwars")]
        public int SolosRushEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_rush_void_final_kills_bedwars")]
        public int SolosRushVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_rush_entity_attack_deaths_bedwars")]
        public int SolosRushEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_one_rush_final_kills_bedwars")]
        public int SolosRushFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_rush_gold_resources_collected_bedwars")]
        public int SolosRushGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_rush_resources_collected_bedwars")]
        public int SolosRushResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_rush_void_kills_bedwars")]
        public int SolosRushVoidKillsBedwars { get; set; }

        [JsonProperty("eight_one_rush_diamond_resources_collected_bedwars")]
        public int SolosRushDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_rush_entity_attack_kills_bedwars")]
        public int SolosRushEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_one_rush_wins_bedwars")]
        public int SolosRushWinsBedwars { get; set; }

        [JsonProperty("eight_one_rush_permanent _items_purchased_bedwars")]
        public int SolosRushPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_rush_iron_resources_collected_bedwars")]
        public int SolosRushIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_rush_void_deaths_bedwars")]
        public int SolosRushVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_one_rush_fall_final_deaths_bedwars")]
        public int SolosRushFallFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_rush_losses_bedwars")]
        public int SolosRushLossesBedwars { get; set; }

        [JsonProperty("eight_one_rush_beds_lost_bedwars")]
        public int SolosRushBedsLostBedwars { get; set; }

        [JsonProperty("eight_one_rush_final_deaths_bedwars")]
        public int SolosRushFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_rush_entity_attack_final_deaths_bedwars")]
        public int SolosRushEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_rush_entity_explosion_final_kills_bedwars")]
        public int SolosRushEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_winstreak")]
        public int DuosRushWinstreak { get; set; }

        [JsonProperty("eight_two_rush_kills_bedwars")]
        public int DuosRushKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_beds_broken_bedwars")]
        public int DuosRushBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_two_rush_items_purchased_bedwars")]
        public int DuosRushItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_rush_games_played_bedwars")]
        public int DuosRushGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_rush_deaths_bedwars")]
        public int DuosRushDeathsBedwars { get; set; }

        [JsonProperty("eight_two_rush_entity_attack_final_kills_bedwars")]
        public int DuosRushEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_emerald_resources_collected_bedwars")]
        public int DuosRushEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_rush_void_final_kills_bedwars")]
        public int DuosRushVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_entity_attack_deaths_bedwars")]
        public int DuosRushEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_two_rush_final_kills_bedwars")]
        public int DuosRushFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_gold_resources_collected_bedwars")]
        public int DuosRushGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_rush_resources_collected_bedwars")]
        public int DuosRushResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_rush_void_kills_bedwars")]
        public int DuosRushVoidKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_diamond_resources_collected_bedwars")]
        public int DuosRushDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_rush_entity_attack_kills_bedwars")]
        public int DuosRushEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_two_rush_wins_bedwars")]
        public int DuosRushWinsBedwars { get; set; }

        [JsonProperty("eight_two_rush_permanent _items_purchased_bedwars")]
        public int DuosRushPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_rush_iron_resources_collected_bedwars")]
        public int DuosRushIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_rush_void_deaths_bedwars")]
        public int DuosRushVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_two_rush_fall_final_deaths_bedwars")]
        public int DuosRushFallFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_rush_losses_bedwars")]
        public int DuosRushLossesBedwars { get; set; }

        [JsonProperty("eight_two_rush_beds_lost_bedwars")]
        public int DuosRushBedsLostBedwars { get; set; }

        [JsonProperty("eight_two_rush_final_deaths_bedwars")]
        public int DuosRushFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_rush_entity_attack_final_deaths_bedwars")]
        public int DuosRushEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_rush_entity_explosion_final_kills_bedwars")]
        public int DuosRushEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_winstreak")]
        public int FoursRushWinstreak { get; set; }

        [JsonProperty("four_four_rush_kills_bedwars")]
        public int FoursRushKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_beds_broken_bedwars")]
        public int FoursRushBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_rush_items_purchased_bedwars")]
        public int FoursRushItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_rush_games_played_bedwars")]
        public int FoursRushGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_rush_deaths_bedwars")]
        public int FoursRushDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_final_kills_bedwars")]
        public int FoursRushEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_emerald_resources_collected_bedwars")]
        public int FoursRushEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_void_final_kills_bedwars")]
        public int FoursRushVoidFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_deaths_bedwars")]
        public int FoursRushEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_final_kills_bedwars")]
        public int FoursRushFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_gold_resources_collected_bedwars")]
        public int FoursRushGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_resources_collected_bedwars")]
        public int FoursRushResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_void_kills_bedwars")]
        public int FoursRushVoidKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_diamond_resources_collected_bedwars")]
        public int FoursRushDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_kills_bedwars")]
        public int FoursRushEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_wins_bedwars")]
        public int FoursRushWinsBedwars { get; set; }

        [JsonProperty("four_four_rush_permanent _items_purchased_bedwars")]
        public int FoursRushPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_rush_iron_resources_collected_bedwars")]
        public int FoursRushIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_void_deaths_bedwars")]
        public int FoursRushVoidDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_fall_final_deaths_bedwars")]
        public int FoursRushFallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_losses_bedwars")]
        public int FoursRushLossesBedwars { get; set; }

        [JsonProperty("four_four_rush_beds_lost_bedwars")]
        public int FoursRushBedsLostBedwars { get; set; }

        [JsonProperty("four_four_rush_final_deaths_bedwars")]
        public int FoursRushFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_final_deaths_bedwars")]
        public int FoursRushEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_explosion_final_kills_bedwars")]
        public int FoursRushEntityExplosionFinalKillsBedwars { get; set; }
        #endregion

        #region lucky bedwars mode
        [JsonProperty("eight_two_lucky_winstreak")]
        public int DuosLuckyWinstreak { get; set; }

        [JsonProperty("eight_two_lucky_void_deaths_bedwars")]
        public int DuosLuckyVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_permanent _items_purchased_bedwars")]
        public int DuosLuckyPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_items_purchased_bedwars")]
        public int DuosLuckyItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_games_played_bedwars")]
        public int DuosLuckyGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_beds_broken_bedwars")]
        public int DuosLuckyBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_two_lucky_resources_collected_bedwars")]
        public int DuosLuckyResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_deaths_bedwars")]
        public int DuosLuckyDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_iron_resources_collected_bedwars")]
        public int DuosLuckyIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_gold_resources_collected_bedwars")]
        public int DuosLuckyGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_wins_bedwars")]
        public int DuosLuckyWinsBedwars { get; set; }

        [JsonProperty("four_four_lucky_winstreak")]
        public int FoursLuckyWinstreak { get; set; }

        [JsonProperty("four_four_lucky_void_deaths_bedwars")]
        public int FoursLuckyVoidDeathsBedwars { get; set; }

        [JsonProperty("four_four_lucky_permanent _items_purchased_bedwars")]
        public int FoursLuckyPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_lucky_items_purchased_bedwars")]
        public int FoursLuckyItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_lucky_games_played_bedwars")]
        public int FoursLuckyGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_lucky_beds_broken_bedwars")]
        public int FoursLuckyBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_lucky_resources_collected_bedwars")]
        public int FoursLuckyResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_lucky_deaths_bedwars")]
        public int FoursLuckyDeathsBedwars { get; set; }

        [JsonProperty("four_four_lucky_iron_resources_collected_bedwars")]
        public int FoursLuckyIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_lucky_gold_resources_collected_bedwars")]
        public int FoursLuckyGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_lucky_wins_bedwars")]
        public int FoursLuckyWinsBedwars { get; set; }
        #endregion
    }
}