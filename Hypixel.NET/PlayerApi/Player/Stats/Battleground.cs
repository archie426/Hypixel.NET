using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.Stats.Battlegrounds;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Battleground
    {

        #region general
        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("chosen_class")]
        public string ChosenClass { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("selected_mount")]
        public string SelectedMount { get; set; }

        [JsonProperty("void_shards")]
        public int VoidShards { get; set; }

        [JsonProperty("weapon_inventory")]
        public List<WeaponInventory> WeaponInventory { get; set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("play_streak")]
        public int PlayStreak { get; set; }

        [JsonProperty("hotkeymode")]
        public bool Hotkeymode { get; set; }

        [JsonProperty("prestiged")]
        public List<string> PrestigedClasses { get; set; }
        #endregion

        #region general stats
        [JsonProperty("broken_inventory")]
        public int BrokenInventory { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("crafted")]
        public int Crafted { get; set; }

        [JsonProperty("crafted_epic")]
        public int CraftedEpic { get; set; }

        [JsonProperty("damage_prevented")]
        public long DamagePrevented { get; set; }

        [JsonProperty("damage_taken")]
        public long DamageTaken { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("life_leeched")]
        public long LifeLeeched { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("magic_dust")]
        public int MagicDust { get; set; }

        [JsonProperty("repaired")]
        public int Repaired { get; set; }

        [JsonProperty("repaired_common")]
        public int RepairedCommon { get; set; }

        [JsonProperty("repaired_epic")]
        public int RepairedEpic { get; set; }

        [JsonProperty("repaired_rare")]
        public int RepairedRare { get; set; }

        [JsonProperty("salvaged_dust_reward")]
        public int SalvagedDustReward { get; set; }

        [JsonProperty("salvaged_shards_reward")]
        public int SalvagedShardsReward { get; set; }

        [JsonProperty("salvaged_weapons")]
        public int SalvagedWeapons { get; set; }

        [JsonProperty("salvaged_weapons_common")]
        public int SalvagedWeaponsCommon { get; set; }

        [JsonProperty("salvaged_weapons_rare")]
        public int SalvagedWeaponsRare { get; set; }

        [JsonProperty("upgrade_random")]
        public int UpgradeRandom { get; set; }

        [JsonProperty("upgrade_random_epic")]
        public int UpgradeRandomEpic { get; set; }

        [JsonProperty("wins_blu")]
        public int WinsBlue { get; set; }

        [JsonProperty("wins_capturetheflag")]
        public int WinsCapturetheflag { get; set; }

        [JsonProperty("wins_capturetheflag_blu")]
        public int WinsCapturetheflagBlue { get; set; }

        [JsonProperty("wins_capturetheflag_red")]
        public int WinsCapturetheflagRed { get; set; }

        [JsonProperty("wins_domination")]
        public int WinsDomination { get; set; }

        [JsonProperty("wins_domination_blu")]
        public int WinsDominationBlue { get; set; }

        [JsonProperty("wins_domination_red")]
        public int WinsDominationRed { get; set; }

        [JsonProperty("wins_red")]
        public int WinsRed { get; set; }

        [JsonProperty("salvaged_weapons_epic")]
        public int SalvagedWeaponsEpic { get; set; }

        [JsonProperty("upgrade_crafted")]
        public int UpgradeCrafted { get; set; }

        [JsonProperty("upgrade_crafted_epic")]
        public int UpgradeCraftedEpic { get; set; }

        [JsonProperty("reroll_epic")]
        public int RerollEpic { get; set; }

        [JsonProperty("reroll")]
        public int Reroll { get; set; }

        [JsonProperty("repaired_legendary")]
        public int RepairedLegendary { get; set; }

        [JsonProperty("salvaged_weapons_legendary")]
        public int SalvagedWeaponsLegendary { get; set; }

        [JsonProperty("crafted_legendary")]
        public int CraftedLegendary { get; set; }

        [JsonProperty("reroll_legendary")]
        public int RerollLegendary { get; set; }

        [JsonProperty("afk_warned")]
        public int AfkWarned { get; set; }

        [JsonProperty("penalty")]
        public int Penalty { get; set; }

        [JsonProperty("upgrade_crafted_legendary")]
        public int UpgradeCraftedLegendary { get; set; }

        [JsonProperty("wins_teamdeathmatch")]
        public int WinsTeamdeathmatch { get; set; }

        [JsonProperty("wins_teamdeathmatch_blu")]
        public int WinsTeamdeathmatchBlue { get; set; }

        [JsonProperty("wins_teamdeathmatch_red")]
        public int WinsTeamdeathmatchRed { get; set; }

        [JsonProperty("crafted_rare")]
        public int CraftedRare { get; set; }

        [JsonProperty("reroll_common")]
        public int RerollCommon { get; set; }

        [JsonProperty("upgrade_random_legendary")]
        public int UpgradeRandomLegendary { get; set; }

        [JsonProperty("reward_inventory")]
        public int RewardInventory { get; set; }

        [JsonProperty("kills_capturetheflag")]
        public int CapturetheflagKills { get; set; }

        [JsonProperty("kills_teamdeathmatch")]
        public int TeamdeathmatchKills { get; set; }

        [JsonProperty("kills_domination")]
        public int DominationKills { get; set; }

        [JsonProperty("total_domination_score")]
        public int TotalDominationScore { get; set; }

        [JsonProperty("flag_returns")]
        public int FlagReturns { get; set; }

        [JsonProperty("mvp_count")]
        public int MvpCount { get; set; }

        [JsonProperty("dom_point_captures")]
        public int DomPointCaptures { get; set; }

        [JsonProperty("dom_point_defends")]
        public int DomPointDefends { get; set; }

        [JsonProperty("powerups_collected")]
        public int PowerupsCollected { get; set; }
        #endregion

        #region berserker
        [JsonProperty("berserker_plays")]
        public int BerserkerPlays { get; set; }

        [JsonProperty("damage_berserker")]
        public long BerserkerDamage { get; set; }

        [JsonProperty("damage_prevented_berserker")]
        public long BerserkerDamagePrevented { get; set; }

        [JsonProperty("heal_berserker")]
        public long BerserkerHealing { get; set; }

        [JsonProperty("life_leeched_berserker")]
        public long BerserkerLifeLeeched { get; set; }

        [JsonProperty("losses_berserker")]
        public int BerserkerLosses { get; set; }

        [JsonProperty("wins_berserker")]
        public int BerserkerWins { get; set; }
        #endregion

        #region defender
        [JsonProperty("damage_defender")]
        public long DefenderDamage { get; set; }

        [JsonProperty("damage_prevented_defender")]
        public long DefenderDamagePrevented { get; set; }

        [JsonProperty("defender_plays")]
        public int DefenderPlays { get; set; }

        [JsonProperty("heal_defender")]
        public long DefenderHealing { get; set; }

        [JsonProperty("losses_defender")]
        public int DefenderLosses { get; set; }

        [JsonProperty("wins_defender")]
        public int DefenderWins { get; set; }
        #endregion

        #region warrior
        [JsonProperty("damage_prevented_warrior")]
        public long WarriorDamagePrevented { get; set; }

        [JsonProperty("damage_warrior")]
        public long WarriorDamage { get; set; }

        [JsonProperty("heal_warrior")]
        public long WarriorHeal { get; set; }

        [JsonProperty("life_leeched_warrior")]
        public long WarriorLifeLeeched { get; set; }

        [JsonProperty("losses_warrior")]
        public int WarriorLosses { get; set; }

        [JsonProperty("warrior_cooldown")]
        public int WarriorCooldown { get; set; }

        [JsonProperty("warrior_critchance")]
        public int WarriorCritchance { get; set; }

        [JsonProperty("warrior_critmultiplier")]
        public int WarriorCritmultiplier { get; set; }

        [JsonProperty("warrior_energy")]
        public int WarriorEnergyLevel { get; set; }

        [JsonProperty("warrior_health")]
        public int WarriorHealthLevel { get; set; }

        [JsonProperty("warrior_plays")]
        public int WarriorPlays { get; set; }

        [JsonProperty("warrior_skill1")]
        public int WarriorSkill1Level { get; set; }

        [JsonProperty("warrior_skill2")]
        public int WarriorSkill2Level { get; set; }

        [JsonProperty("warrior_skill3")]
        public int WarriorSkill3Level { get; set; }

        [JsonProperty("warrior_skill4")]
        public int WarriorSkill4Level { get; set; }

        [JsonProperty("warrior_skill5")]
        public int WarriorSkill5Level { get; set; }

        [JsonProperty("warrior_spec")]
        public string WarriorSpec { get; set; }

        [JsonProperty("wins_warrior")]
        public int WarriorWins { get; set; }
        #endregion

        #region mage
        [JsonProperty("mage_spec")]
        public string MageSpec { get; set; }

        [JsonProperty("heal_mage")]
        public long MageHeal { get; set; }

        [JsonProperty("damage_prevented_mage")]
        public long MageDamagePrevented { get; set; }

        [JsonProperty("wins_mage")]
        public int MageWins { get; set; }

        [JsonProperty("damage_mage")]
        public int MageDamage { get; set; }

        [JsonProperty("mage_plays")]
        public int MagePlays { get; set; }

        [JsonProperty("losses_mage")]
        public int MageLosses { get; set; }

        [JsonProperty("mage_skill1")]
        public int MageSkill1Level { get; set; }

        [JsonProperty("mage_skill3")]
        public int MageSkill3Level { get; set; }

        [JsonProperty("mage_skill4")]
        public int MageSkill4Level { get; set; }

        [JsonProperty("mage_skill5")]
        public int MageSkill5Level { get; set; }

        [JsonProperty("mage_skill2")]
        public int MageSkill2Level { get; set; }

        [JsonProperty("mage_health")]
        public int MageHealthLevel { get; set; }

        [JsonProperty("mage_energy")]
        public int MageEnergyLevel { get; set; }

        [JsonProperty("mage_cooldown")]
        public int MageCooldownLevel { get; set; }

        [JsonProperty("mage_critchance")]
        public int MageCritchanceLevel { get; set; }

        [JsonProperty("mage_critmultiplier")]
        public int MageCritmultiplierLevel { get; set; }
        #endregion

        #region paladin
        [JsonProperty("paladin_spec")]
        public string PaladinSpec { get; set; }

        [JsonProperty("damage_paladin")]
        public long PaladinDamage { get; set; }

        [JsonProperty("paladin_plays")]
        public int PaladinPlays { get; set; }

        [JsonProperty("losses_paladin")]
        public int PaladinLosses { get; set; }

        [JsonProperty("heal_paladin")]
        public long PaladinHeals { get; set; }

        [JsonProperty("damage_prevented_paladin")]
        public int PaladinDamagePrevented { get; set; }

        [JsonProperty("wins_paladin")]
        public int PaladinWins { get; set; }

        [JsonProperty("paladin_skill5")]
        public int PaladinSkill5Level { get; set; }

        [JsonProperty("paladin_skill4")]
        public int PaladinSkill4Level { get; set; }

        [JsonProperty("paladin_skill3")]
        public int PaladinSkill3Level { get; set; }

        [JsonProperty("paladin_skill1")]
        public int PaladinSkill1Level { get; set; }

        [JsonProperty("paladin_skill2")]
        public int PaladinSkill2Level { get; set; }

        [JsonProperty("paladin_energy")]
        public int PaladinEnergyLevel { get; set; }

        [JsonProperty("paladin_critmultiplier")]
        public int PaladinCritmultiplierLevel { get; set; }

        [JsonProperty("paladin_health")]
        public int PaladinHealthLevel { get; set; }

        [JsonProperty("paladin_cooldown")]
        public int PaladinCooldownLevel { get; set; }

        [JsonProperty("paladin_critchance")]
        public int PaladinCritchanceLevel { get; set; }
        #endregion

        #region pyromancer
        [JsonProperty("damage_pyromancer")]
        public long PyromancerDamage { get; set; }

        [JsonProperty("heal_pyromancer")]
        public long PyromancerHeals { get; set; }

        [JsonProperty("damage_prevented_pyromancer")]
        public long PyromancerDamagePrevented { get; set; }

        [JsonProperty("pyromancer_plays")]
        public int PyromancerPlays { get; set; }

        [JsonProperty("wins_pyromancer")]
        public int PyromancerWins { get; set; }

        [JsonProperty("losses_pyromancer")]
        public int PyromancerLosses { get; set; }
        #endregion

        #region avenger
        [JsonProperty("losses_avenger")]
        public int AvengerLosses { get; set; }

        [JsonProperty("damage_avenger")]
        public int AvengerDamage { get; set; }

        [JsonProperty("avenger_plays")]
        public int PlaysAvenger { get; set; }

        [JsonProperty("heal_avenger")]
        public long AvengerHeals { get; set; }

        [JsonProperty("damage_prevented_avenger")]
        public long AvengerDamagePrevented { get; set; }

        [JsonProperty("wins_avenger")]
        public int AvengerWins { get; set; }
        #endregion

        #region cryomancer
        [JsonProperty("cryomancer_plays")]
        public int CryomancerPlays { get; set; }

        [JsonProperty("wins_cryomancer")]
        public int CryomancerWins { get; set; }

        [JsonProperty("heal_cryomancer")]
        public long CryomancerHeals { get; set; }

        [JsonProperty("damage_prevented_cryomancer")]
        public long CryomancerDamagePrevented { get; set; }

        [JsonProperty("damage_cryomancer")]
        public long CryomancerDamage { get; set; }

        [JsonProperty("losses_cryomancer")]
        public int CryomancerLosses { get; set; }
        #endregion

        #region aquamancer
        [JsonProperty("damage_prevented_aquamancer")]
        public long AquamancerDamagePrevented { get; set; }

        [JsonProperty("wins_aquamancer")]
        public int AquamancerWins { get; set; }

        [JsonProperty("damage_aquamancer")]
        public long AquamancerDamage { get; set; }

        [JsonProperty("aquamancer_plays")]
        public int AquamancerPlays { get; set; }

        [JsonProperty("heal_aquamancer")]
        public long AquamancerHeals { get; set; }

        [JsonProperty("losses_aquamancer")]
        public int AquamancerLosses { get; set; }
        #endregion

        #region shaman
        [JsonProperty("shaman_spec")]
        public string ShamanSpec { get; set; }

        [JsonProperty("damage_shaman")]
        public long ShamanDamage { get; set; }

        [JsonProperty("shaman_plays")]
        public int ShamanPlays { get; set; }

        [JsonProperty("damage_prevented_shaman")]
        public long ShamanDamagePrevented { get; set; }

        [JsonProperty("heal_shaman")]
        public long ShamanHeals { get; set; }

        [JsonProperty("wins_shaman")]
        public int ShamanWins { get; set; }

        [JsonProperty("losses_shaman")]
        public int ShamanLosses { get; set; }

        [JsonProperty("shaman_skill1")]
        public int ShamanSkill1Level { get; set; }

        [JsonProperty("shaman_skill3")]
        public int ShamanSkill3Level { get; set; }

        [JsonProperty("shaman_skill2")]
        public int ShamanSkill2Level { get; set; }

        [JsonProperty("shaman_skill4")]
        public int ShamanSkill4Level { get; set; }

        [JsonProperty("shaman_skill5")]
        public int ShamanSkill5Level { get; set; }

        [JsonProperty("shaman_critmultiplier")]
        public int ShamanCritmultiplierLevel { get; set; }

        [JsonProperty("shaman_energy")]
        public int ShamanEnergyLevel { get; set; }

        [JsonProperty("shaman_critchance")]
        public int ShamanCritchanceLevel { get; set; }

        [JsonProperty("shaman_cooldown")]
        public int ShamanCooldownLevel { get; set; }

        [JsonProperty("shaman_health")]
        public int ShamanHealthLevel { get; set; }
        #endregion

        #region earthwarden
        [JsonProperty("damage_prevented_earthwarden")]
        public long EarthwardenDamagePrevented { get; set; }

        [JsonProperty("damage_earthwarden")]
        public long EarthwardenDamage { get; set; }

        [JsonProperty("earthwarden_plays")]
        public int EarthwardenPlays { get; set; }

        [JsonProperty("heal_earthwarden")]
        public long EarthwardenHeals { get; set; }

        [JsonProperty("wins_earthwarden")]
        public int EarthwardenWins { get; set; }

        [JsonProperty("losses_earthwarden")]
        public int EarthwardenLosses { get; set; }
        #endregion

        #region thunderlord
        [JsonProperty("heal_thunderlord")]
        public long ThunderlordHeals { get; set; }

        [JsonProperty("thunderlord_plays")]
        public int ThunderlordPlays { get; set; }

        [JsonProperty("damage_thunderlord")]
        public long ThunderlordDamage { get; set; }

        [JsonProperty("losses_thunderlord")]
        public int ThunderlordLosses { get; set; }

        [JsonProperty("damage_prevented_thunderlord")]
        public long ThunderlordDamagePrevented { get; set; }

        [JsonProperty("wins_thunderlord")]
        public int ThunderlordWins { get; set; }
        #endregion

        #region crusader
        [JsonProperty("crusader_plays")]
        public int CrusaderPlays { get; set; }

        [JsonProperty("heal_crusader")]
        public long CrusaderHeals { get; set; }

        [JsonProperty("wins_crusader")]
        public int CrusaderWins { get; set; }

        [JsonProperty("damage_crusader")]
        public long CrusaderDamage { get; set; }

        [JsonProperty("damage_prevented_crusader")]
        public long CrusaderDamagePrevented { get; set; }

        [JsonProperty("losses_crusader")]
        public int CrusaderLosses { get; set; }
        #endregion

        #region protector
        [JsonProperty("wins_protector")]
        public int ProtectorWins { get; set; }

        [JsonProperty("heal_protector")]
        public long ProtectorHeals { get; set; }

        [JsonProperty("protector_plays")]
        public int ProtectorPlays { get; set; }

        [JsonProperty("damage_prevented_protector")]
        public long ProtectorDamagePrevented { get; set; }

        [JsonProperty("damage_protector")]
        public long ProtectorDamage { get; set; }

        [JsonProperty("losses_protector")]
        public int ProtectorLosses { get; set; }
        #endregion
    }
}