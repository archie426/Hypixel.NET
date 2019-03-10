using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SkyClash
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("card_packs")]
        public long CardPacks { get; set; }

        [JsonProperty("active_class")]
        public long ActiveClass { get; set; }

        [JsonProperty("highestKillstreak")]
        public long HighestKillstreak { get; set; }

        [JsonProperty("killstreak")]
        public long Killstreak { get; set; }

        [JsonProperty("longest_bow_shot_kit_swordsman")]
        public long LongestBowShotKitSwordsman { get; set; }

        [JsonProperty("longest_bow_shot")]
        public long LongestBowShot { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("bow_shots_kit_swordsman")]
        public long BowShotsKitSwordsman { get; set; }

        [JsonProperty("deaths_kit_swordsman")]
        public long DeathsKitSwordsman { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_kit_swordsman")]
        public long KillsKitSwordsman { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("bow_hits_kit_swordsman")]
        public long BowHitsKitSwordsman { get; set; }

        [JsonProperty("bow_shots")]
        public long BowShots { get; set; }

        [JsonProperty("losses_solo")]
        public long LossesSolo { get; set; }

        [JsonProperty("most_kills_game_kit_swordsman")]
        public long MostKillsGameKitSwordsman { get; set; }

        [JsonProperty("void_kills")]
        public long VoidKills { get; set; }

        [JsonProperty("bow_hits")]
        public long BowHits { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; set; }

        [JsonProperty("most_kills_game")]
        public long MostKillsGame { get; set; }

        [JsonProperty("melee_kills")]
        public long MeleeKills { get; set; }

        [JsonProperty("void_kills_kit_swordsman")]
        public long VoidKillsKitSwordsman { get; set; }

        [JsonProperty("kills_solo")]
        public long KillsSolo { get; set; }

        [JsonProperty("kills_monthly_b")]
        public long KillsMonthlyB { get; set; }

        [JsonProperty("games_played_kit_swordsman")]
        public long GamesPlayedKitSwordsman { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("melee_kills_kit_swordsman")]
        public long MeleeKillsKitSwordsman { get; set; }

        [JsonProperty("kills_weekly_b")]
        public long KillsWeeklyB { get; set; }

        [JsonProperty("play_streak")]
        public long PlayStreak { get; set; }

        [JsonProperty("perk_void_magnet")]
        public long PerkVoidMagnet { get; set; }

        [JsonProperty("perk_energy_drink_new")]
        public bool PerkEnergyDrinkNew { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("perk_energy_drink_duplicates")]
        public long PerkEnergyDrinkDuplicates { get; set; }

        [JsonProperty("perk_void_magnet_new")]
        public bool PerkVoidMagnetNew { get; set; }

        [JsonProperty("perk_energy_drink")]
        public long PerkEnergyDrink { get; set; }

        [JsonProperty("losses_doubles")]
        public long LossesDoubles { get; set; }

        [JsonProperty("deaths_doubles")]
        public long DeathsDoubles { get; set; }

        [JsonProperty("fastest_win_team_war_kit_guardian")]
        public long FastestWinTeamWarKitGuardian { get; set; }

        [JsonProperty("longest_bow_shot_kit_guardian")]
        public long LongestBowShotKitGuardian { get; set; }

        [JsonProperty("fastest_win_team_war")]
        public long FastestWinTeamWar { get; set; }

        [JsonProperty("enderchests_opened_kit_guardian")]
        public long EnderchestsOpenedKitGuardian { get; set; }

        [JsonProperty("melee_kills_kit_guardian")]
        public long MeleeKillsKitGuardian { get; set; }

        [JsonProperty("games_played_kit_guardian")]
        public long GamesPlayedKitGuardian { get; set; }

        [JsonProperty("kills_kit_guardian")]
        public long KillsKitGuardian { get; set; }

        [JsonProperty("enderchests_opened")]
        public long EnderchestsOpened { get; set; }

        [JsonProperty("wins_team_war")]
        public long WinsTeamWar { get; set; }

        [JsonProperty("team_war_wins_kit_guardian")]
        public long TeamWarWinsKitGuardian { get; set; }

        [JsonProperty("bow_shots_kit_guardian")]
        public long BowShotsKitGuardian { get; set; }

        [JsonProperty("most_kills_game_kit_guardian")]
        public long MostKillsGameKitGuardian { get; set; }

        [JsonProperty("void_kills_kit_guardian")]
        public long VoidKillsKitGuardian { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("team_war_wins")]
        public long TeamWarWins { get; set; }

        [JsonProperty("kills_monthly_a")]
        public long KillsMonthlyA { get; set; }

        [JsonProperty("bow_hits_kit_guardian")]
        public long BowHitsKitGuardian { get; set; }

        [JsonProperty("kills_team_war")]
        public long KillsTeamWar { get; set; }

        [JsonProperty("kills_weekly_a")]
        public long KillsWeeklyA { get; set; }

        [JsonProperty("spawn_at_witch")]
        public long SpawnAtWitch { get; set; }

        [JsonProperty("losses_team_war")]
        public long LossesTeamWar { get; set; }

        [JsonProperty("mobs_killed_kit_guardian")]
        public long MobsKilledKitGuardian { get; set; }

        [JsonProperty("deaths_kit_guardian")]
        public long DeathsKitGuardian { get; set; }

        [JsonProperty("mobs_killed")]
        public long MobsKilled { get; set; }

        [JsonProperty("deaths_team_war")]
        public long DeathsTeamWar { get; set; }

        [JsonProperty("perk_endless_quiver")]
        public long PerkEndlessQuiver { get; set; }

        [JsonProperty("perk_endless_quiver_new")]
        public bool PerkEndlessQuiverNew { get; set; }

        [JsonProperty("perk_endless_quiver_duplicates")]
        public long PerkEndlessQuiverDuplicates { get; set; }

        [JsonProperty("perk_marksman_duplicates")]
        public long PerkMarksmanDuplicates { get; set; }

        [JsonProperty("playstreak")]
        public long Playstreak { get; set; }

        [JsonProperty("quits")]
        public long Quits { get; set; }

        [JsonProperty("assists_kit_swordsman")]
        public long AssistsKitSwordsman { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("enderchests_opened_kit_swordsman")]
        public long EnderchestsOpenedKitSwordsman { get; set; }

        [JsonProperty("mobs_killed_kit_swordsman")]
        public long MobsKilledKitSwordsman { get; set; }

        [JsonProperty("fastest_win_team_war_kit_swordsman")]
        public long FastestWinTeamWarKitSwordsman { get; set; }

        [JsonProperty("longest_bow_kill")]
        public long LongestBowKill { get; set; }

        [JsonProperty("longest_bow_kill_kit_swordsman")]
        public long LongestBowKillKitSwordsman { get; set; }

        [JsonProperty("bow_kills")]
        public long BowKills { get; set; }

        [JsonProperty("bow_kills_kit_swordsman")]
        public long BowKillsKitSwordsman { get; set; }

        [JsonProperty("team_war_wins_kit_swordsman")]
        public long TeamWarWinsKitSwordsman { get; set; }

        [JsonProperty("perk_arrow_deflection")]
        public long PerkArrowDeflection { get; set; }

        [JsonProperty("perk_fruit_finder_new")]
        public bool PerkFruitFinderNew { get; set; }

        [JsonProperty("perk_arrow_deflection_new")]
        public bool PerkArrowDeflectionNew { get; set; }

        [JsonProperty("perk_fruit_finder")]
        public long PerkFruitFinder { get; set; }

        [JsonProperty("kit_guardian_minor")]
        public long KitGuardianMinor { get; set; }

        [JsonProperty("assists_kit_guardian")]
        public long AssistsKitGuardian { get; set; }

        [JsonProperty("perk_creeper_new")]
        public bool PerkCreeperNew { get; set; }

        [JsonProperty("perk_chicken_bow")]
        public long PerkChickenBow { get; set; }

        [JsonProperty("perk_creeper")]
        public long PerkCreeper { get; set; }

        [JsonProperty("perk_chicken_bow_new")]
        public bool PerkChickenBowNew { get; set; }

        [JsonProperty("perk_fruit_finder_duplicates")]
        public long PerkFruitFinderDuplicates { get; set; }

        [JsonProperty("perk_pearl_absorption_new")]
        public bool PerkPearlAbsorptionNew { get; set; }

        [JsonProperty("perk_pearl_absorption")]
        public long PerkPearlAbsorption { get; set; }

        [JsonProperty("perk_pacify")]
        public long PerkPacify { get; set; }

        [JsonProperty("perk_pacify_new")]
        public bool PerkPacifyNew { get; set; }

        [JsonProperty("kills_mega")]
        public long KillsMega { get; set; }

        [JsonProperty("losses_mega")]
        public long LossesMega { get; set; }

        [JsonProperty("deaths_mega")]
        public long DeathsMega { get; set; }

        [JsonProperty("fastest_win_mega_kit_guardian")]
        public long FastestWinMegaKitGuardian { get; set; }

        [JsonProperty("fastest_win_mega")]
        public long FastestWinMega { get; set; }

        [JsonProperty("wins_mega")]
        public long WinsMega { get; set; }

        [JsonProperty("mega_wins")]
        public long MegaWins { get; set; }

        [JsonProperty("mega_wins_kit_guardian")]
        public long MegaWinsKitGuardian { get; set; }

        [JsonProperty("perk_invisibility")]
        public long PerkInvisibility { get; set; }

        [JsonProperty("perk_invisibility_new")]
        public bool PerkInvisibilityNew { get; set; }

        [JsonProperty("perk_creeper_duplicates")]
        public long PerkCreeperDuplicates { get; set; }

        [JsonProperty("perk_sugar_rush")]
        public long PerkSugarRush { get; set; }

        [JsonProperty("perk_sugar_rush_new")]
        public bool PerkSugarRushNew { get; set; }

        [JsonProperty("perk_invisibility_duplicates")]
        public long PerkInvisibilityDuplicates { get; set; }

        [JsonProperty("perk_pearl_absorption_duplicates")]
        public long PerkPearlAbsorptionDuplicates { get; set; }

        [JsonProperty("perk_pacify_duplicates")]
        public long PerkPacifyDuplicates { get; set; }

        [JsonProperty("class_0")]
        public string Class0 { get; set; }

        [JsonProperty("perk_blast_protection_new")]
        public bool PerkBlastProtectionNew { get; set; }

        [JsonProperty("perk_blast_protection")]
        public long PerkBlastProtection { get; set; }

        [JsonProperty("perk_void_magnet_duplicates")]
        public long PerkVoidMagnetDuplicates { get; set; }

        [JsonProperty("perk_alchemy")]
        public long PerkAlchemy { get; set; }

        [JsonProperty("perk_resistant_duplicates")]
        public long PerkResistantDuplicates { get; set; }

        [JsonProperty("perk_alchemy_new")]
        public bool PerkAlchemyNew { get; set; }

        [JsonProperty("perk_marksman")]
        public long PerkMarksman { get; set; }

        [JsonProperty("perk_nutritious")]
        public long PerkNutritious { get; set; }

        [JsonProperty("perk_explosive_bow")]
        public long PerkExplosiveBow { get; set; }

        [JsonProperty("perk_explosive_bow_new")]
        public bool PerkExplosiveBowNew { get; set; }

        [JsonProperty("perk_nutritious_new")]
        public bool PerkNutritiousNew { get; set; }

        [JsonProperty("perk_regeneration_duplicates")]
        public long PerkRegenerationDuplicates { get; set; }

        [JsonProperty("mob_kills_kit_guardian")]
        public long MobKillsKitGuardian { get; set; }

        [JsonProperty("mob_kills")]
        public long MobKills { get; set; }

        [JsonProperty("perk_damage_potion")]
        public long PerkDamagePotion { get; set; }

        [JsonProperty("perk_arrow_deflection_duplicates")]
        public long PerkArrowDeflectionDuplicates { get; set; }

        [JsonProperty("perk_regeneration")]
        public long PerkRegeneration { get; set; }

        [JsonProperty("perk_damage_potion_new")]
        public bool PerkDamagePotionNew { get; set; }

        [JsonProperty("perk_hit_and_run_duplicates")]
        public long PerkHitAndRunDuplicates { get; set; }

        [JsonProperty("perk_sharpened_sword")]
        public long PerkSharpenedSword { get; set; }

        [JsonProperty("perk_sharpened_sword_new")]
        public bool PerkSharpenedSwordNew { get; set; }

        [JsonProperty("longest_bow_kill_kit_guardian")]
        public long LongestBowKillKitGuardian { get; set; }

        [JsonProperty("bow_kills_kit_guardian")]
        public long BowKillsKitGuardian { get; set; }

        [JsonProperty("fastest_win_solo")]
        public long FastestWinSolo { get; set; }

        [JsonProperty("fastest_win_solo_kit_guardian")]
        public long FastestWinSoloKitGuardian { get; set; }

        [JsonProperty("solo_wins_kit_guardian")]
        public long SoloWinsKitGuardian { get; set; }

        [JsonProperty("solo_wins")]
        public long SoloWins { get; set; }

        [JsonProperty("wins_solo")]
        public long WinsSolo { get; set; }

        [JsonProperty("perk_damage_potion_duplicates")]
        public long PerkDamagePotionDuplicates { get; set; }

        [JsonProperty("perk_winged_boots")]
        public long PerkWingedBoots { get; set; }

        [JsonProperty("perk_winged_boots_new")]
        public bool PerkWingedBootsNew { get; set; }

        [JsonProperty("perk_snow_golem_new")]
        public bool PerkSnowGolemNew { get; set; }

        [JsonProperty("perk_snow_golem")]
        public long PerkSnowGolem { get; set; }

        [JsonProperty("perk_hearty_start_duplicates")]
        public long PerkHeartyStartDuplicates { get; set; }

        [JsonProperty("perk_guardian_new")]
        public bool PerkGuardianNew { get; set; }

        [JsonProperty("perk_guardian")]
        public long PerkGuardian { get; set; }

        [JsonProperty("perk_blazing_arrows")]
        public long PerkBlazingArrows { get; set; }

        [JsonProperty("perk_resistant")]
        public long PerkResistant { get; set; }

        [JsonProperty("perk_blazing_arrows_new")]
        public bool PerkBlazingArrowsNew { get; set; }

        [JsonProperty("perk_void_warranty")]
        public long PerkVoidWarranty { get; set; }

        [JsonProperty("perk_void_warranty_new")]
        public bool PerkVoidWarrantyNew { get; set; }

        [JsonProperty("perk_sugar_rush_duplicates")]
        public long PerkSugarRushDuplicates { get; set; }

        [JsonProperty("perk_snow_golem_duplicates")]
        public long PerkSnowGolemDuplicates { get; set; }

        [JsonProperty("perk_blast_protection_duplicates")]
        public long PerkBlastProtectionDuplicates { get; set; }

        [JsonProperty("perk_hit_and_run")]
        public long PerkHitAndRun { get; set; }

        [JsonProperty("perk_hearty_start")]
        public long PerkHeartyStart { get; set; }

        [JsonProperty("perk_guardian_duplicates")]
        public long PerkGuardianDuplicates { get; set; }

        [JsonProperty("perk_skeleton_jockey")]
        public long PerkSkeletonJockey { get; set; }

        [JsonProperty("perk_skeleton_jockey_new")]
        public bool PerkSkeletonJockeyNew { get; set; }

        [JsonProperty("perk_witch_new")]
        public bool PerkWitchNew { get; set; }

        [JsonProperty("perk_witch")]
        public long PerkWitch { get; set; }

        [JsonProperty("perk_explosive_bow_duplicates")]
        public long PerkExplosiveBowDuplicates { get; set; }

        [JsonProperty("perk_nutritious_duplicates")]
        public long PerkNutritiousDuplicates { get; set; }

        [JsonProperty("perk_skeleton_jockey_duplicates")]
        public long PerkSkeletonJockeyDuplicates { get; set; }

        [JsonProperty("perk_iron_golem_new")]
        public bool PerkIronGolemNew { get; set; }

        [JsonProperty("perk_iron_golem")]
        public long PerkIronGolem { get; set; }

        [JsonProperty("perk_supply_drop_new")]
        public bool PerkSupplyDropNew { get; set; }

        [JsonProperty("perk_supply_drop")]
        public long PerkSupplyDrop { get; set; }

        [JsonProperty("perk_chicken_bow_duplicates")]
        public long PerkChickenBowDuplicates { get; set; }

        [JsonProperty("perk_iron_golem_duplicates")]
        public long PerkIronGolemDuplicates { get; set; }

        [JsonProperty("perk_honed_bow")]
        public long PerkHonedBow { get; set; }

        [JsonProperty("perk_honed_bow_new")]
        public bool PerkHonedBowNew { get; set; }

        [JsonProperty("perk_supply_drop_duplicates")]
        public long PerkSupplyDropDuplicates { get; set; }

        [JsonProperty("perk_alchemy_duplicates")]
        public long PerkAlchemyDuplicates { get; set; }

        [JsonProperty("perk_witch_duplicates")]
        public long PerkWitchDuplicates { get; set; }

        [JsonProperty("perk_sharpened_sword_duplicates")]
        public long PerkSharpenedSwordDuplicates { get; set; }

        [JsonProperty("fastest_win_doubles")]
        public long FastestWinDoubles { get; set; }

        [JsonProperty("fastest_win_doubles_kit_guardian")]
        public long FastestWinDoublesKitGuardian { get; set; }

        [JsonProperty("doubles_wins_kit_guardian")]
        public long DoublesWinsKitGuardian { get; set; }

        [JsonProperty("kills_doubles")]
        public long KillsDoubles { get; set; }

        [JsonProperty("doubles_wins")]
        public long DoublesWins { get; set; }

        [JsonProperty("wins_doubles")]
        public long WinsDoubles { get; set; }

        [JsonProperty("perk_rampage_duplicates")]
        public long PerkRampageDuplicates { get; set; }

        [JsonProperty("perk_headstart_new")]
        public bool PerkHeadstartNew { get; set; }

        [JsonProperty("perk_headstart")]
        public long PerkHeadstart { get; set; }

        [JsonProperty("kit_archer_minor")]
        public long KitArcherMinor { get; set; }

        [JsonProperty("class_1")]
        public string Class1 { get; set; }

        [JsonProperty("perk_honed_bow_duplicates")]
        public long PerkHonedBowDuplicates { get; set; }

        [JsonProperty("longest_bow_shot_kit_archer")]
        public long LongestBowShotKitArcher { get; set; }

        [JsonProperty("games_played_kit_archer")]
        public long GamesPlayedKitArcher { get; set; }

        [JsonProperty("bow_hits_kit_archer")]
        public long BowHitsKitArcher { get; set; }

        [JsonProperty("kills_kit_archer")]
        public long KillsKitArcher { get; set; }

        [JsonProperty("melee_kills_kit_archer")]
        public long MeleeKillsKitArcher { get; set; }

        [JsonProperty("most_kills_game_kit_archer")]
        public long MostKillsGameKitArcher { get; set; }

        [JsonProperty("bow_shots_kit_archer")]
        public long BowShotsKitArcher { get; set; }

        [JsonProperty("deaths_kit_archer")]
        public long DeathsKitArcher { get; set; }

        [JsonProperty("class_2")]
        public string Class2 { get; set; }

        [JsonProperty("void_kills_kit_archer")]
        public long VoidKillsKitArcher { get; set; }

        [JsonProperty("perk_tripleshot")]
        public long PerkTripleshot { get; set; }

        [JsonProperty("perk_tripleshot_new")]
        public bool PerkTripleshotNew { get; set; }

        [JsonProperty("assists_kit_archer")]
        public long AssistsKitArcher { get; set; }

        [JsonProperty("fastest_win_solo_kit_archer")]
        public long FastestWinSoloKitArcher { get; set; }

        [JsonProperty("solo_wins_kit_archer")]
        public long SoloWinsKitArcher { get; set; }

        [JsonProperty("mob_kills_kit_archer")]
        public long MobKillsKitArcher { get; set; }

        [JsonProperty("mobs_killed_kit_archer")]
        public long MobsKilledKitArcher { get; set; }

        [JsonProperty("perk_enderman")]
        public long PerkEnderman { get; set; }

        [JsonProperty("perk_enderman_new")]
        public bool PerkEndermanNew { get; set; }

        [JsonProperty("perk_void_warranty_duplicates")]
        public long PerkVoidWarrantyDuplicates { get; set; }

        [JsonProperty("perk_blazing_arrows_duplicates")]
        public long PerkBlazingArrowsDuplicates { get; set; }

        [JsonProperty("mobs_spawned_kit_guardian")]
        public long MobsSpawnedKitGuardian { get; set; }

        [JsonProperty("kills_perk_resistant")]
        public long KillsPerkResistant { get; set; }

        [JsonProperty("kills_perk_sharpened_sword")]
        public long KillsPerkSharpenedSword { get; set; }

        [JsonProperty("losses_perk_resistant")]
        public long LossesPerkResistant { get; set; }

        [JsonProperty("losses_perk_sharpened_sword")]
        public long LossesPerkSharpenedSword { get; set; }

        [JsonProperty("deaths_perk_sharpened_sword")]
        public long DeathsPerkSharpenedSword { get; set; }

        [JsonProperty("kills_perk_iron_golem")]
        public long KillsPerkIronGolem { get; set; }

        [JsonProperty("deaths_perk_resistant")]
        public long DeathsPerkResistant { get; set; }

        [JsonProperty("mobs_spawned")]
        public long MobsSpawned { get; set; }

        [JsonProperty("deaths_perk_iron_golem")]
        public long DeathsPerkIronGolem { get; set; }

        [JsonProperty("losses_perk_iron_golem")]
        public long LossesPerkIronGolem { get; set; }

        [JsonProperty("wins_perk_resistant")]
        public long WinsPerkResistant { get; set; }

        [JsonProperty("wins_perk_sharpened_sword")]
        public long WinsPerkSharpenedSword { get; set; }

        [JsonProperty("wins_perk_iron_golem")]
        public long WinsPerkIronGolem { get; set; }

        [JsonProperty("perk_bat_shield_new")]
        public bool PerkBatShieldNew { get; set; }

        [JsonProperty("perk_bat_shield")]
        public long PerkBatShield { get; set; }

        [JsonProperty("perk_bat_shield_duplicates")]
        public long PerkBatShieldDuplicates { get; set; }

        [JsonProperty("perk_elven_archer_new")]
        public bool PerkElvenArcherNew { get; set; }

        [JsonProperty("perk_elven_archer")]
        public long PerkElvenArcher { get; set; }

        [JsonProperty("perk_elven_archer_duplicates")]
        public long PerkElvenArcherDuplicates { get; set; }

        [JsonProperty("perk_rampage")]
        public long PerkRampage { get; set; }

        [JsonProperty("perk_winged_boots_duplicates")]
        public long PerkWingedBootsDuplicates { get; set; }

        [JsonProperty("fastest_win_doubles_kit_archer")]
        public long FastestWinDoublesKitArcher { get; set; }

        [JsonProperty("kills_perk_honed_bow")]
        public long KillsPerkHonedBow { get; set; }

        [JsonProperty("wins_perk_explosive_bow")]
        public long WinsPerkExplosiveBow { get; set; }

        [JsonProperty("doubles_wins_kit_archer")]
        public long DoublesWinsKitArcher { get; set; }

        [JsonProperty("deaths_perk_void_magnet")]
        public long DeathsPerkVoidMagnet { get; set; }

        [JsonProperty("kills_perk_explosive_bow")]
        public long KillsPerkExplosiveBow { get; set; }

        [JsonProperty("deaths_perk_explosive_bow")]
        public long DeathsPerkExplosiveBow { get; set; }

        [JsonProperty("wins_perk_honed_bow")]
        public long WinsPerkHonedBow { get; set; }

        [JsonProperty("wins_perk_void_magnet")]
        public long WinsPerkVoidMagnet { get; set; }

        [JsonProperty("kills_perk_void_magnet")]
        public long KillsPerkVoidMagnet { get; set; }

        [JsonProperty("deaths_perk_honed_bow")]
        public long DeathsPerkHonedBow { get; set; }

        [JsonProperty("longest_bow_kill_kit_archer")]
        public long LongestBowKillKitArcher { get; set; }

        [JsonProperty("mobs_spawned_kit_archer")]
        public long MobsSpawnedKitArcher { get; set; }

        [JsonProperty("bow_kills_kit_archer")]
        public long BowKillsKitArcher { get; set; }

        [JsonProperty("enderchests_opened_kit_archer")]
        public long EnderchestsOpenedKitArcher { get; set; }

        [JsonProperty("perk_bigger_bangs")]
        public long PerkBiggerBangs { get; set; }

        [JsonProperty("perk_flower_power_new")]
        public bool PerkFlowerPowerNew { get; set; }

        [JsonProperty("perk_flower_power")]
        public long PerkFlowerPower { get; set; }

        [JsonProperty("perk_bigger_bangs_new")]
        public bool PerkBiggerBangsNew { get; set; }

        [JsonProperty("losses_perk_honed_bow")]
        public long LossesPerkHonedBow { get; set; }

        [JsonProperty("losses_perk_void_magnet")]
        public long LossesPerkVoidMagnet { get; set; }

        [JsonProperty("losses_perk_explosive_bow")]
        public long LossesPerkExplosiveBow { get; set; }

        [JsonProperty("perk_flower_power_duplicates")]
        public long PerkFlowerPowerDuplicates { get; set; }

        [JsonProperty("perk_archer_challenge")]
        public long PerkArcherChallenge { get; set; }

        [JsonProperty("perk_bigger_bangs_duplicates")]
        public long PerkBiggerBangsDuplicates { get; set; }

        [JsonProperty("perk_archer_challenge_new")]
        public bool PerkArcherChallengeNew { get; set; }

        [JsonProperty("cute_pants_found")]
        public long CutePantsFound { get; set; }

        [JsonProperty("cute_pants_found_kit_archer")]
        public long CutePantsFoundKitArcher { get; set; }

        [JsonProperty("deaths_perk_rampage")]
        public long DeathsPerkRampage { get; set; }

        [JsonProperty("losses_perk_rampage")]
        public long LossesPerkRampage { get; set; }

        [JsonProperty("kills_perk_rampage")]
        public long KillsPerkRampage { get; set; }

        [JsonProperty("perk_uhc_challenge_new")]
        public bool PerkUhcChallengeNew { get; set; }

        [JsonProperty("perk_uhc_challenge")]
        public long PerkUhcChallenge { get; set; }

        [JsonProperty("wins_perk_rampage")]
        public long WinsPerkRampage { get; set; }

        [JsonProperty("perk_nuclear_solution_new")]
        public bool PerkNuclearSolutionNew { get; set; }

        [JsonProperty("perk_nuclear_solution")]
        public long PerkNuclearSolution { get; set; }

        [JsonProperty("perk_nuclear_solution_duplicates")]
        public long PerkNuclearSolutionDuplicates { get; set; }

        [JsonProperty("deaths_perk_bigger_bangs")]
        public long DeathsPerkBiggerBangs { get; set; }

        [JsonProperty("deaths_perk_nuclear_solution")]
        public long DeathsPerkNuclearSolution { get; set; }

        [JsonProperty("deaths_perk_invisibility")]
        public long DeathsPerkInvisibility { get; set; }

        [JsonProperty("losses_perk_invisibility")]
        public long LossesPerkInvisibility { get; set; }

        [JsonProperty("losses_perk_nuclear_solution")]
        public long LossesPerkNuclearSolution { get; set; }

        [JsonProperty("losses_perk_bigger_bangs")]
        public long LossesPerkBiggerBangs { get; set; }

        [JsonProperty("cute_pants_found_kit_guardian")]
        public long CutePantsFoundKitGuardian { get; set; }

        [JsonProperty("kills_perk_nuclear_solution")]
        public long KillsPerkNuclearSolution { get; set; }

        [JsonProperty("kills_perk_bigger_bangs")]
        public long KillsPerkBiggerBangs { get; set; }

        [JsonProperty("kills_perk_invisibility")]
        public long KillsPerkInvisibility { get; set; }

        [JsonProperty("perk_headstart_duplicates")]
        public long PerkHeadstartDuplicates { get; set; }

        [JsonProperty("perk_mushroom_aura_new")]
        public bool PerkMushroomAuraNew { get; set; }

        [JsonProperty("perk_mushroom_aura")]
        public long PerkMushroomAura { get; set; }

        [JsonProperty("perk_tripleshot_duplicates")]
        public long PerkTripleshotDuplicates { get; set; }

        [JsonProperty("perk_enderman_duplicates")]
        public long PerkEndermanDuplicates { get; set; }

        [JsonProperty("perk_mushroom_aura_duplicates")]
        public long PerkMushroomAuraDuplicates { get; set; }

        [JsonProperty("losses_perk_arrow_deflection")]
        public long LossesPerkArrowDeflection { get; set; }

        [JsonProperty("deaths_perk_arrow_deflection")]
        public long DeathsPerkArrowDeflection { get; set; }

        [JsonProperty("kills_perk_arrow_deflection")]
        public long KillsPerkArrowDeflection { get; set; }

        [JsonProperty("wins_perk_arrow_deflection")]
        public long WinsPerkArrowDeflection { get; set; }

        [JsonProperty("kills_solo_perk_archer_challenge")]
        public long KillsSoloPerkArcherChallenge { get; set; }

        [JsonProperty("solo_wins_perk_archer_challenge")]
        public long SoloWinsPerkArcherChallenge { get; set; }

        [JsonProperty("wins_perk_nuclear_solution")]
        public long WinsPerkNuclearSolution { get; set; }

        [JsonProperty("wins_perk_bigger_bangs")]
        public long WinsPerkBiggerBangs { get; set; }

        [JsonProperty("fastest_win_team_war_kit_archer")]
        public long FastestWinTeamWarKitArcher { get; set; }

        [JsonProperty("team_war_wins_kit_archer")]
        public long TeamWarWinsKitArcher { get; set; }
    }
}