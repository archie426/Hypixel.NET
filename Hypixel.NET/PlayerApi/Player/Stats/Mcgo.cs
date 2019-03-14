using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Mcgo
    {
        #region general stats
        [JsonProperty("bombs_defused")]
        public int BombsDefused { get; set; }

        [JsonProperty("bombs_planted")]
        public int BombsPlanted { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("cop_kills")]
        public int CopKills { get; set; }

        [JsonProperty("criminal_kills")]
        public int CriminalKills { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("game_wins")]
        public int GameWins { get; set; }

        [JsonProperty("headshot_kills")]
        public int HeadshotKills { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("round_wins")]
        public int RoundWins { get; set; }

        [JsonProperty("shots_fired")]
        public int ShotsFired { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("criminal_kills_deathmatch")]
        public int CriminalKillsDeathmatch { get; set; }

        [JsonProperty("kills_deathmatch")]
        public int KillsDeathmatch { get; set; }

        [JsonProperty("cop_kills_deathmatch")]
        public int CopKillsDeathmatch { get; set; }

        [JsonProperty("game_wins_deathmatch")]
        public int GameWinsDeathmatch { get; set; }

        [JsonProperty("deaths_deathmatch")]
        public int DeathsDeathmatch { get; set; }

        [JsonProperty("grenade_kills")]
        public int McgoGrenadeKills { get; set; }

        [JsonProperty("grenadeKills")]
        public int GrenadeKills { get; set; }
        #endregion

        #region weapons
        [JsonProperty("carbine_cost_reduction")]
        public int CarbineCostReductionLevel { get; set; }

        [JsonProperty("carbine_damage_increase")]
        public int CarbineDamageIncreaseLevel { get; set; }

        [JsonProperty("carbine_recoil_reduction")]
        public int CarbineRecoilReductionLevel { get; set; }

        [JsonProperty("carbine_reload_speed_reduction")]
        public int CarbineReloadSpeedReductionLevel { get; set; }

        [JsonProperty("knife_attack_delay")]
        public int KnifeAttackDelayLevel { get; set; }

        [JsonProperty("knife_damage_increase")]
        public int KnifeDamageIncreaseLevel { get; set; }

        [JsonProperty("magnum_cost_reduction")]
        public int MagnumCostReductionLevel { get; set; }

        [JsonProperty("magnum_damage_increase")]
        public int MagnumDamageIncreaseLevel { get; set; }

        [JsonProperty("magnum_recoil_reduction")]
        public int MagnumRecoilReductionLevel { get; set; }

        [JsonProperty("magnum_reload_speed_reduction")]
        public int MagnumReloadSpeedReductionLevel { get; set; }

        [JsonProperty("pistol_damage_increase")]
        public int PistolDamageIncreaseLevel { get; set; }

        [JsonProperty("pistol_recoil_reduction")]
        public int PistolRecoilReductionLevel { get; set; }

        [JsonProperty("pistol_reload_speed_reduction")]
        public int PistolReloadSpeedReductionLevel { get; set; }

        [JsonProperty("rifle_cost_reduction")]
        public int RifleCostReductionLevel { get; set; }

        [JsonProperty("rifle_damage_increase")]
        public int RifleDamageIncreaseLevel { get; set; }

        [JsonProperty("rifle_recoil_reduction")]
        public int RifleRecoilReductionLevel { get; set; }

        [JsonProperty("rifle_reload_speed_reduction")]
        public int RifleReloadSpeedReductionLevel { get; set; }

        [JsonProperty("shotgun_cost_reduction")]
        public int ShotgunCostReductionLevel { get; set; }

        [JsonProperty("shotgun_damage_increase")]
        public int ShotgunDamageIncreaseLevel { get; set; }

        [JsonProperty("shotgun_recoil_reduction")]
        public int ShotgunRecoilReductionLevel { get; set; }

        [JsonProperty("shotgun_reload_speed_reduction")]
        public int ShotgunReloadSpeedReductionLevel { get; set; }

        [JsonProperty("smg_cost_reduction")]
        public int SmgCostReductionLevel { get; set; }

        [JsonProperty("smg_damage_increase")]
        public int SmgDamageIncreaseLevel { get; set; }

        [JsonProperty("smg_recoil_reduction")]
        public int SmgRecoilReductionLevel { get; set; }

        [JsonProperty("smg_reload_speed_reduction")]
        public int SmgReloadSpeedReductionLevel { get; set; }

        [JsonProperty("sniper_charge_bonus")]
        public int SniperChargeBonusLevel { get; set; }

        [JsonProperty("sniper_cost_reduction")]
        public int SniperCostReductionLevel { get; set; }

        [JsonProperty("sniper_damage_increase")]
        public int SniperDamageIncreaseLevel { get; set; }

        [JsonProperty("sniper_reload_speed_reduction")]
        public int SniperReloadSpeedReductionLevel { get; set; }
        #endregion

        #region game wins
        [JsonProperty("game_wins_overgrown")]
        public int GameWinsOvergrown { get; set; }

        [JsonProperty("game_wins_temple")]
        public int GameWinsTemple { get; set; }

        [JsonProperty("game_wins_carrier")]
        public int GameWinsCarrier { get; set; }

        [JsonProperty("game_wins_atomic")]
        public int GameWinsAtomic { get; set; }

        [JsonProperty("game_wins_alleyway")]
        public int GameWinsAlleyway { get; set; }

        [JsonProperty("game_wins_sandstorm")]
        public int GameWinsSandstorm { get; set; }

        [JsonProperty("game_wins_reserve")]
        public int GameWinsReserve { get; set; }

        [JsonProperty("game_wins_melon factory")]
        public int GameWinsMelonFactory { get; set; }
        #endregion

        #region cosmetic items
        [JsonProperty("selectedCreeperHelmetDev")]
        public string SelectedCreeperHelmet { get; set; }

        [JsonProperty("selectedOcelotChestplateDev")]
        public string SelectedOcelotChestplate { get; set; }

        [JsonProperty("selectedCreeperChestplateDev")]
        public string SelectedCreeperChestplate { get; set; }

        [JsonProperty("selectedCarbineDev")]
        public string SelectedCarbine { get; set; }

        [JsonProperty("selectedKnifeDev")]
        public string SelectedKnife { get; set; }

        [JsonProperty("selectedPistolDev")]
        public string SelectedPistol { get; set; }

        [JsonProperty("selectedSmgDev")]
        public string SelectedSmg { get; set; }

        [JsonProperty("selectedOcelotHelmetDev")]
        public string SelectedOcelotHelmet { get; set; }

        [JsonProperty("selectedRifleDev")]
        public string SelectedRifle { get; set; }

        [JsonProperty("selectedMagnumDev")]
        public string SelectedMagnum { get; set; }

        [JsonProperty("selectedShotgunDev")]
        public string SelectedShotgun { get; set; }
        #endregion

        #region misc upgrades
        [JsonProperty("body_armor_cost")]
        public int BodyArmourCostLevel { get; set; }

        [JsonProperty("pocket_change")]
        public int PocketChangeLevel { get; set; }

        [JsonProperty("strength_training")]
        public int StrengthTrainingLevel { get; set; }
        #endregion
    }
}