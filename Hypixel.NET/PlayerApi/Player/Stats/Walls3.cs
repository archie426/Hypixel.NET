using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Walls3
    {
        #region general
        [JsonProperty("chosen_class")]
        public string ChosenClass { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }
        #endregion

        #region final kills
        [JsonProperty("finalKills")]
        public int FinalKills { get; set; }

        [JsonProperty("finalKills_Arcanist")]
        public int FinalKillsArcanist { get; set; }

        [JsonProperty("finalKills_Blaze")]
        public int FinalKillsBlaze { get; set; }

        [JsonProperty("finalKills_Creeper")]
        public int FinalKillsCreeper { get; set; }

        [JsonProperty("finalKills_Dreadlord")]
        public int FinalKillsDreadlord { get; set; }

        [JsonProperty("finalKills_Enderman")]
        public int FinalKillsEnderman { get; set; }

        [JsonProperty("finalKills_Golem")]
        public int FinalKillsGolem { get; set; }

        [JsonProperty("finalKills_Herobrine")]
        public int FinalKillsHerobrine { get; set; }

        [JsonProperty("finalKills_Pigman")]
        public int FinalKillsPigman { get; set; }

        [JsonProperty("finalKills_Shaman")]
        public int FinalKillsShaman { get; set; }

        [JsonProperty("finalKills_Skeleton")]
        public int FinalKillsSkeleton { get; set; }

        [JsonProperty("finalKills_Spider")]
        public int FinalKillsSpider { get; set; }

        [JsonProperty("finalKills_Zombie")]
        public int FinalKillsZombie { get; set; }

        [JsonProperty("finalKills_Squid")]
        public int FinalKillsSquid { get; set; }

        [JsonProperty("finalKills_Pirate")]
        public int FinalKillsPirate { get; set; }

        [JsonProperty("hunter_final_kills")]
        public int HunterFinalKills { get; set; }

        [JsonProperty("moleman_final_kills")]
        public int MolemanFinalKills { get; set; }
        #endregion

        #region finalassists
        [JsonProperty("finalAssists")]
        public int FinalAssists { get; set; }

        [JsonProperty("finalAssists_Dreadlord")]
        public int FinalAssistsDreadlord { get; set; }

        [JsonProperty("finalAssists_Arcanist")]
        public int FinalAssistsArcanist { get; set; }

        [JsonProperty("finalAssists_Spider")]
        public int FinalAssistsSpider { get; set; }

        [JsonProperty("finalAssists_Enderman")]
        public int FinalAssistsEnderman { get; set; }

        [JsonProperty("finalAssists_Herobrine")]
        public int FinalAssistsHerobrine { get; set; }

        [JsonProperty("finalAssists_Creeper")]
        public int FinalAssistsCreeper { get; set; }

        [JsonProperty("finalAssists_Skeleton")]
        public int FinalAssistsSkeleton { get; set; }

        [JsonProperty("finalAssists_Shaman")]
        public int FinalAssistsShaman { get; set; }

        [JsonProperty("finalAssists_Golem")]
        public int FinalAssistsGolem { get; set; }

        [JsonProperty("finalAssists_Zombie")]
        public int FinalAssistsZombie { get; set; }

        [JsonProperty("finalAssists_Blaze")]
        public int FinalAssistsBlaze { get; set; }

        [JsonProperty("finalAssists_Pigman")]
        public int FinalAssistsPigman { get; set; }

        [JsonProperty("finalAssists_Squid")]
        public int FinalAssistsSquid { get; set; }

        [JsonProperty("finalAssists_Pirate")]
        public int FinalAssistsPirate { get; set; }

        [JsonProperty("hunter_final_assists")]
        public int HunterFinalAssists { get; set; }

        [JsonProperty("moleman_final_assists")]
        public int MolemanFinalAssists { get; set; }
        #endregion


        #region finaldeaths
        [JsonProperty("finalDeaths")]
        public int FinalDeaths { get; set; }

        [JsonProperty("skeleton_final_deaths")]
        public int SkeletonFinalDeaths { get; set; }

        [JsonProperty("zombie_final_deaths")]
        public int ZombieFinalDeaths { get; set; }

        [JsonProperty("arcanist_final_deaths")]
        public int ArcanistFinalDeaths { get; set; }

        [JsonProperty("enderman_final_deaths")]
        public int EndermanFinalDeaths { get; set; }

        [JsonProperty("dreadlord_final_deaths")]
        public int DreadlordFinalDeaths { get; set; }

        [JsonProperty("spider_final_deaths")]
        public int SpiderFinalDeaths { get; set; }

        [JsonProperty("golem_final_deaths")]
        public int GolemFinalDeaths { get; set; }

        [JsonProperty("blaze_final_deaths")]
        public int BlazeFinalDeaths { get; set; }

        [JsonProperty("squid_final_deaths")]
        public int SquidFinalDeaths { get; set; }

        [JsonProperty("shaman_final_deaths")]
        public int ShamanFinalDeaths { get; set; }

        [JsonProperty("moleman_final_deaths")]
        public int MolemanFinalDeaths { get; set; }

        [JsonProperty("pigman_final_deaths")]
        public int PigmanFinalDeaths { get; set; }

        [JsonProperty("pirate_final_deaths")]
        public int PirateFinalDeaths { get; set; }

        [JsonProperty("creeper_final_deaths")]
        public int CreeperFinalDeaths { get; set; }

        [JsonProperty("hunter_final_deaths")]
        public int HunterFinalDeaths { get; set; }

        [JsonProperty("herobrine_final_deaths")]
        public int HerobrineFinalDeaths { get; set; }
        #endregion finaldeaths

        #region wins
        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("wins_Arcanist")]
        public int WinsArcanist { get; set; }

        [JsonProperty("wins_Creeper")]
        public int WinsCreeper { get; set; }

        [JsonProperty("wins_Dreadlord")]
        public int WinsDreadlord { get; set; }

        [JsonProperty("wins_Enderman")]
        public int WinsEnderman { get; set; }

        [JsonProperty("wins_Golem")]
        public int WinsGolem { get; set; }

        [JsonProperty("wins_Herobrine")]
        public int WinsHerobrine { get; set; }

        [JsonProperty("wins_Pigman")]
        public int WinsPigman { get; set; }

        [JsonProperty("wins_Shaman")]
        public int WinsShaman { get; set; }

        [JsonProperty("wins_Skeleton")]
        public int WinsSkeleton { get; set; }

        [JsonProperty("wins_Spider")]
        public int WinsSpider { get; set; }

        [JsonProperty("wins_Zombie")]
        public int WinsZombie { get; set; }

        [JsonProperty("hunter_wins")]
        public int HunterWins { get; set; }

        [JsonProperty("moleman_wins")]
        public int MolemanWins { get; set; }
        #endregion

        #region kills
        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("kills_Arcanist")]
        public int KillsArcanist { get; set; }

        [JsonProperty("kills_Blaze")]
        public int KillsBlaze { get; set; }

        [JsonProperty("kills_Creeper")]
        public int KillsCreeper { get; set; }

        [JsonProperty("kills_Dreadlord")]
        public int KillsDreadlord { get; set; }

        [JsonProperty("kills_Enderman")]
        public int KillsEnderman { get; set; }

        [JsonProperty("kills_Golem")]
        public int KillsGolem { get; set; }

        [JsonProperty("kills_Herobrine")]
        public int KillsHerobrine { get; set; }

        [JsonProperty("kills_Pigman")]
        public int KillsPigman { get; set; }

        [JsonProperty("kills_Shaman")]
        public int KillsShaman { get; set; }

        [JsonProperty("kills_Skeleton")]
        public int KillsSkeleton { get; set; }

        [JsonProperty("kills_Spider")]
        public int KillsSpider { get; set; }

        [JsonProperty("kills_Zombie")]
        public int KillsZombie { get; set; }

        [JsonProperty("hunter_kills")]
        public int HunterKills { get; set; }

        [JsonProperty("moleman_kills")]
        public int MolemanKills { get; set; }
        #endregion


        #region deaths
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("deaths_Arcanist")]
        public int DeathsArcanist { get; set; }

        [JsonProperty("deaths_Blaze")]
        public int DeathsBlaze { get; set; }

        [JsonProperty("deaths_Creeper")]
        public int DeathsCreeper { get; set; }

        [JsonProperty("deaths_Dreadlord")]
        public int DeathsDreadlord { get; set; }

        [JsonProperty("deaths_Enderman")]
        public int DeathsEnderman { get; set; }

        [JsonProperty("deaths_Golem")]
        public int DeathsGolem { get; set; }

        [JsonProperty("deaths_Herobrine")]
        public int DeathsHerobrine { get; set; }

        [JsonProperty("deaths_Pigman")]
        public int DeathsPigman { get; set; }

        [JsonProperty("deaths_Shaman")]
        public int DeathsShaman { get; set; }

        [JsonProperty("deaths_Skeleton")]
        public int DeathsSkeleton { get; set; }

        [JsonProperty("deaths_Spider")]
        public int DeathsSpider { get; set; }

        [JsonProperty("deaths_Zombie")]
        public int DeathsZombie { get; set; }

        [JsonProperty("hunter_deaths")]
        public int HunterDeaths { get; set; }

        [JsonProperty("moleman_deaths")]
        public int MolemanDeaths { get; set; }
        #endregion


        #region losses
        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("losses_Arcanist")]
        public int LossesArcanist { get; set; }

        [JsonProperty("losses_Blaze")]
        public int LossesBlaze { get; set; }

        [JsonProperty("losses_Creeper")]
        public int LossesCreeper { get; set; }

        [JsonProperty("losses_Dreadlord")]
        public int LossesDreadlord { get; set; }

        [JsonProperty("losses_Enderman")]
        public int LossesEnderman { get; set; }

        [JsonProperty("losses_Golem")]
        public int LossesGolem { get; set; }

        [JsonProperty("losses_Herobrine")]
        public int LossesHerobrine { get; set; }

        [JsonProperty("losses_Pigman")]
        public int LossesPigman { get; set; }

        [JsonProperty("losses_Shaman")]
        public int LossesShaman { get; set; }

        [JsonProperty("losses_Skeleton")]
        public int LossesSkeleton { get; set; }

        [JsonProperty("losses_Spider")]
        public int LossesSpider { get; set; }

        [JsonProperty("losses_Zombie")]
        public int LossesZombie { get; set; }

        [JsonProperty("hunter_lossess")]
        public int HunterLossess { get; set; }

        [JsonProperty("moleman_losses")]
        public int MolemanLosses { get; set; }
        #endregion

        #region assists
        [JsonProperty("assists_Dreadlord")]
        public int AssistsDreadlord { get; set; }

        [JsonProperty("assists_Arcanist")]
        public int AssistsArcanist { get; set; }

        [JsonProperty("assists_Spider")]
        public int AssistsSpider { get; set; }

        [JsonProperty("assists_Enderman")]
        public int AssistsEnderman { get; set; }

        [JsonProperty("assists_Herobrine")]
        public int AssistsHerobrine { get; set; }

        [JsonProperty("assists_Creeper")]
        public int AssistsCreeper { get; set; }

        [JsonProperty("assists_Skeleton")]
        public int AssistsSkeleton { get; set; }

        [JsonProperty("assists_Shaman")]
        public int AssistsShaman { get; set; }

        [JsonProperty("assists_Zombie")]
        public int AssistsZombie { get; set; }

        [JsonProperty("assists_Golem")]
        public int AssistsGolem { get; set; }

        [JsonProperty("assists_Blaze")]
        public int AssistsBlaze { get; set; }

        [JsonProperty("assists_Pigman")]
        public int AssistsPigman { get; set; }

        [JsonProperty("assists_Squid")]
        public int AssistsSquid { get; set; }

        [JsonProperty("assists_Pirate")]
        public int AssistsPirate { get; set; }

        [JsonProperty("hunter_assists")]
        public int HunterAssists { get; set; }

        [JsonProperty("moleman_assists")]
        public int MolemanAssists { get; set; }
        #endregion

        #region meters walked
        [JsonProperty("skeleton_meters_walked")]
        public int SkeletonMetersWalked { get; set; }

        [JsonProperty("meters_walked")]
        public int MetersWalked { get; set; }

        [JsonProperty("enderman_meters_walked")]
        public int EndermanMetersWalked { get; set; }

        [JsonProperty("arcanist_meters_walked")]
        public int ArcanistMetersWalked { get; set; }

        [JsonProperty("zombie_meters_walked")]
        public int ZombieMetersWalked { get; set; }

        [JsonProperty("creeper_meters_walked")]
        public int CreeperMetersWalked { get; set; }

        [JsonProperty("dreadlord_meters_walked")]
        public int DreadlordMetersWalked { get; set; }

        [JsonProperty("golem_meters_walked")]
        public int GolemMetersWalked { get; set; }

        [JsonProperty("spider_meters_walked")]
        public int SpiderMetersWalked { get; set; }

        [JsonProperty("blaze_meters_walked")]
        public int BlazeMetersWalked { get; set; }

        [JsonProperty("herobrine_meters_walked")]
        public int HerobrineMetersWalked { get; set; }

        [JsonProperty("squid_meters_walked")]
        public int SquidMetersWalked { get; set; }

        [JsonProperty("shaman_meters_walked")]
        public int ShamanMetersWalked { get; set; }

        [JsonProperty("moleman_meters_walked")]
        public int MolemanMetersWalked { get; set; }

        [JsonProperty("pigman_meters_walked")]
        public int PigmanMetersWalked { get; set; }

        [JsonProperty("pirate_meters_walked")]
        public int PirateMetersWalked { get; set; }

        [JsonProperty("hunter_meters_walked")]
        public int HunterMetersWalked { get; set; }
        #endregion

        #region potions drunk
        [JsonProperty("potions_drunk")]
        public int PotionsDrunk { get; set; }

        [JsonProperty("skeleton_potions_drunk")]
        public int SkeletonPotionsDrunk { get; set; }

        [JsonProperty("arcanist_potions_drunk")]
        public int ArcanistPotionsDrunk { get; set; }

        [JsonProperty("enderman_potions_drunk")]
        public int EndermanPotionsDrunk { get; set; }

        [JsonProperty("zombie_potions_drunk")]
        public int ZombiePotionsDrunk { get; set; }

        [JsonProperty("creeper_potions_drunk")]
        public int CreeperPotionsDrunk { get; set; }

        [JsonProperty("dreadlord_potions_drunk")]
        public int DreadlordPotionsDrunk { get; set; }

        [JsonProperty("golem_potions_drunk")]
        public int GolemPotionsDrunk { get; set; }

        [JsonProperty("spider_potions_drunk")]
        public int SpiderPotionsDrunk { get; set; }

        [JsonProperty("blaze_potions_drunk")]
        public int BlazePotionsDrunk { get; set; }

        [JsonProperty("herobrine_potions_drunk")]
        public int HerobrinePotionsDrunk { get; set; }

        [JsonProperty("squid_potions_drunk")]
        public int SquidPotionsDrunk { get; set; }

        [JsonProperty("shaman_potions_drunk")]
        public int ShamanPotionsDrunk { get; set; }

        [JsonProperty("pigman_potions_drunk")]
        public int PigmanPotionsDrunk { get; set; }

        [JsonProperty("pirate_potions_drunk")]
        public int PiratePotionsDrunk { get; set; }
        #endregion

        #region blocks broken
        [JsonProperty("blocks_broken")]
        public int BlocksBroken { get; set; }

        [JsonProperty("skeleton_blocks_broken")]
        public int SkeletonBlocksBroken { get; set; }

        [JsonProperty("arcanist_blocks_broken")]
        public int ArcanistBlocksBroken { get; set; }

        [JsonProperty("enderman_blocks_broken")]
        public int EndermanBlocksBroken { get; set; }

        [JsonProperty("zombie_blocks_broken")]
        public int ZombieBlocksBroken { get; set; }

        [JsonProperty("creeper_blocks_broken")]
        public int CreeperBlocksBroken { get; set; }

        [JsonProperty("dreadlord_blocks_broken")]
        public int DreadlordBlocksBroken { get; set; }

        [JsonProperty("golem_blocks_broken")]
        public int GolemBlocksBroken { get; set; }

        [JsonProperty("spider_blocks_broken")]
        public int SpiderBlocksBroken { get; set; }

        [JsonProperty("blaze_blocks_broken")]
        public int BlazeBlocksBroken { get; set; }

        [JsonProperty("herobrine_blocks_broken")]
        public int HerobrineBlocksBroken { get; set; }

        [JsonProperty("squid_blocks_broken")]
        public int SquidBlocksBroken { get; set; }

        [JsonProperty("shaman_blocks_broken")]
        public int ShamanBlocksBroken { get; set; }

        [JsonProperty("moleman_blocks_broken")]
        public int MolemanBlocksBroken { get; set; }

        [JsonProperty("pigman_blocks_broken")]
        public int PigmanBlocksBroken { get; set; }

        [JsonProperty("pirate_blocks_broken")]
        public int PirateBlocksBroken { get; set; }

        [JsonProperty("hunter_blocks_broken")]
        public int HunterBlocksBroken { get; set; }
        #endregion

        #region blocks placed
        [JsonProperty("blocks_placed")]
        public int BlocksPlaced { get; set; }

        [JsonProperty("skeleton_blocks_placed")]
        public int SkeletonBlocksPlaced { get; set; }

        [JsonProperty("arcanist_blocks_placed")]
        public int ArcanistBlocksPlaced { get; set; }

        [JsonProperty("enderman_blocks_placed")]
        public int EndermanBlocksPlaced { get; set; }

        [JsonProperty("zombie_blocks_placed")]
        public int ZombieBlocksPlaced { get; set; }

        [JsonProperty("creeper_blocks_placed")]
        public int CreeperBlocksPlaced { get; set; }

        [JsonProperty("dreadlord_blocks_placed")]
        public int DreadlordBlocksPlaced { get; set; }

        [JsonProperty("golem_blocks_placed")]
        public int GolemBlocksPlaced { get; set; }

        [JsonProperty("spider_blocks_placed")]
        public int SpiderBlocksPlaced { get; set; }

        [JsonProperty("blaze_blocks_placed")]
        public int BlazeBlocksPlaced { get; set; }

        [JsonProperty("herobrine_blocks_placed")]
        public int HerobrineBlocksPlaced { get; set; }

        [JsonProperty("squid_blocks_placed")]
        public int SquidBlocksPlaced { get; set; }

        [JsonProperty("shaman_blocks_placed")]
        public int ShamanBlocksPlaced { get; set; }

        [JsonProperty("moleman_blocks_placed")]
        public int MolemanBlocksPlaced { get; set; }

        [JsonProperty("pigman_blocks_placed")]
        public int PigmanBlocksPlaced { get; set; }

        [JsonProperty("pirate_blocks_placed")]
        public int PirateBlocksPlaced { get; set; }

        [JsonProperty("hunter_blocks_placed")]
        public int HunterBlocksPlaced { get; set; }
        #endregion

        #region arrows fired
        [JsonProperty("arrows_fired")]
        public int ArrowsFired { get; set; }

        [JsonProperty("skeleton_arrows_fired")]
        public int SkeletonArrowsFired { get; set; }

        [JsonProperty("arcanist_arrows_fired")]
        public int ArcanistArrowsFired { get; set; }

        [JsonProperty("enderman_arrows_fired")]
        public int EndermanArrowsFired { get; set; }

        [JsonProperty("zombie_arrows_fired")]
        public int ZombieArrowsFired { get; set; }

        [JsonProperty("creeper_arrows_fired")]
        public int CreeperArrowsFired { get; set; }

        [JsonProperty("dreadlord_arrows_fired")]
        public int DreadlordArrowsFired { get; set; }

        [JsonProperty("golem_arrows_fired")]
        public int GolemArrowsFired { get; set; }

        [JsonProperty("spider_arrows_fired")]
        public int SpiderArrowsFired { get; set; }

        [JsonProperty("blaze_arrows_fired")]
        public int BlazeArrowsFired { get; set; }

        [JsonProperty("herobrine_arrows_fired")]
        public int HerobrineArrowsFired { get; set; }

        [JsonProperty("squid_arrows_fired")]
        public int SquidArrowsFired { get; set; }

        [JsonProperty("moleman_arrows_fired")]
        public int MolemanArrowsFired { get; set; }

        [JsonProperty("pigman_arrows_fired")]
        public int PigmanArrowsFired { get; set; }

        [JsonProperty("hunter_arrows_fired")]
        public int HunterArrowsFired { get; set; }
        #endregion

        #region arrows hit
        [JsonProperty("arrows_hit")]
        public int ArrowsHit { get; set; }

        [JsonProperty("skeleton_arrows_hit")]
        public int SkeletonArrowsHit { get; set; }

        [JsonProperty("arcanist_arrows_hit")]
        public int ArcanistArrowsHit { get; set; }

        [JsonProperty("enderman_arrows_hit")]
        public int EndermanArrowsHit { get; set; }

        [JsonProperty("zombie_arrows_hit")]
        public int ZombieArrowsHit { get; set; }

        [JsonProperty("creeper_arrows_hit")]
        public int CreeperArrowsHit { get; set; }

        [JsonProperty("dreadlord_arrows_hit")]
        public int DreadlordArrowsHit { get; set; }

        [JsonProperty("golem_arrows_hit")]
        public int GolemArrowsHit { get; set; }

        [JsonProperty("spider_arrows_hit")]
        public int SpiderArrowsHit { get; set; }

        [JsonProperty("blaze_arrows_hit")]
        public int BlazeArrowsHit { get; set; }

        [JsonProperty("herobrine_arrows_hit")]
        public int HerobrineArrowsHit { get; set; }

        [JsonProperty("squid_arrows_hit")]
        public int SquidArrowsHit { get; set; }

        [JsonProperty("moleman_arrows_hit")]
        public int MolemanArrowsHit { get; set; }

        [JsonProperty("pigman_arrows_hit")]
        public int PigmanArrowsHit { get; set; }

        [JsonProperty("hunter_arrows_hit")]
        public int HunterArrowsHit { get; set; }
        #endregion

        #region meters fallen
        [JsonProperty("meters_fallen")]
        public int MetersFallen { get; set; }

        [JsonProperty("skeleton_meters_fallen")]
        public int SkeletonMetersFallen { get; set; }

        [JsonProperty("enderman_meters_fallen")]
        public int EndermanMetersFallen { get; set; }

        [JsonProperty("arcanist_meters_fallen")]
        public int ArcanistMetersFallen { get; set; }

        [JsonProperty("zombie_meters_fallen")]
        public int ZombieMetersFallen { get; set; }

        [JsonProperty("creeper_meters_fallen")]
        public int CreeperMetersFallen { get; set; }

        [JsonProperty("dreadlord_meters_fallen")]
        public int DreadlordMetersFallen { get; set; }

        [JsonProperty("golem_meters_fallen")]
        public int GolemMetersFallen { get; set; }

        [JsonProperty("spider_meters_fallen")]
        public int SpiderMetersFallen { get; set; }

        [JsonProperty("blaze_meters_fallen")]
        public int BlazeMetersFallen { get; set; }

        [JsonProperty("herobrine_meters_fallen")]
        public int HerobrineMetersFallen { get; set; }

        [JsonProperty("squid_meters_fallen")]
        public int SquidMetersFallen { get; set; }

        [JsonProperty("shaman_meters_fallen")]
        public int ShamanMetersFallen { get; set; }

        [JsonProperty("moleman_meters_fallen")]
        public int MolemanMetersFallen { get; set; }

        [JsonProperty("pigman_meters_fallen")]
        public int PigmanMetersFallen { get; set; }

        [JsonProperty("pirate_meters_fallen")]
        public int PirateMetersFallen { get; set; }

        [JsonProperty("hunter_meters_fallen")]
        public int HunterMetersFallen { get; set; }
        #endregion

        #region iron ore broken
        [JsonProperty("iron_ore_broken")]
        public int IronOreBroken { get; set; }

        [JsonProperty("skeleton_iron_ore_broken")]
        public int SkeletonIronOreBroken { get; set; }

        [JsonProperty("arcanist_iron_ore_broken")]
        public int ArcanistIronOreBroken { get; set; }

        [JsonProperty("enderman_iron_ore_broken")]
        public int EndermanIronOreBroken { get; set; }

        [JsonProperty("zombie_iron_ore_broken")]
        public int ZombieIronOreBroken { get; set; }

        [JsonProperty("creeper_iron_ore_broken")]
        public int CreeperIronOreBroken { get; set; }

        [JsonProperty("dreadlord_iron_ore_broken")]
        public int DreadlordIronOreBroken { get; set; }

        [JsonProperty("golem_iron_ore_broken")]
        public int GolemIronOreBroken { get; set; }

        [JsonProperty("spider_iron_ore_broken")]
        public int SpiderIronOreBroken { get; set; }

        [JsonProperty("blaze_iron_ore_broken")]
        public int BlazeIronOreBroken { get; set; }

        [JsonProperty("herobrine_iron_ore_broken")]
        public int HerobrineIronOreBroken { get; set; }

        [JsonProperty("squid_iron_ore_broken")]
        public int SquidIronOreBroken { get; set; }

        [JsonProperty("shaman_iron_ore_broken")]
        public int ShamanIronOreBroken { get; set; }

        [JsonProperty("moleman_iron_ore_broken")]
        public int MolemanIronOreBroken { get; set; }

        [JsonProperty("pigman_iron_ore_broken")]
        public int PigmanIronOreBroken { get; set; }

        [JsonProperty("pirate_iron_ore_broken")]
        public int PirateIronOreBroken { get; set; }

        [JsonProperty("hunter_iron_ore_broken")]
        public int HunterIronOreBroken { get; set; }
        #endregion

        #region diamond ore
        [JsonProperty("diamond_ore_broken")]
        public int DiamondOreBroken { get; set; }

        [JsonProperty("skeleton_diamond_ore_broken")]
        public int SkeletonDiamondOreBroken { get; set; }

        [JsonProperty("arcanist_diamond_ore_broken")]
        public int ArcanistDiamondOreBroken { get; set; }

        [JsonProperty("dreadlord_diamond_ore_broken")]
        public int DreadlordDiamondOreBroken { get; set; }

        [JsonProperty("enderman_diamond_ore_broken")]
        public int EndermanDiamondOreBroken { get; set; }

        [JsonProperty("golem_diamond_ore_broken")]
        public int GolemDiamondOreBroken { get; set; }

        [JsonProperty("zombie_diamond_ore_broken")]
        public int ZombieDiamondOreBroken { get; set; }

        [JsonProperty("shaman_diamond_ore_broken")]
        public int ShamanDiamondOreBroken { get; set; }

        [JsonProperty("squid_diamond_ore_broken")]
        public int SquidDiamondOreBroken { get; set; }

        [JsonProperty("pirate_diamond_ore_broken")]
        public int PirateDiamondOreBroken { get; set; }
        #endregion

        #region wither damage
        [JsonProperty("wither_damage")]
        public int WitherDamage { get; set; }

        [JsonProperty("arcanist_wither_damage")]
        public int ArcanistWitherDamage { get; set; }

        [JsonProperty("zombie_wither_damage")]
        public int ZombieWitherDamage { get; set; }

        [JsonProperty("dreadlord_wither_damage")]
        public int DreadlordWitherDamage { get; set; }

        [JsonProperty("golem_wither_damage")]
        public int GolemWitherDamage { get; set; }

        [JsonProperty("enderman_wither_damage")]
        public int EndermanWitherDamage { get; set; }

        [JsonProperty("blaze_wither_damage")]
        public int BlazeWitherDamage { get; set; }

        [JsonProperty("spider_wither_damage")]
        public int SpiderWitherDamage { get; set; }

        [JsonProperty("hunter_wither_damage")]
        public int HunterWitherDamage { get; set; }

        [JsonProperty("creeper_wither_damage")]
        public int CreeperWitherDamage { get; set; }

        [JsonProperty("skeleton_wither_damage")]
        public int SkeletonWitherDamage { get; set; }
        #endregion

        #region wither kills
        [JsonProperty("wither_kills")]
        public int WitherKills { get; set; }

        [JsonProperty("arcanist_wither_kills")]
        public int ArcanistWitherKills { get; set; }

        [JsonProperty("zombie_wither_kills")]
        public int ZombieWitherKills { get; set; }

        [JsonProperty("dreadlord_wither_kills")]
        public int DreadlordWitherKills { get; set; }

        [JsonProperty("golem_wither_kills")]
        public int GolemWitherKills { get; set; }

        [JsonProperty("enderman_wither_kills")]
        public int EndermanWitherKills { get; set; }

        [JsonProperty("blaze_wither_kills")]
        public int BlazeWitherKills { get; set; }

        [JsonProperty("spider_wither_kills")]
        public int SpiderWitherKills { get; set; }

        [JsonProperty("hunter_wither_kills")]
        public int HunterWitherKills { get; set; }

        [JsonProperty("creeper_wither_kills")]
        public int CreeperWitherKills { get; set; }

        [JsonProperty("skeleton_wither_kills")]
        public int SkeletonWitherKills { get; set; }
        #endregion
    }
}