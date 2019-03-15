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
        public int deaths_perk_witch { get; set; }
        [JsonProperty("deaths_perk_hearty_start")]
        public int deaths_perk_hearty_start { get; set; }
        [JsonProperty("deaths_perk_tripleshot")]
        public int deaths_perk_tripleshot { get; set; }
        [JsonProperty("losses_perk_tripleshot")]
        public int losses_perk_tripleshot { get; set; }
        [JsonProperty("kills_perk_hearty_start")]
        public int kills_perk_hearty_start { get; set; }
        [JsonProperty("losses_perk_hearty_start")]
        public int losses_perk_hearty_start { get; set; }
        [JsonProperty("kills_perk_tripleshot")]
        public int kills_perk_tripleshot { get; set; }
        [JsonProperty("deaths_perk_invisibility")]
        public int deaths_perk_invisibility { get; set; }
        [JsonProperty("losses_perk_fruit_finder")]
        public int losses_perk_fruit_finder { get; set; }
        [JsonProperty("deaths_perk_chicken_bow")]
        public int deaths_perk_chicken_bow { get; set; }
        [JsonProperty("kills_perk_fruit_finder")]
        public int kills_perk_fruit_finder { get; set; }
        [JsonProperty("deaths_perk_fruit_finder")]
        public int deaths_perk_fruit_finder { get; set; }
        [JsonProperty("losses_perk_chicken_bow")]
        public int losses_perk_chicken_bow { get; set; }
        [JsonProperty("kills_perk_invisibility")]
        public int kills_perk_invisibility { get; set; }
        [JsonProperty("losses_perk_invisibility")]
        public int losses_perk_invisibility { get; set; }
        [JsonProperty("kills_perk_chicken_bow")]
        public int kills_perk_chicken_bow { get; set; }
        [JsonProperty("losses_perk_skeleton_jockey")]
        public int losses_perk_skeleton_jockey { get; set; }
        [JsonProperty("kills_perk_skeleton_jockey")]
        public int kills_perk_skeleton_jockey { get; set; }
        [JsonProperty("deaths_perk_skeleton_jockey")]
        public int deaths_perk_skeleton_jockey { get; set; }
        [JsonProperty("losses_perk_enderman")]
        public int losses_perk_enderman { get; set; }
        [JsonProperty("deaths_perk_enderman")]
        public int deaths_perk_enderman { get; set; }
        [JsonProperty("deaths_perk_creeper")]
        public int deaths_perk_creeper { get; set; }
        [JsonProperty("deaths_perk_guardian")]
        public int deaths_perk_guardian { get; set; }
        [JsonProperty("losses_perk_guardian")]
        public int losses_perk_guardian { get; set; }
        [JsonProperty("losses_perk_creeper")]
        public int losses_perk_creeper { get; set; }
        [JsonProperty("kills_perk_enderman")]
        public int kills_perk_enderman { get; set; }
        [JsonProperty("kills_perk_creeper")]
        public int kills_perk_creeper { get; set; }
        [JsonProperty("kills_perk_guardian")]
        public int kills_perk_guardian { get; set; }
        [JsonProperty("wins_perk_guardian")]
        public int wins_perk_guardian { get; set; }
        [JsonProperty("wins_perk_creeper")]
        public int wins_perk_creeper { get; set; }
        [JsonProperty("wins_perk_enderman")]
        public int wins_perk_enderman { get; set; }
        [JsonProperty("perk_nuclear_solution_duplicates")]
        public int perk_nuclear_solution_duplicates { get; set; }
        [JsonProperty("deaths_perk_pearl_absorption")]
        public int deaths_perk_pearl_absorption { get; set; }
        [JsonProperty("losses_perk_pearl_absorption")]
        public int losses_perk_pearl_absorption { get; set; }
        [JsonProperty("kills_perk_pearl_absorption")]
        public int kills_perk_pearl_absorption { get; set; }
        [JsonProperty("deaths_perk_bigger_bangs")]
        public int deaths_perk_bigger_bangs { get; set; }
        [JsonProperty("deaths_perk_snow_golem")]
        public int deaths_perk_snow_golem { get; set; }
        [JsonProperty("losses_perk_bigger_bangs")]
        public int losses_perk_bigger_bangs { get; set; }
        [JsonProperty("kills_perk_bigger_bangs")]
        public int kills_perk_bigger_bangs { get; set; }
        [JsonProperty("losses_perk_snow_golem")]
        public int losses_perk_snow_golem { get; set; }
        [JsonProperty("kills_perk_snow_golem")]
        public int kills_perk_snow_golem { get; set; }
        [JsonProperty("losses_perk_explosive_bow")]
        public int losses_perk_explosive_bow { get; set; }
        [JsonProperty("kills_perk_explosive_bow")]
        public int kills_perk_explosive_bow { get; set; }
        [JsonProperty("deaths_perk_explosive_bow")]
        public int deaths_perk_explosive_bow { get; set; }
        [JsonProperty("kills_perk_honed_bow")]
        public int kills_perk_honed_bow { get; set; }
        [JsonProperty("wins_perk_marksman")]
        public int wins_perk_marksman { get; set; }
        [JsonProperty("kills_perk_marksman")]
        public int kills_perk_marksman { get; set; }
        [JsonProperty("wins_perk_honed_bow")]
        public int wins_perk_honed_bow { get; set; }
        [JsonProperty("losses_perk_arrow_deflection")]
        public int losses_perk_arrow_deflection { get; set; }
        [JsonProperty("deaths_perk_arrow_deflection")]
        public int deaths_perk_arrow_deflection { get; set; }
        [JsonProperty("kills_perk_blast_protection")]
        public int kills_perk_blast_protection { get; set; }
        [JsonProperty("losses_perk_blast_protection")]
        public int losses_perk_blast_protection { get; set; }
        [JsonProperty("deaths_perk_blast_protection")]
        public int deaths_perk_blast_protection { get; set; }
        [JsonProperty("wins_perk_explosive_bow")]
        public int wins_perk_explosive_bow { get; set; }
        [JsonProperty("wins_perk_hearty_start")]
        public int wins_perk_hearty_start { get; set; }
        [JsonProperty("deaths_perk_hit_and_run")]
        public int deaths_perk_hit_and_run { get; set; }
        [JsonProperty("losses_perk_hit_and_run")]
        public int losses_perk_hit_and_run { get; set; }
        [JsonProperty("deaths_perk_marksman")]
        public int deaths_perk_marksman { get; set; }
        [JsonProperty("losses_perk_marksman")]
        public int losses_perk_marksman { get; set; }
        [JsonProperty("wins_perk_invisibility")]
        public int wins_perk_invisibility { get; set; }
        [JsonProperty("wins_perk_fruit_finder")]
        public int wins_perk_fruit_finder { get; set; }
        [JsonProperty("losses_perk_elven_archer")]
        public int losses_perk_elven_archer { get; set; }
        [JsonProperty("deaths_perk_elven_archer")]
        public int deaths_perk_elven_archer { get; set; }
        [JsonProperty("kills_perk_elven_archer")]
        public int kills_perk_elven_archer { get; set; }
        [JsonProperty("wins_perk_flower_power")]
        public int wins_perk_flower_power { get; set; }
        [JsonProperty("kills_perk_flower_power")]
        public int kills_perk_flower_power { get; set; }
        [JsonProperty("kills_perk_arrow_deflection")]
        public int kills_perk_arrow_deflection { get; set; }
        [JsonProperty("wins_perk_tripleshot")]
        public int wins_perk_tripleshot { get; set; }
        [JsonProperty("wins_perk_bat_shield")]
        public int wins_perk_bat_shield { get; set; }
        [JsonProperty("wins_perk_blast_protection")]
        public int wins_perk_blast_protection { get; set; }
        [JsonProperty("kills_perk_bat_shield")]
        public int kills_perk_bat_shield { get; set; }
        [JsonProperty("losses_perk_honed_bow")]
        public int losses_perk_honed_bow { get; set; }
        [JsonProperty("deaths_perk_honed_bow")]
        public int deaths_perk_honed_bow { get; set; }
        [JsonProperty("deaths_perk_nuclear_solution")]
        public int deaths_perk_nuclear_solution { get; set; }
        [JsonProperty("kills_perk_nuclear_solution")]
        public int kills_perk_nuclear_solution { get; set; }
        [JsonProperty("losses_perk_nuclear_solution")]
        public int losses_perk_nuclear_solution { get; set; }
        [JsonProperty("kills_solo_perk_archer_challenge")]
        public int kills_solo_perk_archer_challenge { get; set; }
        [JsonProperty("deaths_perk_bat_shield")]
        public int deaths_perk_bat_shield { get; set; }
        [JsonProperty("kills_perk_nutritious")]
        public int kills_perk_nutritious { get; set; }
        [JsonProperty("losses_perk_bat_shield")]
        public int losses_perk_bat_shield { get; set; }
        [JsonProperty("deaths_perk_nutritious")]
        public int deaths_perk_nutritious { get; set; }
        [JsonProperty("losses_perk_nutritious")]
        public int losses_perk_nutritious { get; set; }
        [JsonProperty("wins_perk_arrow_deflection")]
        public int wins_perk_arrow_deflection { get; set; }
        [JsonProperty("deaths_perk_sugar_rush")]
        public int deaths_perk_sugar_rush { get; set; }
        [JsonProperty("losses_perk_sugar_rush")]
        public int losses_perk_sugar_rush { get; set; }
        [JsonProperty("deaths_perk_rampage")]
        public int deaths_perk_rampage { get; set; }
        [JsonProperty("losses_perk_rampage")]
        public int losses_perk_rampage { get; set; }
        [JsonProperty("kills_perk_rampage")]
        public int kills_perk_rampage { get; set; }
        [JsonProperty("kills_perk_alchemy")]
        public int kills_perk_alchemy { get; set; }
        [JsonProperty("losses_perk_alchemy")]
        public int losses_perk_alchemy { get; set; }
        [JsonProperty("deaths_perk_alchemy")]
        public int deaths_perk_alchemy { get; set; }
        [JsonProperty("kills_perk_energy_drink")]
        public int kills_perk_energy_drink { get; set; }
        [JsonProperty("deaths_perk_energy_drink")]
        public int deaths_perk_energy_drink { get; set; }
        [JsonProperty("losses_perk_energy_drink")]
        public int losses_perk_energy_drink { get; set; }
        [JsonProperty("losses_perk_blazing_arrows")]
        public int losses_perk_blazing_arrows { get; set; }
        [JsonProperty("kills_perk_blazing_arrows")]
        public int kills_perk_blazing_arrows { get; set; }
        [JsonProperty("deaths_perk_blazing_arrows")]
        public int deaths_perk_blazing_arrows { get; set; }
        [JsonProperty("kills_perk_iron_golem")]
        public int kills_perk_iron_golem { get; set; }
        [JsonProperty("deaths_perk_iron_golem")]
        public int deaths_perk_iron_golem { get; set; }
        [JsonProperty("losses_perk_iron_golem")]
        public int losses_perk_iron_golem { get; set; }
        [JsonProperty("wins_perk_nuclear_solution")]
        public int wins_perk_nuclear_solution { get; set; }
        [JsonProperty("kills_perk_sugar_rush")]
        public int kills_perk_sugar_rush { get; set; }
        [JsonProperty("wins_perk_sugar_rush")]
        public int wins_perk_sugar_rush { get; set; }
        [JsonProperty("wins_perk_elven_archer")]
        public int wins_perk_elven_archer { get; set; }
        [JsonProperty("wins_perk_alchemy")]
        public int wins_perk_alchemy { get; set; }
        [JsonProperty("wins_perk_chicken_bow")]
        public int wins_perk_chicken_bow { get; set; }
        [JsonProperty("wins_perk_energy_drink")]
        public int wins_perk_energy_drink { get; set; }
        [JsonProperty("wins_perk_bigger_bangs")]
        public int wins_perk_bigger_bangs { get; set; }
        [JsonProperty("wins_perk_snow_golem")]
        public int wins_perk_snow_golem { get; set; }
        [JsonProperty("deaths_perk_flower_power")]
        public int deaths_perk_flower_power { get; set; }
        [JsonProperty("losses_perk_flower_power")]
        public int losses_perk_flower_power { get; set; }
        [JsonProperty("wins_perk_endless_quiver")]
        public int wins_perk_endless_quiver { get; set; }
        [JsonProperty("deaths_perk_supply_drop")]
        public int deaths_perk_supply_drop { get; set; }
        [JsonProperty("kills_perk_supply_drop")]
        public int kills_perk_supply_drop { get; set; }
        [JsonProperty("losses_perk_supply_drop")]
        public int losses_perk_supply_drop { get; set; }
        [JsonProperty("wins_perk_blazing_arrows")]
        public int wins_perk_blazing_arrows { get; set; }
        [JsonProperty("wins_perk_skeleton_jockey")]
        public int wins_perk_skeleton_jockey { get; set; }
        [JsonProperty("wins_perk_rampage")]
        public int wins_perk_rampage { get; set; }
        [JsonProperty("wins_perk_pearl_absorption")]
        public int wins_perk_pearl_absorption { get; set; }
        [JsonProperty("wins_perk_nutritious")]
        public int wins_perk_nutritious { get; set; }
        [JsonProperty("perk_monster_hunter")]
        public int perk_monster_hunter { get; set; }
        [JsonProperty("perk_lifesteal")]
        public int perk_lifesteal { get; set; }
        [JsonProperty("perk_void_chest")]
        public int perk_void_chest { get; set; }
        [JsonProperty("perk_bounty_hunter")]
        public int perk_bounty_hunter { get; set; }
        [JsonProperty("perk_double_jump")]
        public int perk_double_jump { get; set; }
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


    }
}