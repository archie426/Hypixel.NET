using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SkyClash
    {
        #region general
        [JsonProperty("card_packs")]
        public int CardPacks { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("fastest_win_solo")]
        public int FastestWinSolo { get; set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; set; }

        [JsonProperty("void_kills")]
        public int VoidKills { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("most_kills_game")]
        public int MostKillsGame { get; set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; set; }

        [JsonProperty("kills_solo")]
        public int KillsSolo { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("solo_wins")]
        public int SoloWins { get; set; }

        [JsonProperty("wins_solo")]
        public int WinsSolo { get; set; }

        [JsonProperty("play_streak")]
        public int PlayStreak { get; set; }

        [JsonProperty("killstreak")]
        public int Killstreak { get; set; }

        [JsonProperty("highestKillstreak")]
        public int HighestKillstreak { get; set; }

        [JsonProperty("playstreak")]
        public int Playstreak { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("deaths_solo")]
        public int DeathsSolo { get; set; }

        [JsonProperty("quits")]
        public int Quits { get; set; }

        [JsonProperty("losses_solo")]
        public int LossesSolo { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("mobs_killed")]
        public int MobsKilled { get; set; }

        [JsonProperty("longest_bow_shot")]
        public int LongestBowShot { get; set; }

        [JsonProperty("bow_hits")]
        public int BowHits { get; set; }

        [JsonProperty("bow_shots")]
        public int BowShots { get; set; }

        [JsonProperty("losses_doubles")]
        public int LossesDoubles { get; set; }

        [JsonProperty("deaths_doubles")]
        public int DeathsDoubles { get; set; }

        [JsonProperty("kills_doubles")]
        public int KillsDoubles { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("enderchests_opened")]
        public int EnderchestsOpened { get; set; }

        [JsonProperty("mob_kills")]
        public int MobKills { get; set; }

        [JsonProperty("longest_bow_kill")]
        public int LongestBowKill { get; set; }

        [JsonProperty("bow_kills")]
        public int BowKills { get; set; }

        [JsonProperty("fastest_win_team_war")]
        public int FastestWinTeamWar { get; set; }

        [JsonProperty("team_war_wins")]
        public int TeamWarWins { get; set; }

        [JsonProperty("kills_team_war")]
        public int KillsTeamWar { get; set; }

        [JsonProperty("wins_team_war")]
        public int WinsTeamWar { get; set; }

        [JsonProperty("losses_team_war")]
        public int LossesTeamWar { get; set; }

        [JsonProperty("deaths_team_war")]
        public int DeathsTeamWar { get; set; }

        [JsonProperty("fastest_win_doubles")]
        public int FastestWinDoubles { get; set; }

        [JsonProperty("doubles_wins")]
        public int DoublesWins { get; set; }

        [JsonProperty("wins_doubles")]
        public int WinsDoubles { get; set; }
        #endregion

        #region perks
        [JsonProperty("public bool perk_damage_potion_new")]
        public bool PerkDamagePotionNew { get; set; }

        [JsonProperty("perk_honed_bow")]
        public int PerkHonedBow { get; set; }

        [JsonProperty("perk_void_magnet")]
        public int PerkVoidMagnet { get; set; }

        [JsonProperty("perk_damage_potion")]
        public int PerkDamagePotion { get; set; }

        [JsonProperty("perk_blast_protection")]
        public int PerkBlastProtection { get; set; }

        [JsonProperty("perk_void_warranty")]
        public int PerkVoidWarranty { get; set; }

        [JsonProperty("perk_fruit_finder")]
        public int PerkFruitFinder { get; set; }

        [JsonProperty("perk_pearl_absorption")]
        public int PerkPearlAbsorption { get; set; }

        [JsonProperty("perk_creeper")]
        public int PerkCreeper { get; set; }

        [JsonProperty("perk_blazing_arrows")]
        public int PerkBlazingArrows { get; set; }

        [JsonProperty("perk_regeneration")]
        public int PerkRegeneration { get; set; }

        [JsonProperty("perk_tripleshot")]
        public int PerkTripleshot { get; set; }

        [JsonProperty("perk_invisibility")]
        public int PerkInvisibility { get; set; }

        [JsonProperty("perk_sugar_rush")]
        public int PerkSugarRush { get; set; }

        [JsonProperty("perk_alchemy")]
        public int PerkAlchemy { get; set; }

        [JsonProperty("perk_energy_drink")]
        public int PerkEnergyDrink { get; set; }

        [JsonProperty("perk_witch")]
        public int PerkWitch { get; set; }

        [JsonProperty("perk_sharpened_sword")]
        public int PerkSharpenedSword { get; set; }

        [JsonProperty("perk_hit_and_run")]
        public int PerkHitAndRun { get; set; }

        [JsonProperty("perk_hearty_start")]
        public int PerkHeartyStart { get; set; }

        [JsonProperty("perk_pacify")]
        public int PerkPacify { get; set; }

        [JsonProperty("perk_skeleton_jockey")]
        public int PerkSkeletonJockey { get; set; }

        [JsonProperty("perk_resistant")]
        public int PerkResistant { get; set; }

        [JsonProperty("perk_endless_quiver")]
        public int PerkEndlessQuiver { get; set; }

        [JsonProperty("perk_marksman")]
        public int PerkMarksman { get; set; }

        [JsonProperty("perk_iron_golem")]
        public int PerkIronGolem { get; set; }

        [JsonProperty("perk_supply_drop")]
        public int PerkSupplyDrop { get; set; }

        [JsonProperty("perk_nutritious")]
        public int PerkNutritious { get; set; }

        [JsonProperty("perk_arrow_deflection")]
        public int PerkArrowDeflection { get; set; }

        [JsonProperty("perk_chicken_bow")]
        public int PerkChickenBow { get; set; }

        [JsonProperty("perk_enderman")]
        public int PerkEnderman { get; set; }

        [JsonProperty("perk_guardian")]
        public int PerkGuardian { get; set; }

        [JsonProperty("perk_headstart")]
        public int PerkHeadstart { get; set; }

        [JsonProperty("perk_snow_golem")]
        public int PerkSnowGolem { get; set; }

        [JsonProperty("perk_explosive_bow")]
        public int PerkExplosiveBow { get; set; }

        [JsonProperty("perk_winged_boots")]
        public int PerkWingedBoots { get; set; }

        [JsonProperty("perk_rampage")]
        public int PerkRampage { get; set; }

        [JsonProperty("kills_perk_resistant")]
        public int KillsPerkResistant { get; set; }

        [JsonProperty("losses_perk_resistant")]
        public int LossesPerkResistant { get; set; }

        [JsonProperty("deaths_perk_void_warranty")]
        public int DeathsPerkVoidWarranty { get; set; }

        [JsonProperty("deaths_perk_resistant")]
        public int DeathsPerkResistant { get; set; }

        [JsonProperty("losses_perk_void_warranty")]
        public int LossesPerkVoidWarranty { get; set; }

        [JsonProperty("deaths_perk_regeneration")]
        public int DeathsPerkRegeneration { get; set; }

        [JsonProperty("kills_perk_regeneration")]
        public int KillsPerkRegeneration { get; set; }

        [JsonProperty("losses_perk_regeneration")]
        public int LossesPerkRegeneration { get; set; }

        [JsonProperty("kills_perk_void_warranty")]
        public int KillsPerkVoidWarranty { get; set; }

        [JsonProperty("wins_perk_resistant")]
        public int WinsPerkResistant { get; set; }

        [JsonProperty("wins_perk_void_warranty")]
        public int WinsPerkVoidWarranty { get; set; }

        [JsonProperty("wins_perk_regeneration")]
        public int WinsPerkRegeneration { get; set; }

        [JsonProperty("perk_bigger_bangs")]
        public int PerkBiggerBangs { get; set; }

        [JsonProperty("perk_bat_shield")]
        public int PerkBatShield { get; set; }

        [JsonProperty("perk_elven_archer")]
        public int PerkElvenArcher { get; set; }

        [JsonProperty("perk_flower_power")]
        public int PerkFlowerPower { get; set; }

        [JsonProperty("perk_uhc_challenge")]
        public int PerkUhcChallenge { get; set; }

        [JsonProperty("perk_mushroom_aura")]
        public int PerkMushroomAura { get; set; }

        [JsonProperty("perk_nuclear_solution")]
        public int PerkNuclearSolution { get; set; }

        [JsonProperty("deaths_perk_headstart")]
        public int DeathsPerkHeadstart { get; set; }

        [JsonProperty("losses_perk_void_magnet")]
        public int LossesPerkVoidMagnet { get; set; }

        [JsonProperty("deaths_perk_void_magnet")]
        public int DeathsPerkVoidMagnet { get; set; }

        [JsonProperty("losses_perk_mushroom_aura")]
        public int LossesPerkMushroomAura { get; set; }

        [JsonProperty("kills_perk_headstart")]
        public int KillsPerkHeadstart { get; set; }

        [JsonProperty("losses_perk_headstart")]
        public int LossesPerkHeadstart { get; set; }

        [JsonProperty("kills_perk_mushroom_aura")]
        public int KillsPerkMushroomAura { get; set; }

        [JsonProperty("deaths_perk_mushroom_aura")]
        public int DeathsPerkMushroomAura { get; set; }

        [JsonProperty("kills_perk_void_magnet")]
        public int KillsPerkVoidMagnet { get; set; }

        [JsonProperty("solo_wins_perk_uhc_challenge")]
        public int SoloWinsPerkUhcChallenge { get; set; }

        [JsonProperty("wins_perk_hit_and_run")]
        public int WinsPerkHitAndRun { get; set; }

        [JsonProperty("kills_perk_sharpened_sword")]
        public int KillsPerkSharpenedSword { get; set; }

        [JsonProperty("wins_perk_sharpened_sword")]
        public int WinsPerkSharpenedSword { get; set; }

        [JsonProperty("kills_solo_perk_uhc_challenge")]
        public int KillsSoloPerkUhcChallenge { get; set; }

        [JsonProperty("kills_perk_hit_and_run")]
        public int KillsPerkHitAndRun { get; set; }

        [JsonProperty("kills_perk_winged_boots")]
        public int KillsPerkWingedBoots { get; set; }

        [JsonProperty("kills_perk_endless_quiver")]
        public int KillsPerkEndlessQuiver { get; set; }

        [JsonProperty("deaths_perk_endless_quiver")]
        public int DeathsPerkEndlessQuiver { get; set; }

        [JsonProperty("deaths_perk_winged_boots")]
        public int DeathsPerkWingedBoots { get; set; }

        [JsonProperty("losses_perk_endless_quiver")]
        public int LossesPerkEndlessQuiver { get; set; }

        [JsonProperty("losses_perk_winged_boots")]
        public int LossesPerkWingedBoots { get; set; }

        [JsonProperty("kills_perk_pacify")]
        public int KillsPerkPacify { get; set; }

        [JsonProperty("wins_perk_pacify")]
        public int WinsPerkPacify { get; set; }

        [JsonProperty("wins_perk_headstart")]
        public int WinsPerkHeadstart { get; set; }

        [JsonProperty("losses_perk_pacify")]
        public int LossesPerkPacify { get; set; }

        [JsonProperty("deaths_perk_pacify")]
        public int DeathsPerkPacify { get; set; }

        [JsonProperty("wins_perk_mushroom_aura")]
        public int WinsPerkMushroomAura { get; set; }

        [JsonProperty("wins_perk_void_magnet")]
        public int WinsPerkVoidMagnet { get; set; }

        [JsonProperty("kills_solo_perk_no_chest_challenge")]
        public int KillsSoloPerkNoChestChallenge { get; set; }

        [JsonProperty("solo_wins_perk_no_chest_challenge")]
        public int SoloWinsPerkNoChestChallenge { get; set; }

        [JsonProperty("kills_perk_damage_potion")]
        public int KillsPerkDamagePotion { get; set; }

        [JsonProperty("wins_perk_witch")]
        public int WinsPerkWitch { get; set; }

        [JsonProperty("wins_perk_damage_potion")]
        public int WinsPerkDamagePotion { get; set; }

        [JsonProperty("kills_perk_witch")]
        public int KillsPerkWitch { get; set; }

        [JsonProperty("losses_perk_witch")]
        public int LossesPerkWitch { get; set; }

        [JsonProperty("deaths_perk_damage_potion")]
        public int DeathsPerkDamagePotion { get; set; }

        [JsonProperty("losses_perk_damage_potion")]
        public int LossesPerkDamagePotion { get; set; }

        [JsonProperty("losses_perk_sharpened_sword")]
        public int LossesPerkSharpenedSword { get; set; }

        [JsonProperty("deaths_perk_sharpened_sword")]
        public int DeathsPerkSharpenedSword { get; set; }

        [JsonProperty("deaths_perk_witch")]
        public int DeathsPerkWitch { get; set; }

        [JsonProperty("deaths_perk_hearty_start")]
        public int DeathsPerkHeartyStart { get; set; }

        [JsonProperty("deaths_perk_tripleshot")]
        public int DeathsPerkTripleshot { get; set; }

        [JsonProperty("losses_perk_tripleshot")]
        public int LossesPerkTripleshot { get; set; }

        [JsonProperty("kills_perk_hearty_start")]
        public int KillsPerkHeartyStart { get; set; }

        [JsonProperty("losses_perk_hearty_start")]
        public int LossesPerkHeartyStart { get; set; }

        [JsonProperty("kills_perk_tripleshot")]
        public int KillsPerkTripleshot { get; set; }

        [JsonProperty("deaths_perk_invisibility")]
        public int DeathsPerkInvisibility { get; set; }

        [JsonProperty("losses_perk_fruit_finder")]
        public int LossesPerkFruitFinder { get; set; }

        [JsonProperty("deaths_perk_chicken_bow")]
        public int DeathsPerkChickenBow { get; set; }

        [JsonProperty("kills_perk_fruit_finder")]
        public int KillsPerkFruitFinder { get; set; }

        [JsonProperty("deaths_perk_fruit_finder")]
        public int DeathsPerkFruitFinder { get; set; }

        [JsonProperty("losses_perk_chicken_bow")]
        public int LossesPerkChickenBow { get; set; }

        [JsonProperty("kills_perk_invisibility")]
        public int KillsPerkInvisibility { get; set; }

        [JsonProperty("losses_perk_invisibility")]
        public int LossesPerkInvisibility { get; set; }

        [JsonProperty("kills_perk_chicken_bow")]
        public int KillsPerkChickenBow { get; set; }

        [JsonProperty("losses_perk_skeleton_jockey")]
        public int LossesPerkSkeletonJockey { get; set; }

        [JsonProperty("kills_perk_skeleton_jockey")]
        public int KillsPerkSkeletonJockey { get; set; }

        [JsonProperty("deaths_perk_skeleton_jockey")]
        public int DeathsPerkSkeletonJockey { get; set; }

        [JsonProperty("losses_perk_enderman")]
        public int LossesPerkEnderman { get; set; }

        [JsonProperty("deaths_perk_enderman")]
        public int DeathsPerkEnderman { get; set; }

        [JsonProperty("deaths_perk_creeper")]
        public int DeathsPerkCreeper { get; set; }

        [JsonProperty("deaths_perk_guardian")]
        public int DeathsPerkGuardian { get; set; }

        [JsonProperty("losses_perk_guardian")]
        public int LossesPerkGuardian { get; set; }

        [JsonProperty("losses_perk_creeper")]
        public int LossesPerkCreeper { get; set; }

        [JsonProperty("kills_perk_enderman")]
        public int KillsPerkEnderman { get; set; }

        [JsonProperty("kills_perk_creeper")]
        public int KillsPerkCreeper { get; set; }

        [JsonProperty("kills_perk_guardian")]
        public int KillsPerkGuardian { get; set; }

        [JsonProperty("wins_perk_guardian")]
        public int WinsPerkGuardian { get; set; }

        [JsonProperty("wins_perk_creeper")]
        public int WinsPerkCreeper { get; set; }

        [JsonProperty("wins_perk_enderman")]
        public int WinsPerkEnderman { get; set; }

        [JsonProperty("perk_nuclear_solution_duplicates")]
        public int PerkNuclearSolutionDuplicates { get; set; }

        [JsonProperty("deaths_perk_pearl_absorption")]
        public int DeathsPerkPearlAbsorption { get; set; }

        [JsonProperty("losses_perk_pearl_absorption")]
        public int LossesPerkPearlAbsorption { get; set; }

        [JsonProperty("kills_perk_pearl_absorption")]
        public int KillsPerkPearlAbsorption { get; set; }

        [JsonProperty("deaths_perk_bigger_bangs")]
        public int DeathsPerkBiggerBangs { get; set; }

        [JsonProperty("deaths_perk_snow_golem")]
        public int DeathsPerkSnowGolem { get; set; }

        [JsonProperty("losses_perk_bigger_bangs")]
        public int LossesPerkBiggerBangs { get; set; }

        [JsonProperty("kills_perk_bigger_bangs")]
        public int KillsPerkBiggerBangs { get; set; }

        [JsonProperty("losses_perk_snow_golem")]
        public int LossesPerkSnowGolem { get; set; }

        [JsonProperty("kills_perk_snow_golem")]
        public int KillsPerkSnowGolem { get; set; }

        [JsonProperty("losses_perk_explosive_bow")]
        public int LossesPerkExplosiveBow { get; set; }

        [JsonProperty("kills_perk_explosive_bow")]
        public int KillsPerkExplosiveBow { get; set; }

        [JsonProperty("deaths_perk_explosive_bow")]
        public int DeathsPerkExplosiveBow { get; set; }

        [JsonProperty("kills_perk_honed_bow")]
        public int KillsPerkHonedBow { get; set; }

        [JsonProperty("wins_perk_marksman")]
        public int WinsPerkMarksman { get; set; }

        [JsonProperty("kills_perk_marksman")]
        public int KillsPerkMarksman { get; set; }

        [JsonProperty("wins_perk_honed_bow")]
        public int WinsPerkHonedBow { get; set; }

        [JsonProperty("losses_perk_arrow_deflection")]
        public int LossesPerkArrowDeflection { get; set; }

        [JsonProperty("deaths_perk_arrow_deflection")]
        public int DeathsPerkArrowDeflection { get; set; }

        [JsonProperty("kills_perk_blast_protection")]
        public int KillsPerkBlastProtection { get; set; }

        [JsonProperty("losses_perk_blast_protection")]
        public int LossesPerkBlastProtection { get; set; }

        [JsonProperty("deaths_perk_blast_protection")]
        public int DeathsPerkBlastProtection { get; set; }

        [JsonProperty("wins_perk_explosive_bow")]
        public int WinsPerkExplosiveBow { get; set; }

        [JsonProperty("wins_perk_hearty_start")]
        public int WinsPerkHeartyStart { get; set; }

        [JsonProperty("deaths_perk_hit_and_run")]
        public int DeathsPerkHitAndRun { get; set; }

        [JsonProperty("losses_perk_hit_and_run")]
        public int LossesPerkHitAndRun { get; set; }

        [JsonProperty("deaths_perk_marksman")]
        public int DeathsPerkMarksman { get; set; }

        [JsonProperty("losses_perk_marksman")]
        public int LossesPerkMarksman { get; set; }

        [JsonProperty("wins_perk_invisibility")]
        public int WinsPerkInvisibility { get; set; }

        [JsonProperty("wins_perk_fruit_finder")]
        public int WinsPerkFruitFinder { get; set; }

        [JsonProperty("losses_perk_elven_archer")]
        public int LossesPerkElvenArcher { get; set; }

        [JsonProperty("deaths_perk_elven_archer")]
        public int DeathsPerkElvenArcher { get; set; }

        [JsonProperty("kills_perk_elven_archer")]
        public int KillsPerkElvenArcher { get; set; }

        [JsonProperty("wins_perk_flower_power")]
        public int WinsPerkFlowerPower { get; set; }

        [JsonProperty("kills_perk_flower_power")]
        public int KillsPerkFlowerPower { get; set; }

        [JsonProperty("kills_perk_arrow_deflection")]
        public int KillsPerkArrowDeflection { get; set; }

        [JsonProperty("wins_perk_tripleshot")]
        public int WinsPerkTripleshot { get; set; }

        [JsonProperty("wins_perk_bat_shield")]
        public int WinsPerkBatShield { get; set; }

        [JsonProperty("wins_perk_blast_protection")]
        public int WinsPerkBlastProtection { get; set; }

        [JsonProperty("kills_perk_bat_shield")]
        public int KillsPerkBatShield { get; set; }

        [JsonProperty("losses_perk_honed_bow")]
        public int LossesPerkHonedBow { get; set; }

        [JsonProperty("deaths_perk_honed_bow")]
        public int DeathsPerkHonedBow { get; set; }

        [JsonProperty("deaths_perk_nuclear_solution")]
        public int DeathsPerkNuclearSolution { get; set; }

        [JsonProperty("kills_perk_nuclear_solution")]
        public int KillsPerkNuclearSolution { get; set; }

        [JsonProperty("losses_perk_nuclear_solution")]
        public int LossesPerkNuclearSolution { get; set; }

        [JsonProperty("kills_solo_perk_archer_challenge")]
        public int KillsSoloPerkArcherChallenge { get; set; }

        [JsonProperty("deaths_perk_bat_shield")]
        public int DeathsPerkBatShield { get; set; }

        [JsonProperty("kills_perk_nutritious")]
        public int KillsPerkNutritious { get; set; }

        [JsonProperty("losses_perk_bat_shield")]
        public int LossesPerkBatShield { get; set; }

        [JsonProperty("deaths_perk_nutritious")]
        public int DeathsPerkNutritious { get; set; }

        [JsonProperty("losses_perk_nutritious")]
        public int LossesPerkNutritious { get; set; }

        [JsonProperty("wins_perk_arrow_deflection")]
        public int WinsPerkArrowDeflection { get; set; }

        [JsonProperty("deaths_perk_sugar_rush")]
        public int DeathsPerkSugarRush { get; set; }

        [JsonProperty("losses_perk_sugar_rush")]
        public int LossesPerkSugarRush { get; set; }

        [JsonProperty("deaths_perk_rampage")]
        public int DeathsPerkRampage { get; set; }

        [JsonProperty("losses_perk_rampage")]
        public int LossesPerkRampage { get; set; }

        [JsonProperty("kills_perk_rampage")]
        public int KillsPerkRampage { get; set; }

        [JsonProperty("kills_perk_alchemy")]
        public int KillsPerkAlchemy { get; set; }

        [JsonProperty("losses_perk_alchemy")]
        public int LossesPerkAlchemy { get; set; }

        [JsonProperty("deaths_perk_alchemy")]
        public int DeathsPerkAlchemy { get; set; }

        [JsonProperty("kills_perk_energy_drink")]
        public int KillsPerkEnergyDrink { get; set; }

        [JsonProperty("deaths_perk_energy_drink")]
        public int DeathsPerkEnergyDrink { get; set; }

        [JsonProperty("losses_perk_energy_drink")]
        public int LossesPerkEnergyDrink { get; set; }

        [JsonProperty("losses_perk_blazing_arrows")]
        public int LossesPerkBlazingArrows { get; set; }

        [JsonProperty("kills_perk_blazing_arrows")]
        public int KillsPerkBlazingArrows { get; set; }

        [JsonProperty("deaths_perk_blazing_arrows")]
        public int DeathsPerkBlazingArrows { get; set; }

        [JsonProperty("kills_perk_iron_golem")]
        public int KillsPerkIronGolem { get; set; }

        [JsonProperty("deaths_perk_iron_golem")]
        public int DeathsPerkIronGolem { get; set; }

        [JsonProperty("losses_perk_iron_golem")]
        public int LossesPerkIronGolem { get; set; }

        [JsonProperty("wins_perk_nuclear_solution")]
        public int WinsPerkNuclearSolution { get; set; }

        [JsonProperty("kills_perk_sugar_rush")]
        public int KillsPerkSugarRush { get; set; }

        [JsonProperty("wins_perk_sugar_rush")]
        public int WinsPerkSugarRush { get; set; }

        [JsonProperty("wins_perk_elven_archer")]
        public int WinsPerkElvenArcher { get; set; }

        [JsonProperty("wins_perk_alchemy")]
        public int WinsPerkAlchemy { get; set; }

        [JsonProperty("wins_perk_chicken_bow")]
        public int WinsPerkChickenBow { get; set; }

        [JsonProperty("wins_perk_energy_drink")]
        public int WinsPerkEnergyDrink { get; set; }

        [JsonProperty("wins_perk_bigger_bangs")]
        public int WinsPerkBiggerBangs { get; set; }

        [JsonProperty("wins_perk_snow_golem")]
        public int WinsPerkSnowGolem { get; set; }

        [JsonProperty("deaths_perk_flower_power")]
        public int DeathsPerkFlowerPower { get; set; }

        [JsonProperty("losses_perk_flower_power")]
        public int LossesPerkFlowerPower { get; set; }

        [JsonProperty("wins_perk_endless_quiver")]
        public int WinsPerkEndlessQuiver { get; set; }

        [JsonProperty("deaths_perk_supply_drop")]
        public int DeathsPerkSupplyDrop { get; set; }

        [JsonProperty("kills_perk_supply_drop")]
        public int KillsPerkSupplyDrop { get; set; }

        [JsonProperty("losses_perk_supply_drop")]
        public int LossesPerkSupplyDrop { get; set; }

        [JsonProperty("wins_perk_blazing_arrows")]
        public int WinsPerkBlazingArrows { get; set; }

        [JsonProperty("wins_perk_skeleton_jockey")]
        public int WinsPerkSkeletonJockey { get; set; }

        [JsonProperty("wins_perk_rampage")]
        public int WinsPerkRampage { get; set; }

        [JsonProperty("wins_perk_pearl_absorption")]
        public int WinsPerkPearlAbsorption { get; set; }

        [JsonProperty("wins_perk_nutritious")]
        public int WinsPerkNutritious { get; set; }

        [JsonProperty("perk_monster_hunter")]
        public int PerkMonsterHunter { get; set; }

        [JsonProperty("perk_lifesteal")]
        public int PerkLifesteal { get; set; }

        [JsonProperty("perk_void_chest")]
        public int PerkVoidChest { get; set; }

        [JsonProperty("perk_bounty_hunter")]
        public int PerkBountyHunter { get; set; }

        [JsonProperty("perk_double_jump")]
        public int PerkDoubleJump { get; set; }
        #endregion

        #region frostnight kit
        [JsonProperty("kit_frost_knight_minor")]
        public int KitFrostKnightMinor { get; set; }

        [JsonProperty("melee_kills_kit_frost_knight")]
        public int MeleeKillsKitFrostKnight { get; set; }

        [JsonProperty("mobs_spawned_kit_frost_knight")]
        public int MobsSpawnedKitFrostKnight { get; set; }

        [JsonProperty("deaths_kit_frost_knight")]
        public int DeathsKitFrostKnight { get; set; }

        [JsonProperty("games_played_kit_frost_knight")]
        public int GamesPlayedKitFrostKnight { get; set; }

        [JsonProperty("kills_kit_frost_knight")]
        public int KillsKitFrostKnight { get; set; }

        [JsonProperty("most_kills_game_kit_frost_knight")]
        public int MostKillsGameKitFrostKnight { get; set; }

        [JsonProperty("void_kills_kit_frost_knight")]
        public int VoidKillsKitFrostKnight { get; set; }

        [JsonProperty("fastest_win_solo_kit_frost_knight")]
        public int FastestWinSoloKitFrostKnight { get; set; }

        [JsonProperty("solo_wins_kit_frost_knight")]
        public int SoloWinsKitFrostKnight { get; set; }

        [JsonProperty("bow_shots_kit_frost_knight")]
        public int BowShotsKitFrostKnight { get; set; }

        [JsonProperty("kit_frost_knight_master")]
        public int KitFrostKnightMaster { get; set; }

        [JsonProperty("longest_bow_shot_kit_frost_knight")]
        public int LongestBowShotKitFrostKnight { get; set; }

        [JsonProperty("bow_hits_kit_frost_knight")]
        public int BowHitsKitFrostKnight { get; set; }

        [JsonProperty("enderchests_opened_kit_frost_knight")]
        public int EnderchestsOpenedKitFrostKnight { get; set; }

        [JsonProperty("fastest_win_doubles_kit_frost_knight")]
        public int FastestWinDoublesKitFrostKnight { get; set; }

        [JsonProperty("doubles_wins_kit_frost_knight")]
        public int DoublesWinsKitFrostKnight { get; set; }

        [JsonProperty("mobs_killed_kit_frost_knight")]
        public int MobsKilledKitFrostKnight { get; set; }

        [JsonProperty("assists_kit_frost_knight")]
        public int AssistsKitFrostKnight { get; set; }

        [JsonProperty("longest_bow_kill_kit_frost_knight")]
        public int LongestBowKillKitFrostKnight { get; set; }

        [JsonProperty("bow_kills_kit_frost_knight")]
        public int BowKillsKitFrostKnight { get; set; }

        [JsonProperty("cute_pants_found_kit_frost_knight")]
        public int CutePantsFoundKitFrostKnight { get; set; }
        #endregion

        #region jumpman kit
        [JsonProperty("kit_jumpman_minor")]
        public int KitJumpmanMinor { get; set; }

        [JsonProperty("kit_jumpman_master")]
        public int KitJumpmanMaster { get; set; }

        [JsonProperty("most_kills_game_kit_jumpman")]
        public int MostKillsGameKitJumpman { get; set; }

        [JsonProperty("deaths_kit_jumpman")]
        public int DeathsKitJumpman { get; set; }

        [JsonProperty("kills_kit_jumpman")]
        public int KillsKitJumpman { get; set; }

        [JsonProperty("void_kills_kit_jumpman")]
        public int VoidKillsKitJumpman { get; set; }

        [JsonProperty("melee_kills_kit_jumpman")]
        public int MeleeKillsKitJumpman { get; set; }

        [JsonProperty("games_played_kit_jumpman")]
        public int GamesPlayedKitJumpman { get; set; }

        [JsonProperty("longest_bow_shot_kit_jumpman")]
        public int LongestBowShotKitJumpman { get; set; }

        [JsonProperty("bow_shots_kit_jumpman")]
        public int BowShotsKitJumpman { get; set; }

        [JsonProperty("bow_hits_kit_jumpman")]
        public int BowHitsKitJumpman { get; set; }

        [JsonProperty("assists_kit_jumpman")]
        public int AssistsKitJumpman { get; set; }

        [JsonProperty("mobs_spawned_kit_jumpman")]
        public int MobsSpawnedKitJumpman { get; set; }

        [JsonProperty("fastest_win_solo_kit_jumpman")]
        public int FastestWinSoloKitJumpman { get; set; }

        [JsonProperty("solo_wins_kit_jumpman")]
        public int SoloWinsKitJumpman { get; set; }

        [JsonProperty("enderchests_opened_kit_jumpman")]
        public int EnderchestsOpenedKitJumpman { get; set; }

        [JsonProperty("mobs_killed_kit_jumpman")]
        public int MobsKilledKitJumpman { get; set; }
        #endregion

        #region swordman kit
        [JsonProperty("fastest_win_solo_kit_swordsman")]
        public int FastestWinSoloKitSwordsman { get; set; }

        [JsonProperty("kills_kit_swordsman")]
        public int KillsKitSwordsman { get; set; }

        [JsonProperty("void_kills_kit_swordsman")]
        public int VoidKillsKitSwordsman { get; set; }

        [JsonProperty("games_played_kit_swordsman")]
        public int GamesPlayedKitSwordsman { get; set; }

        [JsonProperty("melee_kills_kit_swordsman")]
        public int MeleeKillsKitSwordsman { get; set; }

        [JsonProperty("solo_wins_kit_swordsman")]
        public int SoloWinsKitSwordsman { get; set; }

        [JsonProperty("most_kills_game_kit_swordsman")]
        public int MostKillsGameKitSwordsman { get; set; }

        [JsonProperty("deaths_kit_swordsman")]
        public int DeathsKitSwordsman { get; set; }

        [JsonProperty("mobs_killed_kit_swordsman")]
        public int MobsKilledKitSwordsman { get; set; }

        [JsonProperty("longest_bow_shot_kit_swordsman")]
        public int LongestBowShotKitSwordsman { get; set; }

        [JsonProperty("bow_shots_kit_swordsman")]
        public int BowShotsKitSwordsman { get; set; }

        [JsonProperty("bow_hits_kit_swordsman")]
        public int BowHitsKitSwordsman { get; set; }

        [JsonProperty("enderchests_opened_kit_swordsman")]
        public int EnderchestsOpenedKitSwordsman { get; set; }

        [JsonProperty("assists_kit_swordsman")]
        public int AssistsKitSwordsman { get; set; }

        [JsonProperty("kit_swordsman_minor")]
        public int KitSwordsmanMinor { get; set; }

        [JsonProperty("mob_kills_kit_swordsman")]
        public int MobKillsKitSwordsman { get; set; }

        [JsonProperty("longest_bow_kill_kit_swordsman")]
        public int LongestBowKillKitSwordsman { get; set; }

        [JsonProperty("bow_kills_kit_swordsman")]
        public int BowKillsKitSwordsman { get; set; }

        [JsonProperty("fastest_win_team_war_kit_swordsman")]
        public int FastestWinTeamWarKitSwordsman { get; set; }

        [JsonProperty("team_war_wins_kit_swordsman")]
        public int TeamWarWinsKitSwordsman { get; set; }

        [JsonProperty("fastest_win_doubles_kit_swordsman")]
        public int FastestWinDoublesKitSwordsman { get; set; }

        [JsonProperty("doubles_wins_kit_swordsman")]
        public int DoublesWinsKitSwordsman { get; set; }

        [JsonProperty("kit_swordsman_master")]
        public int KitSwordsmanMaster { get; set; }

        [JsonProperty("mobs_spawned_kit_swordsman")]
        public int MobsSpawnedKitSwordsman { get; set; }

        [JsonProperty("cute_pants_found_kit_swordsman")]
        public int CutePantsFoundKitSwordsman { get; set; }
        #endregion

        #region assassin kit
        [JsonProperty("games_played_kit_assassin")]
        public int GamesPlayedKitAssassin { get; set; }

        [JsonProperty("deaths_kit_assassin")]
        public int DeathsKitAssassin { get; set; }

        [JsonProperty("assists_kit_assassin")]
        public int AssistsKitAssassin { get; set; }

        [JsonProperty("most_kills_game_kit_assassin")]
        public int MostKillsGameKitAssassin { get; set; }

        [JsonProperty("mobs_killed_kit_assassin")]
        public int MobsKilledKitAssassin { get; set; }

        [JsonProperty("melee_kills_kit_assassin")]
        public int MeleeKillsKitAssassin { get; set; }

        [JsonProperty("kills_kit_assassin")]
        public int KillsKitAssassin { get; set; }

        [JsonProperty("bow_shots_kit_assassin")]
        public int BowShotsKitAssassin { get; set; }

        [JsonProperty("void_kills_kit_assassin")]
        public int VoidKillsKitAssassin { get; set; }

        [JsonProperty("longest_bow_shot_kit_assassin")]
        public int LongestBowShotKitAssassin { get; set; }

        [JsonProperty("bow_hits_kit_assassin")]
        public int BowHitsKitAssassin { get; set; }

        [JsonProperty("enderchests_opened_kit_assassin")]
        public int EnderchestsOpenedKitAssassin { get; set; }

        [JsonProperty("fastest_win_solo_kit_assassin")]
        public int FastestWinSoloKitAssassin { get; set; }

        [JsonProperty("solo_wins_kit_assassin")]
        public int SoloWinsKitAssassin { get; set; }

        [JsonProperty("mob_kills_kit_assassin")]
        public int MobKillsKitAssassin { get; set; }

        [JsonProperty("kit_assassin_minor")]
        public int KitAssassinMinor { get; set; }

        [JsonProperty("fastest_win_team_war_kit_assassin")]
        public int FastestWinTeamWarKitAssassin { get; set; }

        [JsonProperty("team_war_wins_kit_assassin")]
        public int TeamWarWinsKitAssassin { get; set; }

        [JsonProperty("kit_assassin_master")]
        public int KitAssassinMaster { get; set; }

        [JsonProperty("longest_bow_kill_kit_assassin")]
        public int LongestBowKillKitAssassin { get; set; }

        [JsonProperty("bow_kills_kit_assassin")]
        public int BowKillsKitAssassin { get; set; }

        [JsonProperty("mobs_spawned_kit_assassin")]
        public int MobsSpawnedKitAssassin { get; set; }

        [JsonProperty("cute_pants_found_kit_assassin")]
        public int CutePantsFoundKitAssassin { get; set; }
        #endregion

        #region necromancer
        [JsonProperty("kit_necromancer_minor")]
        public int KitNecromancerMinor { get; set; }

        [JsonProperty("longest_bow_shot_kit_necromancer")]
        public int LongestBowShotKitNecromancer { get; set; }

        [JsonProperty("void_kills_kit_necromancer")]
        public int VoidKillsKitNecromancer { get; set; }

        [JsonProperty("bow_hits_kit_necromancer")]
        public int BowHitsKitNecromancer { get; set; }

        [JsonProperty("games_played_kit_necromancer")]
        public int GamesPlayedKitNecromancer { get; set; }

        [JsonProperty("bow_shots_kit_necromancer")]
        public int BowShotsKitNecromancer { get; set; }

        [JsonProperty("deaths_kit_necromancer")]
        public int DeathsKitNecromancer { get; set; }

        [JsonProperty("most_kills_game_kit_necromancer")]
        public int MostKillsGameKitNecromancer { get; set; }

        [JsonProperty("melee_kills_kit_necromancer")]
        public int MeleeKillsKitNecromancer { get; set; }

        [JsonProperty("kills_kit_necromancer")]
        public int KillsKitNecromancer { get; set; }

        [JsonProperty("mobs_killed_kit_necromancer")]
        public int MobsKilledKitNecromancer { get; set; }

        [JsonProperty("assists_kit_necromancer")]
        public int AssistsKitNecromancer { get; set; }

        [JsonProperty("mob_kills_kit_necromancer")]
        public int MobKillsKitNecromancer { get; set; }

        [JsonProperty("enderchests_opened_kit_necromancer")]
        public int EnderchestsOpenedKitNecromancer { get; set; }

        [JsonProperty("fastest_win_solo_kit_necromancer")]
        public int FastestWinSoloKitNecromancer { get; set; }

        [JsonProperty("solo_wins_kit_necromancer")]
        public int SoloWinsKitNecromancer { get; set; }

        [JsonProperty("kit_necromancer_master")]
        public int KitNecromancerMaster { get; set; }

        [JsonProperty("longest_bow_kill_kit_necromancer")]
        public int LongestBowKillKitNecromancer { get; set; }

        [JsonProperty("bow_kills_kit_necromancer")]
        public int BowKillsKitNecromancer { get; set; }

        [JsonProperty("mobs_spawned_kit_necromancer")]
        public int MobsSpawnedKitNecromancer { get; set; }

        [JsonProperty("cute_pants_found_kit_necromancer")]
        public int CutePantsFoundKitNecromancer { get; set; }
        #endregion

        #region cleric kit
        [JsonProperty("kit_cleric_minor")]
        public int KitClericMinor { get; set; }

        [JsonProperty("deaths_kit_cleric")]
        public int DeathsKitCleric { get; set; }

        [JsonProperty("games_played_kit_cleric")]
        public int GamesPlayedKitCleric { get; set; }

        [JsonProperty("kills_kit_cleric")]
        public int KillsKitCleric { get; set; }

        [JsonProperty("melee_kills_kit_cleric")]
        public int MeleeKillsKitCleric { get; set; }

        [JsonProperty("most_kills_game_kit_cleric")]
        public int MostKillsGameKitCleric { get; set; }

        [JsonProperty("void_kills_kit_cleric")]
        public int VoidKillsKitCleric { get; set; }

        [JsonProperty("enderchests_opened_kit_cleric")]
        public int EnderchestsOpenedKitCleric { get; set; }

        [JsonProperty("mobs_killed_kit_cleric")]
        public int MobsKilledKitCleric { get; set; }

        [JsonProperty("mob_kills_kit_cleric")]
        public int MobKillsKitCleric { get; set; }

        [JsonProperty("assists_kit_cleric")]
        public int AssistsKitCleric { get; set; }

        [JsonProperty("longest_bow_shot_kit_cleric")]
        public int LongestBowShotKitCleric { get; set; }

        [JsonProperty("bow_hits_kit_cleric")]
        public int BowHitsKitCleric { get; set; }

        [JsonProperty("bow_shots_kit_cleric")]
        public int BowShotsKitCleric { get; set; }

        [JsonProperty("fastest_win_solo_kit_cleric")]
        public int FastestWinSoloKitCleric { get; set; }

        [JsonProperty("solo_wins_kit_cleric")]
        public int SoloWinsKitCleric { get; set; }

        [JsonProperty("fastest_win_doubles_kit_cleric")]
        public int FastestWinDoublesKitCleric { get; set; }

        [JsonProperty("doubles_wins_kit_cleric")]
        public int DoublesWinsKitCleric { get; set; }

        [JsonProperty("kit_cleric_master")]
        public int KitClericMaster { get; set; }

        [JsonProperty("longest_bow_kill_kit_cleric")]
        public int LongestBowKillKitCleric { get; set; }

        [JsonProperty("bow_kills_kit_cleric")]
        public int BowKillsKitCleric { get; set; }

        [JsonProperty("fastest_win_team_war_kit_cleric")]
        public int FastestWinTeamWarKitCleric { get; set; }

        [JsonProperty("team_war_wins_kit_cleric")]
        public int TeamWarWinsKitCleric { get; set; }

        [JsonProperty("mobs_spawned_kit_cleric")]
        public int MobsSpawnedKitCleric { get; set; }

        [JsonProperty("cute_pants_found_kit_cleric")]
        public int CutePantsFoundKitCleric { get; set; }
        #endregion

        #region scout kit
        [JsonProperty("games_played_kit_scout")]
        public int GamesPlayedKitScout { get; set; }

        [JsonProperty("deaths_kit_scout")]
        public int DeathsKitScout { get; set; }

        [JsonProperty("kit_scout_minor")]
        public int KitScoutMinor { get; set; }

        [JsonProperty("kills_kit_scout")]
        public int KillsKitScout { get; set; }

        [JsonProperty("melee_kills_kit_scout")]
        public int MeleeKillsKitScout { get; set; }

        [JsonProperty("most_kills_game_kit_scout")]
        public int MostKillsGameKitScout { get; set; }

        [JsonProperty("void_kills_kit_scout")]
        public int VoidKillsKitScout { get; set; }

        [JsonProperty("assists_kit_scout")]
        public int AssistsKitScout { get; set; }

        [JsonProperty("kit_scout_master")]
        public int KitScoutMaster { get; set; }

        [JsonProperty("mobs_killed_kit_scout")]
        public int MobsKilledKitScout { get; set; }

        [JsonProperty("longest_bow_shot_kit_scout")]
        public int LongestBowShotKitScout { get; set; }

        [JsonProperty("fastest_win_solo_kit_scout")]
        public int FastestWinSoloKitScout { get; set; }

        [JsonProperty("enderchests_opened_kit_scout")]
        public int EnderchestsOpenedKitScout { get; set; }

        [JsonProperty("solo_wins_kit_scout")]
        public int SoloWinsKitScout { get; set; }

        [JsonProperty("bow_shots_kit_scout")]
        public int BowShotsKitScout { get; set; }

        [JsonProperty("bow_hits_kit_scout")]
        public int BowHitsKitScout { get; set; }

        [JsonProperty("fastest_win_team_war_kit_scout")]
        public int FastestWinTeamWarKitScout { get; set; }

        [JsonProperty("team_war_wins_kit_scout")]
        public int TeamWarWinsKitScout { get; set; }

        [JsonProperty("longest_bow_kill_kit_scout")]
        public int LongestBowKillKitScout { get; set; }

        [JsonProperty("bow_kills_kit_scout")]
        public int BowKillsKitScout { get; set; }

        [JsonProperty("fastest_win_doubles_kit_scout")]
        public int FastestWinDoublesKitScout { get; set; }

        [JsonProperty("doubles_wins_kit_scout")]
        public int DoublesWinsKitScout { get; set; }

        [JsonProperty("mob_kills_kit_scout")]
        public int MobKillsKitScout { get; set; }

        [JsonProperty("cute_pants_found_kit_scout")]
        public int CutePantsFoundKitScout { get; set; }

        [JsonProperty("mobs_spawned_kit_scout")]
        public int MobsSpawnedKitScout { get; set; }
        #endregion

        #region guardian kit
        [JsonProperty("kit_guardian_minor")]
        public int KitGuardianMinor { get; set; }

        [JsonProperty("games_played_kit_guardian")]
        public int GamesPlayedKitGuardian { get; set; }

        [JsonProperty("most_kills_game_kit_guardian")]
        public int MostKillsGameKitGuardian { get; set; }

        [JsonProperty("void_kills_kit_guardian")]
        public int VoidKillsKitGuardian { get; set; }

        [JsonProperty("kills_kit_guardian")]
        public int KillsKitGuardian { get; set; }

        [JsonProperty("deaths_kit_guardian")]
        public int DeathsKitGuardian { get; set; }

        [JsonProperty("melee_kills_kit_guardian")]
        public int MeleeKillsKitGuardian { get; set; }

        [JsonProperty("assists_kit_guardian")]
        public int AssistsKitGuardian { get; set; }

        [JsonProperty("bow_shots_kit_guardian")]
        public int BowShotsKitGuardian { get; set; }

        [JsonProperty("fastest_win_solo_kit_guardian")]
        public int FastestWinSoloKitGuardian { get; set; }

        [JsonProperty("enderchests_opened_kit_guardian")]
        public int EnderchestsOpenedKitGuardian { get; set; }

        [JsonProperty("solo_wins_kit_guardian")]
        public int SoloWinsKitGuardian { get; set; }

        [JsonProperty("mobs_killed_kit_guardian")]
        public int MobsKilledKitGuardian { get; set; }

        [JsonProperty("longest_bow_shot_kit_guardian")]
        public int LongestBowShotKitGuardian { get; set; }

        [JsonProperty("bow_hits_kit_guardian")]
        public int BowHitsKitGuardian { get; set; }

        [JsonProperty("kit_guardian_master")]
        public int KitGuardianMaster { get; set; }

        [JsonProperty("mob_kills_kit_guardian")]
        public int MobKillsKitGuardian { get; set; }

        [JsonProperty("longest_bow_kill_kit_guardian")]
        public int LongestBowKillKitGuardian { get; set; }

        [JsonProperty("bow_kills_kit_guardian")]
        public int BowKillsKitGuardian { get; set; }

        [JsonProperty("fastest_win_doubles_kit_guardian")]
        public int FastestWinDoublesKitGuardian { get; set; }

        [JsonProperty("doubles_wins_kit_guardian")]
        public int DoublesWinsKitGuardian { get; set; }

        [JsonProperty("fastest_win_team_war_kit_guardian")]
        public int FastestWinTeamWarKitGuardian { get; set; }

        [JsonProperty("team_war_wins_kit_guardian")]
        public int TeamWarWinsKitGuardian { get; set; }

        [JsonProperty("mobs_spawned_kit_guardian")]
        public int MobsSpawnedKitGuardian { get; set; }
        #endregion

        #region berserker kit
        [JsonProperty("most_kills_game_kit_berserker")]
        public int MostKillsGameKitBerserker { get; set; }

        [JsonProperty("games_played_kit_berserker")]
        public int GamesPlayedKitBerserker { get; set; }

        [JsonProperty("kills_kit_berserker")]
        public int KillsKitBerserker { get; set; }

        [JsonProperty("deaths_kit_berserker")]
        public int DeathsKitBerserker { get; set; }

        [JsonProperty("kit_berserker_minor")]
        public int KitBerserkerMinor { get; set; }

        [JsonProperty("melee_kills_kit_berserker")]
        public int MeleeKillsKitBerserker { get; set; }

        [JsonProperty("mobs_killed_kit_berserker")]
        public int MobsKilledKitBerserker { get; set; }

        [JsonProperty("void_kills_kit_berserker")]
        public int VoidKillsKitBerserker { get; set; }

        [JsonProperty("kit_berserker_master")]
        public int KitBerserkerMaster { get; set; }

        [JsonProperty("bow_shots_kit_berserker")]
        public int BowShotsKitBerserker { get; set; }

        [JsonProperty("enderchests_opened_kit_berserker")]
        public int EnderchestsOpenedKitBerserker { get; set; }

        [JsonProperty("assists_kit_berserker")]
        public int AssistsKitBerserker { get; set; }

        [JsonProperty("fastest_win_solo_kit_berserker")]
        public int FastestWinSoloKitBerserker { get; set; }

        [JsonProperty("solo_wins_kit_berserker")]
        public int SoloWinsKitBerserker { get; set; }

        [JsonProperty("mob_kills_kit_berserker")]
        public int MobKillsKitBerserker { get; set; }

        [JsonProperty("mobs_spawned_kit_berserker")]
        public int MobsSpawnedKitBerserker { get; set; }

        [JsonProperty("longest_bow_shot_kit_berserker")]
        public int LongestBowShotKitBerserker { get; set; }

        [JsonProperty("bow_hits_kit_berserker")]
        public int BowHitsKitBerserker { get; set; }

        [JsonProperty("longest_bow_kill_kit_berserker")]
        public int LongestBowKillKitBerserker { get; set; }

        [JsonProperty("bow_kills_kit_berserker")]
        public int BowKillsKitBerserker { get; set; }
        #endregion

        #region archer kit
        [JsonProperty("kit_archer_minor")]
        public int KitArcherMinor { get; set; }

        [JsonProperty("longest_bow_shot_kit_archer")]
        public int LongestBowShotKitArcher { get; set; }

        [JsonProperty("void_kills_kit_archer")]
        public int VoidKillsKitArcher { get; set; }

        [JsonProperty("bow_hits_kit_archer")]
        public int BowHitsKitArcher { get; set; }

        [JsonProperty("kills_kit_archer")]
        public int KillsKitArcher { get; set; }

        [JsonProperty("bow_shots_kit_archer")]
        public int BowShotsKitArcher { get; set; }

        [JsonProperty("games_played_kit_archer")]
        public int GamesPlayedKitArcher { get; set; }

        [JsonProperty("most_kills_game_kit_archer")]
        public int MostKillsGameKitArcher { get; set; }

        [JsonProperty("deaths_kit_archer")]
        public int DeathsKitArcher { get; set; }

        [JsonProperty("enderchests_opened_kit_archer")]
        public int EnderchestsOpenedKitArcher { get; set; }

        [JsonProperty("melee_kills_kit_archer")]
        public int MeleeKillsKitArcher { get; set; }

        [JsonProperty("assists_kit_archer")]
        public int AssistsKitArcher { get; set; }

        [JsonProperty("mobs_killed_kit_archer")]
        public int MobsKilledKitArcher { get; set; }

        [JsonProperty("longest_bow_kill_kit_archer")]
        public int LongestBowKillKitArcher { get; set; }

        [JsonProperty("bow_kills_kit_archer")]
        public int BowKillsKitArcher { get; set; }

        [JsonProperty("fastest_win_solo_kit_archer")]
        public int FastestWinSoloKitArcher { get; set; }

        [JsonProperty("solo_wins_kit_archer")]
        public int SoloWinsKitArcher { get; set; }

        [JsonProperty("kit_archer_master")]
        public int KitArcherMaster { get; set; }

        [JsonProperty("mobs_spawned_kit_archer")]
        public int MobsSpawnedKitArcher { get; set; }

        [JsonProperty("cute_pants_found_kit_archer")]
        public int CutePantsFoundKitArcher { get; set; }

        [JsonProperty("mob_kills_kit_archer")]
        public int MobKillsKitArcher { get; set; }

        [JsonProperty("fastest_win_doubles_kit_archer")]
        public int FastestWinDoublesKitArcher { get; set; }

        [JsonProperty("doubles_wins_kit_archer")]
        public int DoublesWinsKitArcher { get; set; }
        #endregion

        #region treasure hunter kit
        [JsonProperty("kit_treasure_hunter_minor")]
        public int KitTreasureHunterMinor { get; set; }

        [JsonProperty("fastest_win_solo_kit_treasure_hunter")]
        public int FastestWinSoloKitTreasureHunter { get; set; }

        [JsonProperty("games_played_kit_treasure_hunter")]
        public int GamesPlayedKitTreasureHunter { get; set; }

        [JsonProperty("enderchests_opened_kit_treasure_hunter")]
        public int EnderchestsOpenedKitTreasureHunter { get; set; }

        [JsonProperty("mobs_spawned_kit_treasure_hunter")]
        public int MobsSpawnedKitTreasureHunter { get; set; }

        [JsonProperty("solo_wins_kit_treasure_hunter")]
        public int SoloWinsKitTreasureHunter { get; set; }

        [JsonProperty("kills_kit_treasure_hunter")]
        public int KillsKitTreasureHunter { get; set; }

        [JsonProperty("void_kills_kit_treasure_hunter")]
        public int VoidKillsKitTreasureHunter { get; set; }

        [JsonProperty("assists_kit_treasure_hunter")]
        public int AssistsKitTreasureHunter { get; set; }

        [JsonProperty("most_kills_game_kit_treasure_hunter")]
        public int MostKillsGameKitTreasureHunter { get; set; }

        [JsonProperty("melee_kills_kit_treasure_hunter")]
        public int MeleeKillsKitTreasureHunter { get; set; }

        [JsonProperty("deaths_kit_treasure_hunter")]
        public int DeathsKitTreasureHunter { get; set; }

        [JsonProperty("longest_bow_shot_kit_treasure_hunter")]
        public int LongestBowShotKitTreasureHunter { get; set; }

        [JsonProperty("bow_shots_kit_treasure_hunter")]
        public int BowShotsKitTreasureHunter { get; set; }

        [JsonProperty("bow_hits_kit_treasure_hunter")]
        public int BowHitsKitTreasureHunter { get; set; }

        [JsonProperty("cute_pants_found_kit_treasure_hunter")]
        public int CutePantsFoundKitTreasureHunter { get; set; }

        [JsonProperty("kit_treasure_hunter_master")]
        public int KitTreasureHunterMaster { get; set; }

        [JsonProperty("mob_kills_kit_treasure_hunter")]
        public int MobKillsKitTreasureHunter { get; set; }

        [JsonProperty("mobs_killed_kit_treasure_hunter")]
        public int MobsKilledKitTreasureHunter { get; set; }

        [JsonProperty("fastest_win_team_war_kit_treasure_hunter")]
        public int FastestWinTeamWarKitTreasureHunter { get; set; }

        [JsonProperty("team_war_wins_kit_treasure_hunter")]
        public int TeamWarWinsKitTreasureHunter { get; set; }

        [JsonProperty("fastest_win_doubles_kit_treasure_hunter")]
        public int FastestWinDoublesKitTreasureHunter { get; set; }

        [JsonProperty("doubles_wins_kit_treasure_hunter")]
        public int DoublesWinsKitTreasureHunter { get; set; }

        [JsonProperty("longest_bow_kill_kit_treasure_hunter")]
        public int LongestBowKillKitTreasureHunter { get; set; }

        [JsonProperty("bow_kills_kit_treasure_hunter")]
        public int BowKillsKitTreasureHunter { get; set; }
        #endregion
    }
}