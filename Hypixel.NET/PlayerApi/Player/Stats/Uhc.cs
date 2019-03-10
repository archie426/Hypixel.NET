using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Uhc
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("equippedKit")]
        public string EquippedKit { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("perk_weaponsmith_line_a")]
        public long PerkWeaponsmithLineA { get; set; }

        [JsonProperty("perk_weaponsmith_line_b")]
        public long PerkWeaponsmithLineB { get; set; }

        [JsonProperty("perk_weaponsmith_line_c")]
        public long PerkWeaponsmithLineC { get; set; }

        [JsonProperty("cache3")]
        public bool Cache3 { get; set; }

        [JsonProperty("clearup_achievement")]
        public bool ClearupAchievement { get; set; }

        [JsonProperty("heads_eaten")]
        public long HeadsEaten { get; set; }

        [JsonProperty("kit_MAGIC_TOOLS")]
        public long KitMagicTools { get; set; }

        [JsonProperty("kit_WORKING_TOOLS")]
        public long KitWorkingTools { get; set; }

        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; set; }

        [JsonProperty("perk_bloodcraft_line_a")]
        public long PerkBloodcraftLineA { get; set; }

        [JsonProperty("perk_bloodcraft_line_b")]
        public long PerkBloodcraftLineB { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("kills_solo")]
        public long KillsSolo { get; set; }

        [JsonProperty("heads_eaten_solo")]
        public long HeadsEatenSolo { get; set; }

        [JsonProperty("kills_solo2")]
        public long KillsSolo2 { get; set; }

        [JsonProperty("wins_solo")]
        public long WinsSolo { get; set; }

        [JsonProperty("saved_stats")]
        public bool SavedStats { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("perk_engineering_line_a")]
        public long PerkEngineeringLineA { get; set; }

        [JsonProperty("perk_engineering_line_b")]
        public long PerkEngineeringLineB { get; set; }

        [JsonProperty("perk_engineering_line_c")]
        public long PerkEngineeringLineC { get; set; }

        [JsonProperty("perk_alchemy_line_a")]
        public long PerkAlchemyLineA { get; set; }

        [JsonProperty("perk_alchemy_line_b")]
        public long PerkAlchemyLineB { get; set; }

        [JsonProperty("perk_alchemy_line_c")]
        public long PerkAlchemyLineC { get; set; }

        [JsonProperty("perk_hunter_line_a")]
        public long PerkHunterLineA { get; set; }

        [JsonProperty("perk_hunter_line_b")]
        public long PerkHunterLineB { get; set; }

        [JsonProperty("perk_hunter_line_c")]
        public long PerkHunterLineC { get; set; }

        [JsonProperty("perk_survivalism_line_a")]
        public long PerkSurvivalismLineA { get; set; }

        [JsonProperty("perk_survivalism_line_b")]
        public long PerkSurvivalismLineB { get; set; }

        [JsonProperty("perk_survivalism_line_c")]
        public long PerkSurvivalismLineC { get; set; }

        [JsonProperty("perk_toolsmithing_line_a")]
        public long PerkToolsmithingLineA { get; set; }

        [JsonProperty("perk_toolsmithing_line_b")]
        public long PerkToolsmithingLineB { get; set; }

        [JsonProperty("perk_toolsmithing_line_c")]
        public long PerkToolsmithingLineC { get; set; }

        [JsonProperty("perk_enchanting_line_a")]
        public long PerkEnchantingLineA { get; set; }

        [JsonProperty("perk_enchanting_line_b")]
        public long PerkEnchantingLineB { get; set; }

        [JsonProperty("perk_enchanting_line_c")]
        public long PerkEnchantingLineC { get; set; }

        [JsonProperty("perk_bloodcraft_line_c")]
        public long PerkBloodcraftLineC { get; set; }
    }
}