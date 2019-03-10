using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Bedwars
    {
        [JsonProperty("Experience")]
        public long Experience { get; set; }

        [JsonProperty("bedwars_boxes")]
        public long BedwarsBoxes { get; set; }

        [JsonProperty("bedwars_box")]
        public long BedwarsBox { get; set; }

        [JsonProperty("chest_history")]
        public string ChestHistory { get; set; }

        [JsonProperty("bedwars_box_commons")]
        public long BedwarsBoxCommons { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("bedwars_box_rares")]
        public long BedwarsBoxRares { get; set; }

        [JsonProperty("activeVictoryDance")]
        public string ActiveVictoryDance { get; set; }

        [JsonProperty("spray_storage_new")]
        public string SprayStorageNew { get; set; }

        [JsonProperty("games_played_bedwars_1")]
        public long GamesPlayedBedwars1 { get; set; }

        [JsonProperty("winstreak")]
        public long Winstreak { get; set; }

        [JsonProperty("final_deaths_bedwars")]
        public long FinalDeathsBedwars { get; set; }

        [JsonProperty("gold_resources_collected_bedwars")]
        public long GoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_beds_broken_bedwars")]
        public long FourFourBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four__items_purchased_bedwars")]
        public long FourFourItemsPurchasedBedwars { get; set; }

        [JsonProperty("emerald_resources_collected_bedwars")]
        public long EmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("resources_collected_bedwars")]
        public long ResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_kills_bedwars")]
        public long FourFourKillsBedwars { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("games_played_bedwars")]
        public long GamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_final_deaths_bedwars")]
        public long FourFourFinalDeathsBedwars { get; set; }

        [JsonProperty("entity_attack_final_kills_bedwars")]
        public long EntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_gold_resources_collected_bedwars")]
        public long FourFourGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_beds_lost_bedwars")]
        public long FourFourBedsLostBedwars { get; set; }

        [JsonProperty("four_four_losses_bedwars")]
        public long FourFourLossesBedwars { get; set; }

        [JsonProperty("four_four_iron_resources_collected_bedwars")]
        public long FourFourIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("beds_lost_bedwars")]
        public long BedsLostBedwars { get; set; }

        [JsonProperty("kills_bedwars")]
        public long KillsBedwars { get; set; }

        [JsonProperty("entity_attack_kills_bedwars")]
        public long EntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_games_played_bedwars")]
        public long FourFourGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_final_kills_bedwars")]
        public long FourFourEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("fall_final_deaths_bedwars")]
        public long FallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_fall_final_deaths_bedwars")]
        public long FourFourFallFinalDeathsBedwars { get; set; }

        [JsonProperty("losses_bedwars")]
        public long LossesBedwars { get; set; }

        [JsonProperty("items_purchased_bedwars")]
        public long BedwarsItemsPurchasedBedwars { get; set; }

        [JsonProperty("final_kills_bedwars")]
        public long FinalKillsBedwars { get; set; }

        [JsonProperty("four_four_resources_collected_bedwars")]
        public long FourFourResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_items_purchased_bedwars")]
        public long BedwarsFourFourItemsPurchasedBedwars { get; set; }

        [JsonProperty("iron_resources_collected_bedwars")]
        public long IronResourcesCollectedBedwars { get; set; }

        [JsonProperty("beds_broken_bedwars")]
        public long BedsBrokenBedwars { get; set; }

        [JsonProperty("_items_purchased_bedwars")]
        public long ItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_kills_bedwars")]
        public long FourFourEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_final_kills_bedwars")]
        public long FourFourFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_emerald_resources_collected_bedwars")]
        public long FourFourEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("void_kills_bedwars")]
        public long VoidKillsBedwars { get; set; }

        [JsonProperty("deaths_bedwars")]
        public long DeathsBedwars { get; set; }

        [JsonProperty("four_four_permanent _items_purchased_bedwars")]
        public long FourFourPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("fall_deaths_bedwars")]
        public long FallDeathsBedwars { get; set; }

        [JsonProperty("four_four_void_kills_bedwars")]
        public long FourFourVoidKillsBedwars { get; set; }

        [JsonProperty("four_four_fall_deaths_bedwars")]
        public long FourFourFallDeathsBedwars { get; set; }

        [JsonProperty("permanent _items_purchased_bedwars")]
        public long PermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_deaths_bedwars")]
        public long FourFourDeathsBedwars { get; set; }

        [JsonProperty("four_four_wins_bedwars")]
        public long FourFourWinsBedwars { get; set; }

        [JsonProperty("four_four_void_final_kills_bedwars")]
        public long FourFourVoidFinalKillsBedwars { get; set; }

        [JsonProperty("wins_bedwars")]
        public long WinsBedwars { get; set; }

        [JsonProperty("void_final_kills_bedwars")]
        public long VoidFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_deaths_bedwars")]
        public long FourFourEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("entity_attack_deaths_bedwars")]
        public long EntityAttackDeathsBedwars { get; set; }

        [JsonProperty("diamond_resources_collected_bedwars")]
        public long DiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_diamond_resources_collected_bedwars")]
        public long FourFourDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("entity_attack_final_deaths_bedwars")]
        public long EntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_iron_resources_collected_bedwars")]
        public long FourThreeIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_final_deaths_bedwars")]
        public long FourThreeEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_games_played_bedwars")]
        public long FourThreeGamesPlayedBedwars { get; set; }

        [JsonProperty("four_three__items_purchased_bedwars")]
        public long FourThreeItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_fall_deaths_bedwars")]
        public long FourThreeFallDeathsBedwars { get; set; }

        [JsonProperty("four_three_emerald_resources_collected_bedwars")]
        public long FourThreeEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_beds_lost_bedwars")]
        public long FourThreeBedsLostBedwars { get; set; }

        [JsonProperty("four_three_gold_resources_collected_bedwars")]
        public long FourThreeGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_deaths_bedwars")]
        public long FourThreeDeathsBedwars { get; set; }

        [JsonProperty("four_three_beds_broken_bedwars")]
        public long FourThreeBedsBrokenBedwars { get; set; }

        [JsonProperty("four_three_losses_bedwars")]
        public long FourThreeLossesBedwars { get; set; }

        [JsonProperty("four_three_items_purchased_bedwars")]
        public long BedwarsFourThreeItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_final_deaths_bedwars")]
        public long FourThreeFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_resources_collected_bedwars")]
        public long FourThreeResourcesCollectedBedwars { get; set; }

        [JsonProperty("void_deaths_bedwars")]
        public long VoidDeathsBedwars { get; set; }

        [JsonProperty("four_three_void_final_kills_bedwars")]
        public long FourThreeVoidFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_wins_bedwars")]
        public long FourThreeWinsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_final_kills_bedwars")]
        public long FourThreeEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_final_kills_bedwars")]
        public long EntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_void_deaths_bedwars")]
        public long FourThreeVoidDeathsBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_deaths_bedwars")]
        public long FourThreeEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_three_permanent _items_purchased_bedwars")]
        public long FourThreePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_final_kills_bedwars")]
        public long FourThreeEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_final_kills_bedwars")]
        public long FourThreeFinalKillsBedwars { get; set; }

        [JsonProperty("activeNPCSkin")]
        public string ActiveNpcSkin { get; set; }

        [JsonProperty("activeIslandTopper")]
        public string ActiveIslandTopper { get; set; }

        [JsonProperty("activeProjectileTrail")]
        public string ActiveProjectileTrail { get; set; }

        [JsonProperty("four_four_entity_explosion_kills_bedwars")]
        public long FourFourEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_kills_bedwars")]
        public long EntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_four_void_deaths_bedwars")]
        public long FourFourVoidDeathsBedwars { get; set; }

        [JsonProperty("four_four_void_final_deaths_bedwars")]
        public long FourFourVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("void_final_deaths_bedwars")]
        public long VoidFinalDeathsBedwars { get; set; }

        [JsonProperty("fall_kills_bedwars")]
        public long FallKillsBedwars { get; set; }

        [JsonProperty("four_four_fall_kills_bedwars")]
        public long FourFourFallKillsBedwars { get; set; }

        [JsonProperty("fall_final_kills_bedwars")]
        public long FallFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_fall_final_kills_bedwars")]
        public long FourFourFallFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_projectile_deaths_bedwars")]
        public long FourFourProjectileDeathsBedwars { get; set; }

        [JsonProperty("projectile_deaths_bedwars")]
        public long ProjectileDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_final_deaths_bedwars")]
        public long FourFourEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("glyph_storage_new")]
        public string GlyphStorageNew { get; set; }

        [JsonProperty("eight_one_beds_lost_bedwars")]
        public long EightOneBedsLostBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_final_kills_bedwars")]
        public long EightOneEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_deaths_bedwars")]
        public long EightOneDeathsBedwars { get; set; }

        [JsonProperty("eight_one_void_deaths_bedwars")]
        public long EightOneVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_one_games_played_bedwars")]
        public long EightOneGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_one_final_kills_bedwars")]
        public long EightOneFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_beds_broken_bedwars")]
        public long EightOneBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_one_iron_resources_collected_bedwars")]
        public long EightOneIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one__items_purchased_bedwars")]
        public long EightOneItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_emerald_resources_collected_bedwars")]
        public long EightOneEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_items_purchased_bedwars")]
        public long BedwarsEightOneItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_diamond_resources_collected_bedwars")]
        public long EightOneDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_permanent _items_purchased_bedwars")]
        public long EightOnePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_kills_bedwars")]
        public long EightOneEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_one_void_final_kills_bedwars")]
        public long EightOneVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_wins_bedwars")]
        public long EightOneWinsBedwars { get; set; }

        [JsonProperty("eight_one_kills_bedwars")]
        public long EightOneKillsBedwars { get; set; }

        [JsonProperty("eight_one_resources_collected_bedwars")]
        public long EightOneResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_gold_resources_collected_bedwars")]
        public long EightOneGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_final_deaths_bedwars")]
        public long EightOneFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_final_deaths_bedwars")]
        public long EightOneEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_losses_bedwars")]
        public long EightOneLossesBedwars { get; set; }

        [JsonProperty("eight_one_fall_kills_bedwars")]
        public long EightOneFallKillsBedwars { get; set; }

        [JsonProperty("quickjoin_uses_Aquarium")]
        public long QuickjoinUsesAquarium { get; set; }

        [JsonProperty("quickjoin_uses_total")]
        public long QuickjoinUsesTotal { get; set; }

        [JsonProperty("eight_two_void_deaths_bedwars")]
        public long EightTwoVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_two_beds_broken_bedwars")]
        public long EightTwoBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_two_emerald_resources_collected_bedwars")]
        public long EightTwoEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_permanent _items_purchased_bedwars")]
        public long EightTwoPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_resources_collected_bedwars")]
        public long EightTwoResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_diamond_resources_collected_bedwars")]
        public long EightTwoDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_fall_deaths_bedwars")]
        public long EightTwoFallDeathsBedwars { get; set; }

        [JsonProperty("eight_two_kills_bedwars")]
        public long EightTwoKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_final_kills_bedwars")]
        public long EightTwoEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_kills_bedwars")]
        public long EightTwoEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_two_iron_resources_collected_bedwars")]
        public long EightTwoIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_final_deaths_bedwars")]
        public long EightTwoFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_void_final_deaths_bedwars")]
        public long EightTwoVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_deaths_bedwars")]
        public long EightTwoDeathsBedwars { get; set; }

        [JsonProperty("eight_two__items_purchased_bedwars")]
        public long EightTwoItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_games_played_bedwars")]
        public long EightTwoGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_items_purchased_bedwars")]
        public long BedwarsEightTwoItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_beds_lost_bedwars")]
        public long EightTwoBedsLostBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_deaths_bedwars")]
        public long EightTwoEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_two_void_final_kills_bedwars")]
        public long EightTwoVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_gold_resources_collected_bedwars")]
        public long EightTwoGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_final_kills_bedwars")]
        public long EightTwoFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_losses_bedwars")]
        public long EightTwoLossesBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_final_kills_bedwars")]
        public long FourFourEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_projectile_kills_bedwars")]
        public long EightOneProjectileKillsBedwars { get; set; }

        [JsonProperty("projectile_kills_bedwars")]
        public long ProjectileKillsBedwars { get; set; }

        [JsonProperty("eight_one_void_kills_bedwars")]
        public long EightOneVoidKillsBedwars { get; set; }

        [JsonProperty("eight_one_void_final_deaths_bedwars")]
        public long EightOneVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_deaths_bedwars")]
        public long EightOneEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_two_fall_final_kills_bedwars")]
        public long EightTwoFallFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_wins_bedwars")]
        public long EightTwoWinsBedwars { get; set; }

        [JsonProperty("eight_two_fall_kills_bedwars")]
        public long EightTwoFallKillsBedwars { get; set; }

        [JsonProperty("eight_two_void_kills_bedwars")]
        public long EightTwoVoidKillsBedwars { get; set; }

        [JsonProperty("four_three_diamond_resources_collected_bedwars")]
        public long FourThreeDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_void_kills_bedwars")]
        public long FourThreeVoidKillsBedwars { get; set; }

        [JsonProperty("four_three_fall_final_kills_bedwars")]
        public long FourThreeFallFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_kills_bedwars")]
        public long FourThreeKillsBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_kills_bedwars")]
        public long FourThreeEntityAttackKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_deaths_bedwars")]
        public long EntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_deaths_bedwars")]
        public long FourFourEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_kills_bedwars")]
        public long FourThreeEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("quickjoin_uses_Chained")]
        public long QuickjoinUsesChained { get; set; }

        [JsonProperty("quickjoin_uses_Archway")]
        public long QuickjoinUsesArchway { get; set; }

        [JsonProperty("spray_glyph_field")]
        public string SprayGlyphField { get; set; }

        [JsonProperty("activeDeathCry")]
        public string ActiveDeathCry { get; set; }

        [JsonProperty("activeKillEffect")]
        public string ActiveKillEffect { get; set; }

        [JsonProperty("quickjoin_uses_random")]
        public long QuickjoinUsesRandom { get; set; }

        [JsonProperty("eight_one_fall_final_kills_bedwars")]
        public long EightOneFallFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_final_deaths_bedwars")]
        public long EightTwoEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("quickjoin_uses_Boletum")]
        public long QuickjoinUsesBoletum { get; set; }

        [JsonProperty("four_three_void_final_deaths_bedwars")]
        public long FourThreeVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("chest_history_new")]
        public List<string> ChestHistoryNew { get; set; }

        [JsonProperty("bedwars_box_legendaries")]
        public long BedwarsBoxLegendaries { get; set; }

        [JsonProperty("quickjoin_uses_Amazon")]
        public long QuickjoinUsesAmazon { get; set; }

        [JsonProperty("quickjoin_uses_Lotus")]
        public long QuickjoinUsesLotus { get; set; }

        [JsonProperty("quickjoin_uses_Rooftop")]
        public long QuickjoinUsesRooftop { get; set; }

        [JsonProperty("quickjoin_uses_Waterfall")]
        public long QuickjoinUsesWaterfall { get; set; }

        [JsonProperty("projectile_final_kills_bedwars")]
        public long ProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_fall_final_deaths_bedwars")]
        public long EightTwoFallFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_final_kills_bedwars")]
        public long EightTwoProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_fall_deaths_bedwars")]
        public long EightOneFallDeathsBedwars { get; set; }

        [JsonProperty("eight_one_projectile_final_kills_bedwars")]
        public long EightOneProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_deaths_bedwars")]
        public long FourThreeEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("four_three_projectile_kills_bedwars")]
        public long FourThreeProjectileKillsBedwars { get; set; }

        [JsonProperty("four_three_fall_kills_bedwars")]
        public long FourThreeFallKillsBedwars { get; set; }

        [JsonProperty("eight_one_entity_explosion_kills_bedwars")]
        public long EightOneEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("bedwars_box_epics")]
        public long BedwarsBoxEpics { get; set; }

        [JsonProperty("eight_one_projectile_deaths_bedwars")]
        public long EightOneProjectileDeathsBedwars { get; set; }

        [JsonProperty("eight_two_entity_explosion_final_kills_bedwars")]
        public long EightTwoEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_final_deaths_bedwars")]
        public long FourThreeEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("entity_explosion_final_deaths_bedwars")]
        public long EntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_fall_final_deaths_bedwars")]
        public long FourThreeFallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_final_deaths_bedwars")]
        public long FourFourEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_kills_bedwars")]
        public long EightTwoProjectileKillsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_deaths_bedwars")]
        public long EightTwoProjectileDeathsBedwars { get; set; }

        [JsonProperty("four_four_projectile_kills_bedwars")]
        public long FourFourProjectileKillsBedwars { get; set; }

        [JsonProperty("four_four_projectile_final_kills_bedwars")]
        public long FourFourProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_projectile_final_deaths_bedwars")]
        public long FourFourProjectileFinalDeathsBedwars { get; set; }

        [JsonProperty("projectile_final_deaths_bedwars")]
        public long ProjectileFinalDeathsBedwars { get; set; }

        [JsonProperty("free_event_key_bedwars_halloween_boxes_2017")]
        public bool FreeEventKeyBedwarsHalloweenBoxes2017 { get; set; }

        [JsonProperty("bedwars_halloween_boxes")]
        public long BedwarsHalloweenBoxes { get; set; }

        [JsonProperty("Bedwars_openedChests")]
        public long BedwarsOpenedChests { get; set; }

        [JsonProperty("Bedwars_openedCommons")]
        public long BedwarsOpenedCommons { get; set; }

        [JsonProperty("Bedwars_openedRares")]
        public long BedwarsOpenedRares { get; set; }

        [JsonProperty("spooky_open_ach")]
        public long SpookyOpenAch { get; set; }

        [JsonProperty("Bedwars_openedEpics")]
        public long BedwarsOpenedEpics { get; set; }

        [JsonProperty("four_four_fire_tick_deaths_bedwars")]
        public long FourFourFireTickDeathsBedwars { get; set; }

        [JsonProperty("fire_tick_deaths_bedwars")]
        public long FireTickDeathsBedwars { get; set; }

        [JsonProperty("four_three_projectile_final_kills_bedwars")]
        public long FourThreeProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("bedwars_christmas_boxes")]
        public long BedwarsChristmasBoxes { get; set; }

        [JsonProperty("free_event_key_bedwars_christmas_boxes_2017")]
        public bool FreeEventKeyBedwarsChristmasBoxes2017 { get; set; }

        [JsonProperty("four_four_wrapped_present_resources_collected_bedwars")]
        public long FourFourWrappedPresentResourcesCollectedBedwars { get; set; }

        [JsonProperty("wrapped_present_resources_collected_bedwars")]
        public long WrappedPresentResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_wrapped_present_resources_collected_bedwars")]
        public long FourThreeWrappedPresentResourcesCollectedBedwars { get; set; }

        [JsonProperty("Bedwars_openedLegendaries")]
        public long BedwarsOpenedLegendaries { get; set; }

        [JsonProperty("free_event_key_bedwars_christmas_boxes_2018")]
        public bool FreeEventKeyBedwarsChristmasBoxes2018 { get; set; }

        [JsonProperty("seen_beta_menu")]
        public long SeenBetaMenu { get; set; }

        [JsonProperty("bedwars_lunar_boxes")]
        public long BedwarsLunarBoxes { get; set; }

        [JsonProperty("free_event_key_bedwars_lunar_boxes_2018")]
        public bool FreeEventKeyBedwarsLunarBoxes2018 { get; set; }

        [JsonProperty("favourites_2")]
        public string Favourites2 { get; set; }

        [JsonProperty("activeSprays")]
        public string ActiveSprays { get; set; }

        [JsonProperty("four_three_fire_tick_deaths_bedwars")]
        public long FourThreeFireTickDeathsBedwars { get; set; }

        [JsonProperty("bedwars_easter_boxes")]
        public long BedwarsEasterBoxes { get; set; }

        [JsonProperty("favorite_slots")]
        public string FavoriteSlots { get; set; }

        [JsonProperty("four_four_winstreak")]
        public long FourFourWinstreak { get; set; }

        [JsonProperty("four_three_winstreak")]
        public long FourThreeWinstreak { get; set; }

        [JsonProperty("fire_tick_kills_bedwars")]
        public long FireTickKillsBedwars { get; set; }

        [JsonProperty("four_four_fire_tick_kills_bedwars")]
        public long FourFourFireTickKillsBedwars { get; set; }

        [JsonProperty("understands_streaks")]
        public bool UnderstandsStreaks { get; set; }

        [JsonProperty("fav_streak_slots")]
        public string FavStreakSlots { get; set; }

        [JsonProperty("understands_resource_bank")]
        public bool UnderstandsResourceBank { get; set; }

        [JsonProperty("castle_winstreak")]
        public long CastleWinstreak { get; set; }

        [JsonProperty("castle_beds_lost_bedwars")]
        public long CastleBedsLostBedwars { get; set; }

        [JsonProperty("castle_permanent _items_purchased_bedwars")]
        public long CastlePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_deaths_bedwars")]
        public long CastleDeathsBedwars { get; set; }

        [JsonProperty("castle_beds_broken_bedwars")]
        public long CastleBedsBrokenBedwars { get; set; }

        [JsonProperty("castle__items_purchased_bedwars")]
        public long CastleItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_games_played_bedwars")]
        public long CastleGamesPlayedBedwars { get; set; }

        [JsonProperty("castle_wins_bedwars")]
        public long CastleWinsBedwars { get; set; }

        [JsonProperty("castle_fall_kills_bedwars")]
        public long CastleFallKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_kills_bedwars")]
        public long CastleEntityAttackKillsBedwars { get; set; }

        [JsonProperty("castle_items_purchased_bedwars")]
        public long BedwarsCastleItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_diamond_resources_collected_bedwars")]
        public long CastleDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_gold_resources_collected_bedwars")]
        public long CastleGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_resources_collected_bedwars")]
        public long CastleResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_void_deaths_bedwars")]
        public long CastleVoidDeathsBedwars { get; set; }

        [JsonProperty("castle_iron_resources_collected_bedwars")]
        public long CastleIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_void_kills_bedwars")]
        public long CastleVoidKillsBedwars { get; set; }

        [JsonProperty("castle_kills_bedwars")]
        public long CastleKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_final_kills_bedwars")]
        public long CastleEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_deaths_bedwars")]
        public long CastleEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("castle_emerald_resources_collected_bedwars")]
        public long CastleEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_final_kills_bedwars")]
        public long CastleFinalKillsBedwars { get; set; }

        [JsonProperty("castle_void_final_kills_bedwars")]
        public long CastleVoidFinalKillsBedwars { get; set; }

        [JsonProperty("castle_entity_attack_final_deaths_bedwars")]
        public long CastleEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_final_deaths_bedwars")]
        public long CastleFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_final_kills_bedwars")]
        public long CastleEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("castle_fall_deaths_bedwars")]
        public long CastleFallDeathsBedwars { get; set; }

        [JsonProperty("castle_void_final_deaths_bedwars")]
        public long CastleVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_losses_bedwars")]
        public long CastleLossesBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_kills_bedwars")]
        public long CastleEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("castle_fall_final_kills_bedwars")]
        public long CastleFallFinalKillsBedwars { get; set; }

        [JsonProperty("castle_projectile_deaths_bedwars")]
        public long CastleProjectileDeathsBedwars { get; set; }

        [JsonProperty("castle_entity_explosion_deaths_bedwars")]
        public long CastleEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("castle_suffocation_deaths_bedwars")]
        public long CastleSuffocationDeathsBedwars { get; set; }

        [JsonProperty("activeBedDestroy")]
        public string ActiveBedDestroy { get; set; }

        [JsonProperty("activeGlyph")]
        public string ActiveGlyph { get; set; }

        [JsonProperty("castle_entity_explosion_final_deaths_bedwars")]
        public long CastleEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_fall_final_deaths_bedwars")]
        public long CastleFallFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_winstreak")]
        public long EightTwoWinstreak { get; set; }

        [JsonProperty("fire_kills_bedwars")]
        public long FireKillsBedwars { get; set; }

        [JsonProperty("eight_two_fire_kills_bedwars")]
        public long EightTwoFireKillsBedwars { get; set; }

        [JsonProperty("castle_projectile_final_kills_bedwars")]
        public long CastleProjectileFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_winstreak")]
        public long FourFourRushWinstreak { get; set; }

        [JsonProperty("four_four_rush_kills_bedwars")]
        public long FourFourRushKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_beds_broken_bedwars")]
        public long FourFourRushBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_rush_items_purchased_bedwars")]
        public long BedwarsFourFourRushItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_rush_games_played_bedwars")]
        public long FourFourRushGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_rush_deaths_bedwars")]
        public long FourFourRushDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_final_kills_bedwars")]
        public long FourFourRushEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_emerald_resources_collected_bedwars")]
        public long FourFourRushEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_void_final_kills_bedwars")]
        public long FourFourRushVoidFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_deaths_bedwars")]
        public long FourFourRushEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_final_kills_bedwars")]
        public long FourFourRushFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_gold_resources_collected_bedwars")]
        public long FourFourRushGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_resources_collected_bedwars")]
        public long FourFourRushResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_void_kills_bedwars")]
        public long FourFourRushVoidKillsBedwars { get; set; }

        [JsonProperty("four_four_rush_diamond_resources_collected_bedwars")]
        public long FourFourRushDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_kills_bedwars")]
        public long FourFourRushEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_rush__items_purchased_bedwars")]
        public long FourFourRushItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_rush_wins_bedwars")]
        public long FourFourRushWinsBedwars { get; set; }

        [JsonProperty("four_four_rush_permanent _items_purchased_bedwars")]
        public long FourFourRushPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_rush_iron_resources_collected_bedwars")]
        public long FourFourRushIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_rush_void_deaths_bedwars")]
        public long FourFourRushVoidDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_fall_final_deaths_bedwars")]
        public long FourFourRushFallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_losses_bedwars")]
        public long FourFourRushLossesBedwars { get; set; }

        [JsonProperty("four_four_rush_beds_lost_bedwars")]
        public long FourFourRushBedsLostBedwars { get; set; }

        [JsonProperty("four_four_rush_final_deaths_bedwars")]
        public long FourFourRushFinalDeathsBedwars { get; set; }

        [JsonProperty("selected_ultimate")]
        public string SelectedUltimate { get; set; }

        [JsonProperty("fire_tick_final_kills_bedwars")]
        public long FireTickFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_fire_tick_final_kills_bedwars")]
        public long FourFourFireTickFinalKillsBedwars { get; set; }

        [JsonProperty("castle_projectile_kills_bedwars")]
        public long CastleProjectileKillsBedwars { get; set; }

        [JsonProperty("castle_fire_tick_deaths_bedwars")]
        public long CastleFireTickDeathsBedwars { get; set; }

        [JsonProperty("castle_projectile_final_deaths_bedwars")]
        public long CastleProjectileFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_attack_final_deaths_bedwars")]
        public long FourFourRushEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_rush_entity_explosion_final_kills_bedwars")]
        public long FourFourRushEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("lastTourneyAd")]
        public long LastTourneyAd { get; set; }

        [JsonProperty("lastHytaleAd")]
        public long LastHytaleAd { get; set; }

        [JsonProperty("eight_one_winstreak")]
        public long EightOneWinstreak { get; set; }

        [JsonProperty("four_four_lucky_winstreak")]
        public long FourFourLuckyWinstreak { get; set; }

        [JsonProperty("four_four_lucky_void_deaths_bedwars")]
        public long FourFourLuckyVoidDeathsBedwars { get; set; }

        [JsonProperty("four_four_lucky_permanent _items_purchased_bedwars")]
        public long FourFourLuckyPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_lucky_items_purchased_bedwars")]
        public long BedwarsFourFourLuckyItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_lucky_games_played_bedwars")]
        public long FourFourLuckyGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_lucky__items_purchased_bedwars")]
        public long FourFourLuckyItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_lucky_beds_broken_bedwars")]
        public long FourFourLuckyBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_lucky_resources_collected_bedwars")]
        public long FourFourLuckyResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_lucky_deaths_bedwars")]
        public long FourFourLuckyDeathsBedwars { get; set; }

        [JsonProperty("four_four_lucky_iron_resources_collected_bedwars")]
        public long FourFourLuckyIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_lucky_gold_resources_collected_bedwars")]
        public long FourFourLuckyGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_lucky_wins_bedwars")]
        public long FourFourLuckyWinsBedwars { get; set; }
    }
}