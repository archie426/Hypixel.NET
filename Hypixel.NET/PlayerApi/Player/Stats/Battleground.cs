using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Battleground
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("mage_spec")]
        public string MageSpec { get; set; }

        [JsonProperty("selected_mount")]
        public string SelectedMount { get; set; }

        [JsonProperty("warrior_spec")]
        public string WarriorSpec { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("shaman_spec")]
        public string ShamanSpec { get; set; }

        [JsonProperty("paladin_spec")]
        public string PaladinSpec { get; set; }

        [JsonProperty("chosen_class")]
        public string ChosenClass { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("play_streak")]
        public long PlayStreak { get; set; }

        [JsonProperty("wins_capturetheflag")]
        public long WinsCapturetheflag { get; set; }

        [JsonProperty("wins_berserker")]
        public long WinsBerserker { get; set; }

        [JsonProperty("berserker_plays")]
        public long BerserkerPlays { get; set; }

        [JsonProperty("flag_conquer_team")]
        public long FlagConquerTeam { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("powerups_collected")]
        public long PowerupsCollected { get; set; }

        [JsonProperty("damage_prevented")]
        public long DamagePrevented { get; set; }

        [JsonProperty("kills_capturetheflag")]
        public long KillsCapturetheflag { get; set; }

        [JsonProperty("wins_red")]
        public long WinsRed { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("heal")]
        public long Heal { get; set; }

        [JsonProperty("life_leeched_warrior")]
        public long LifeLeechedWarrior { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("damage_prevented_warrior")]
        public long DamagePreventedWarrior { get; set; }

        [JsonProperty("wins_capturetheflag_red")]
        public long WinsCapturetheflagRed { get; set; }

        [JsonProperty("damage_prevented_berserker")]
        public long DamagePreventedBerserker { get; set; }

        [JsonProperty("life_leeched_berserker")]
        public long LifeLeechedBerserker { get; set; }

        [JsonProperty("damage_berserker")]
        public long DamageBerserker { get; set; }

        [JsonProperty("flag_returns")]
        public long FlagReturns { get; set; }

        [JsonProperty("damage_warrior")]
        public long DamageWarrior { get; set; }

        [JsonProperty("wins_warrior")]
        public long WinsWarrior { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("heal_warrior")]
        public long HealWarrior { get; set; }

        [JsonProperty("heal_berserker")]
        public long HealBerserker { get; set; }

        [JsonProperty("warrior_plays")]
        public long WarriorPlays { get; set; }

        [JsonProperty("life_leeched")]
        public long LifeLeeched { get; set; }

        [JsonProperty("damage_taken")]
        public long DamageTaken { get; set; }

        [JsonProperty("broken_inventory")]
        public long BrokenInventory { get; set; }
    }
}