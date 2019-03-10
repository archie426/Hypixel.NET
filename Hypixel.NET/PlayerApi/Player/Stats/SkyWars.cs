using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SkyWars
    {
        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("public string activeKit_TEAM")]
        public string ActiveKit_TEAM { get; set; }

        [JsonProperty("soul_well")]
        public int soul_well { get; set; }

        [JsonProperty("public bool usedSoulWell")]
        public bool usedSoulWell { get; set; }

        [JsonProperty("mega_mining_expertise")]
        public int mega_mining_expertise { get; set; }

        [JsonProperty("win_streak")]
        public int win_streak { get; set; }

        [JsonProperty("survived_players")]
        public int survived_players { get; set; }

        [JsonProperty("kills_kit_mining_team_default")]
        public int kills_kit_mining_team_default { get; set; }

        [JsonProperty("arrows_hit")]
        public int arrows_hit { get; set; }

        [JsonProperty("blocks_broken")]
        public int blocks_broken { get; set; }

        [JsonProperty("blocks_placed")]
        public int blocks_placed { get; set; }

        [JsonProperty("coins")]
        public int coins { get; set; }

        [JsonProperty("survived_players_team")]
        public int survived_players_team { get; set; }

        [JsonProperty("losses_kit_mining_team_default")]
        public int losses_kit_mining_team_default { get; set; }

        [JsonProperty("losses_team_insane")]
        public int losses_team_insane { get; set; }

        [JsonProperty("deaths_kit_mining_team_default")]
        public int deaths_kit_mining_team_default { get; set; }

        [JsonProperty("kills")]
        public int kills { get; set; }

        [JsonProperty("deaths_team")]
        public int deaths_team { get; set; }

        [JsonProperty("arrows_shot")]
        public int arrows_shot { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("kills_team")]
        public int kills_team { get; set; }

        [JsonProperty("deaths_team_insane")]
        public int deaths_team_insane { get; set; }

        [JsonProperty("kills_team_insane")]
        public int kills_team_insane { get; set; }

        [JsonProperty("survived_players_kit_mining_team_default")]
        public int survived_players_kit_mining_team_default { get; set; }

        [JsonProperty("souls_gathered")]
        public int souls_gathered { get; set; }

        [JsonProperty("items_enchanted")]
        public int items_enchanted { get; set; }

        [JsonProperty("deaths")]
        public int deaths { get; set; }

        [JsonProperty("quits")]
        public int quits { get; set; }

        [JsonProperty("losses_team")]
        public int losses_team { get; set; }

        [JsonProperty("souls")]
        public int souls { get; set; }

        [JsonProperty("egg_thrown")]
        public int egg_thrown { get; set; }

        [JsonProperty("losses_team_normal")]
        public int losses_team_normal { get; set; }

        [JsonProperty("deaths_team_normal")]
        public int deaths_team_normal { get; set; }

        [JsonProperty("kills_team_normal")]
        public int kills_team_normal { get; set; }

        [JsonProperty("losses_kit_supporting_team_healer")]
        public int losses_kit_supporting_team_healer { get; set; }

        [JsonProperty("deaths_kit_supporting_team_healer")]
        public int deaths_kit_supporting_team_healer { get; set; }

        [JsonProperty("kills_kit_supporting_team_healer")]
        public int kills_kit_supporting_team_healer { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_healer")]
        public int survived_players_kit_supporting_team_healer { get; set; }

        [JsonProperty("games_kit_supporting_team_healer")]
        public int games_kit_supporting_team_healer { get; set; }

        [JsonProperty("assists_kit_supporting_team_healer")]
        public int assists_kit_supporting_team_healer { get; set; }

        [JsonProperty("games_team")]
        public int games_team { get; set; }

        [JsonProperty("assists_team")]
        public int assists_team { get; set; }

        [JsonProperty("assists")]
        public int assists { get; set; }

        [JsonProperty("games")]
        public int games { get; set; }

        [JsonProperty("public string activeKit_MEGA")]
        public string activeKit_MEGA { get; set; }

        [JsonProperty("wins_kit_mega_mega_default")]
        public int wins_kit_mega_mega_default { get; set; }

        [JsonProperty("games_mega")]
        public int games_mega { get; set; }

        [JsonProperty("kills_kit_mega_mega_default")]
        public int kills_kit_mega_mega_default { get; set; }

        [JsonProperty("enderpearls_thrown")]
        public int enderpearls_thrown { get; set; }

        [JsonProperty("kills_mega")]
        public int kills_mega { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("survived_players_mega")]
        public int survived_players_mega { get; set; }

        [JsonProperty("wins_mega_normal")]
        public int wins_mega_normal { get; set; }

        [JsonProperty("games_kit_mega_mega_default")]
        public int games_kit_mega_mega_default { get; set; }

        [JsonProperty("survived_players_kit_mega_mega_default")]
        public int survived_players_kit_mega_mega_default { get; set; }

        [JsonProperty("wins_mega")]
        public int wins_mega { get; set; }

        [JsonProperty("kills_mega_normal")]
        public int kills_mega_normal { get; set; }

        [JsonProperty("assists_mega")]
        public int assists_mega { get; set; }

        [JsonProperty("assists_kit_mega_mega_default")]
        public int assists_kit_mega_mega_default { get; set; }

        [JsonProperty("paid_souls")]
        public int paid_souls { get; set; }

        [JsonProperty("deaths_kit_supporting_team_ecologist")]
        public int deaths_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("kills_kit_supporting_team_ecologist")]
        public int kills_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_ecologist")]
        public int survived_players_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("losses_kit_supporting_team_ecologist")]
        public int losses_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("losses_mega_normal")]
        public int losses_mega_normal { get; set; }

        [JsonProperty("deaths_kit_mega_mega_default")]
        public int deaths_kit_mega_mega_default { get; set; }

        [JsonProperty("deaths_mega_normal")]
        public int deaths_mega_normal { get; set; }

        [JsonProperty("losses_mega")]
        public int losses_mega { get; set; }

        [JsonProperty("deaths_mega")]
        public int deaths_mega { get; set; }

        [JsonProperty("losses_kit_mega_mega_default")]
        public int losses_kit_mega_mega_default { get; set; }

        [JsonProperty("solo_instant_smelting")]
        public int solo_instant_smelting { get; set; }

        [JsonProperty("refill_chest_destroy")]
        public int refill_chest_destroy { get; set; }

        [JsonProperty("public string activeKit_SOLO")]
        public string activeKit_SOLO { get; set; }

        [JsonProperty("survived_players_solo")]
        public int survived_players_solo { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_default")]
        public int survived_players_kit_basic_solo_default { get; set; }

        [JsonProperty("deaths_kit_basic_solo_default")]
        public int deaths_kit_basic_solo_default { get; set; }

        [JsonProperty("losses_kit_basic_solo_default")]
        public int losses_kit_basic_solo_default { get; set; }

        [JsonProperty("losses_solo_normal")]
        public int losses_solo_normal { get; set; }

        [JsonProperty("deaths_solo")]
        public int deaths_solo { get; set; }

        [JsonProperty("deaths_solo_normal")]
        public int deaths_solo_normal { get; set; }

        [JsonProperty("losses_solo")]
        public int losses_solo { get; set; }

        [JsonProperty("wins_team_normal")]
        public int wins_team_normal { get; set; }

        [JsonProperty("wins_team")]
        public int wins_team { get; set; }

        [JsonProperty("wins_kit_supporting_team_healer")]
        public int wins_kit_supporting_team_healer { get; set; }

        [JsonProperty("soul_well_rares")]
        public int soul_well_rares { get; set; }

        [JsonProperty("public string activeCage")]
        public string activeCage { get; set; }

        [JsonProperty("solo_resistance_boost")]
        public int solo_resistance_boost { get; set; }

        [JsonProperty("games_solo")]
        public int games_solo { get; set; }

        [JsonProperty("kills_solo_normal")]
        public int kills_solo_normal { get; set; }

        [JsonProperty("wins_solo_normal")]
        public int wins_solo_normal { get; set; }

        [JsonProperty("kills_kit_basic_solo_default")]
        public int kills_kit_basic_solo_default { get; set; }

        [JsonProperty("wins_kit_basic_solo_default")]
        public int wins_kit_basic_solo_default { get; set; }

        [JsonProperty("wins_solo")]
        public int wins_solo { get; set; }

        [JsonProperty("kills_solo")]
        public int kills_solo { get; set; }

        [JsonProperty("games_kit_basic_solo_default")]
        public int games_kit_basic_solo_default { get; set; }

        [JsonProperty("games_kit_supporting_team_ecologist")]
        public int games_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("mega_blazing_arrows")]
        public int mega_blazing_arrows { get; set; }

        [JsonProperty("assists_kit_supporting_team_ecologist")]
        public int assists_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("soul_well_legendaries")]
        public int soul_well_legendaries { get; set; }

        [JsonProperty("survived_players_kit_defending_team_guardian")]
        public int survived_players_kit_defending_team_guardian { get; set; }

        [JsonProperty("losses_kit_defending_team_guardian")]
        public int losses_kit_defending_team_guardian { get; set; }

        [JsonProperty("deaths_kit_defending_team_guardian")]
        public int deaths_kit_defending_team_guardian { get; set; }

        [JsonProperty("kills_kit_defending_team_guardian")]
        public int kills_kit_defending_team_guardian { get; set; }

        [JsonProperty("deaths_kit_basic_solo_armorsmith")]
        public int deaths_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("kills_kit_basic_solo_armorsmith")]
        public int kills_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("games_kit_basic_solo_armorsmith")]
        public int games_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("losses_kit_basic_solo_armorsmith")]
        public int losses_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_armorsmith")]
        public int survived_players_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("wins_kit_basic_solo_armorsmith")]
        public int wins_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("wins_kit_supporting_team_ecologist")]
        public int wins_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("mega_ender_mastery")]
        public int mega_ender_mastery { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_scout")]
        public int survived_players_kit_attacking_team_scout { get; set; }

        [JsonProperty("deaths_kit_attacking_team_scout")]
        public int deaths_kit_attacking_team_scout { get; set; }

        [JsonProperty("losses_kit_attacking_team_scout")]
        public int losses_kit_attacking_team_scout { get; set; }

        [JsonProperty("kills_kit_attacking_team_scout")]
        public int kills_kit_attacking_team_scout { get; set; }

        [JsonProperty("team_mining_expertise")]
        public int team_mining_expertise { get; set; }

        [JsonProperty("games_kit_attacking_team_scout")]
        public int games_kit_attacking_team_scout { get; set; }

        [JsonProperty("assists_kit_attacking_team_scout")]
        public int assists_kit_attacking_team_scout { get; set; }

        [JsonProperty("wins_kit_attacking_team_scout")]
        public int wins_kit_attacking_team_scout { get; set; }

        [JsonProperty("solo_mining_expertise")]
        public int solo_mining_expertise { get; set; }

        [JsonProperty("kit_mega_mega_armorer")]
        public int kit_mega_mega_armorer { get; set; }

        [JsonProperty("losses_kit_mega_mega_armorer")]
        public int losses_kit_mega_mega_armorer { get; set; }

        [JsonProperty("deaths_kit_mega_mega_armorer")]
        public int deaths_kit_mega_mega_armorer { get; set; }

        [JsonProperty("survived_players_kit_mega_mega_armorer")]
        public int survived_players_kit_mega_mega_armorer { get; set; }

        [JsonProperty("assists_kit_mega_mega_armorer")]
        public int assists_kit_mega_mega_armorer { get; set; }

        [JsonProperty("kills_kit_mega_mega_armorer")]
        public int kills_kit_mega_mega_armorer { get; set; }

        [JsonProperty("wins_kit_mega_mega_armorer")]
        public int wins_kit_mega_mega_armorer { get; set; }

        [JsonProperty("losses_solo_insane")]
        public int losses_solo_insane { get; set; }

        [JsonProperty("deaths_solo_insane")]
        public int deaths_solo_insane { get; set; }

        [JsonProperty("team_ender_mastery")]
        public int team_ender_mastery { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_cannoneer")]
        public int survived_players_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("losses_kit_advanced_solo_cannoneer")]
        public int losses_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_cannoneer")]
        public int deaths_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("kills_kit_advanced_solo_cannoneer")]
        public int kills_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("kills_kit_defending_team_armorer")]
        public int kills_kit_defending_team_armorer { get; set; }

        [JsonProperty("losses_kit_defending_team_armorer")]
        public int losses_kit_defending_team_armorer { get; set; }

        [JsonProperty("survived_players_kit_defending_team_armorer")]
        public int survived_players_kit_defending_team_armorer { get; set; }

        [JsonProperty("deaths_kit_defending_team_armorer")]
        public int deaths_kit_defending_team_armorer { get; set; }

        [JsonProperty("games_kit_mega_mega_armorer")]
        public int games_kit_mega_mega_armorer { get; set; }

        [JsonProperty("games_kit_defending_team_guardian")]
        public int games_kit_defending_team_guardian { get; set; }

        [JsonProperty("mega_rusher")]
        public int mega_rusher { get; set; }

        [JsonProperty("assists_kit_defending_team_guardian")]
        public int assists_kit_defending_team_guardian { get; set; }

        [JsonProperty("games_kit_defending_team_armorer")]
        public int games_kit_defending_team_armorer { get; set; }

        [JsonProperty("assists_kit_defending_team_armorer")]
        public int assists_kit_defending_team_armorer { get; set; }

        [JsonProperty("wins_kit_defending_team_armorer")]
        public int wins_kit_defending_team_armorer { get; set; }

        [JsonProperty("assists_kit_attacking_team_knight")]
        public int assists_kit_attacking_team_knight { get; set; }

        [JsonProperty("losses_kit_attacking_team_knight")]
        public int losses_kit_attacking_team_knight { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_knight")]
        public int survived_players_kit_attacking_team_knight { get; set; }

        [JsonProperty("deaths_kit_attacking_team_knight")]
        public int deaths_kit_attacking_team_knight { get; set; }

        [JsonProperty("kills_kit_attacking_team_knight")]
        public int kills_kit_attacking_team_knight { get; set; }

        [JsonProperty("wins_kit_attacking_team_knight")]
        public int wins_kit_attacking_team_knight { get; set; }

        [JsonProperty("games_kit_attacking_team_knight")]
        public int games_kit_attacking_team_knight { get; set; }

        [JsonProperty("extra_wheels")]
        public int extra_wheels { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_snowman")]
        public int survived_players_kit_basic_solo_snowman { get; set; }

        [JsonProperty("kills_kit_basic_solo_snowman")]
        public int kills_kit_basic_solo_snowman { get; set; }

        [JsonProperty("deaths_kit_basic_solo_snowman")]
        public int deaths_kit_basic_solo_snowman { get; set; }

        [JsonProperty("losses_kit_basic_solo_snowman")]
        public int losses_kit_basic_solo_snowman { get; set; }

        [JsonProperty("wins_kit_basic_solo_snowman")]
        public int wins_kit_basic_solo_snowman { get; set; }

        [JsonProperty("games_kit_basic_solo_snowman")]
        public int games_kit_basic_solo_snowman { get; set; }

        [JsonProperty("assists_solo")]
        public int assists_solo { get; set; }

        [JsonProperty("assists_kit_basic_solo_snowman")]
        public int assists_kit_basic_solo_snowman { get; set; }

        [JsonProperty("wins_team_insane")]
        public int wins_team_insane { get; set; }

        [JsonProperty("wins_solo_insane")]
        public int wins_solo_insane { get; set; }

        [JsonProperty("kills_solo_insane")]
        public int kills_solo_insane { get; set; }

        [JsonProperty("team_blazing_arrows")]
        public int team_blazing_arrows { get; set; }

        [JsonProperty("solo_ender_mastery")]
        public int solo_ender_mastery { get; set; }

        [JsonProperty("solo_arrow_recovery")]
        public int solo_arrow_recovery { get; set; }

        [JsonProperty("team_instant_smelting")]
        public int team_instant_smelting { get; set; }

        [JsonProperty("xezbeth_luck")]
        public int xezbeth_luck { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_knight")]
        public int deaths_kit_advanced_solo_knight { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_knight")]
        public int survived_players_kit_advanced_solo_knight { get; set; }

        [JsonProperty("losses_kit_advanced_solo_knight")]
        public int losses_kit_advanced_solo_knight { get; set; }

        [JsonProperty("kills_kit_advanced_solo_knight")]
        public int kills_kit_advanced_solo_knight { get; set; }

        [JsonProperty("kills_weekly_b")]
        public int kills_weekly_b { get; set; }

        [JsonProperty("kills_monthly_b")]
        public int kills_monthly_b { get; set; }

        [JsonProperty("team_resistance_boost")]
        public int team_resistance_boost { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_snowman")]
        public int survived_players_kit_attacking_team_snowman { get; set; }

        [JsonProperty("deaths_kit_attacking_team_snowman")]
        public int deaths_kit_attacking_team_snowman { get; set; }

        [JsonProperty("kills_kit_attacking_team_snowman")]
        public int kills_kit_attacking_team_snowman { get; set; }

        [JsonProperty("losses_kit_attacking_team_snowman")]
        public int losses_kit_attacking_team_snowman { get; set; }

        [JsonProperty("assists_kit_attacking_team_snowman")]
        public int assists_kit_attacking_team_snowman { get; set; }

        [JsonProperty("games_kit_attacking_team_snowman")]
        public int games_kit_attacking_team_snowman { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_farmer")]
        public int deaths_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_farmer")]
        public int survived_players_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("kills_kit_advanced_solo_farmer")]
        public int kills_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("losses_kit_advanced_solo_farmer")]
        public int losses_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("wins_kit_attacking_team_snowman")]
        public int wins_kit_attacking_team_snowman { get; set; }

        [JsonProperty("kills_weekly_a")]
        public int kills_weekly_a { get; set; }

        [JsonProperty("games_kit_advanced_solo_armorer")]
        public int games_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("kills_kit_advanced_solo_armorer")]
        public int kills_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_armorer")]
        public int survived_players_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_armorer")]
        public int deaths_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("losses_kit_advanced_solo_armorer")]
        public int losses_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("team_speed_boost")]
        public int team_speed_boost { get; set; }

        [JsonProperty("games_kit_advanced_solo_knight")]
        public int games_kit_advanced_solo_knight { get; set; }

        [JsonProperty("wins_kit_advanced_solo_knight")]
        public int wins_kit_advanced_solo_knight { get; set; }

        [JsonProperty("kills_monthly_a")]
        public int kills_monthly_a { get; set; }

        [JsonProperty("assists_kit_advanced_solo_knight")]
        public int assists_kit_advanced_solo_knight { get; set; }

        [JsonProperty("mega_arrow_recovery")]
        public int mega_arrow_recovery { get; set; }

        [JsonProperty("assists_kit_advanced_solo_armorer")]
        public int assists_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("wins_kit_advanced_solo_armorer")]
        public int wins_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("__invalid_name__survived_players_kit_defending_team_baseball_player")]
        public int __invalid_name__survived_players_kit_defending_team_baseball_player { get; set; }

        [JsonProperty("__invalid_name__kills_kit_defending_team_baseball_player")]
        public int __invalid_name__kills_kit_defending_team_baseball_player { get; set; }

        [JsonProperty("__invalid_name__deaths_kit_defending_team_baseball_player")]
        public int __invalid_name__deaths_kit_defending_team_baseball_player { get; set; }

        [JsonProperty("__invalid_name__losses_kit_defending_team_baseball_player")]
        public int __invalid_name__losses_kit_defending_team_baseball_player { get; set; }

        [JsonProperty("__invalid_name__assists_kit_defending_team_baseball_player")]
        public int __invalid_name__assists_kit_defending_team_baseball_player { get; set; }

        [JsonProperty("solo_blazing_arrows")]
        public int solo_blazing_arrows { get; set; }

        [JsonProperty("wins_kit_advanced_solo_cannoneer")]
        public int wins_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("games_kit_advanced_solo_cannoneer")]
        public int games_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("assists_kit_advanced_solo_cannoneer")]
        public int assists_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("team_arrow_recovery")]
        public int team_arrow_recovery { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_armorsmith")]
        public int survived_players_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("losses_kit_supporting_team_armorsmith")]
        public int losses_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("deaths_kit_supporting_team_armorsmith")]
        public int deaths_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("deaths_kit_basic_solo_troll")]
        public int deaths_kit_basic_solo_troll { get; set; }

        [JsonProperty("losses_kit_basic_solo_troll")]
        public int losses_kit_basic_solo_troll { get; set; }

        [JsonProperty("kills_kit_basic_solo_troll")]
        public int kills_kit_basic_solo_troll { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_troll")]
        public int survived_players_kit_basic_solo_troll { get; set; }

        [JsonProperty("public string activeKit_RANKED")]
        public string activeKit_RANKED { get; set; }

        [JsonProperty("winstreak_ranked")]
        public int winstreak_ranked { get; set; }

        [JsonProperty("killstreak")]
        public int killstreak { get; set; }

        [JsonProperty("games_ranked")]
        public int games_ranked { get; set; }

        [JsonProperty("wins_ranked_normal")]
        public int wins_ranked_normal { get; set; }

        [JsonProperty("kills_kit_ranked_ranked_default")]
        public int kills_kit_ranked_ranked_default { get; set; }

        [JsonProperty("killstreak_ranked")]
        public int killstreak_ranked { get; set; }

        [JsonProperty("kills_ranked_normal")]
        public int kills_ranked_normal { get; set; }

        [JsonProperty("games_kit_ranked_ranked_default")]
        public int games_kit_ranked_ranked_default { get; set; }

        [JsonProperty("survived_players_ranked")]
        public int survived_players_ranked { get; set; }

        [JsonProperty("kills_ranked")]
        public int kills_ranked { get; set; }

        [JsonProperty("killstreak_kit_ranked_ranked_default")]
        public int killstreak_kit_ranked_ranked_default { get; set; }

        [JsonProperty("winstreak")]
        public int winstreak { get; set; }

        [JsonProperty("winstreak_kit_ranked_ranked_default")]
        public int winstreak_kit_ranked_ranked_default { get; set; }

        [JsonProperty("survived_players_kit_ranked_ranked_default")]
        public int survived_players_kit_ranked_ranked_default { get; set; }

        [JsonProperty("wins_kit_ranked_ranked_default")]
        public int wins_kit_ranked_ranked_default { get; set; }

        [JsonProperty("wins_ranked")]
        public int wins_ranked { get; set; }

        [JsonProperty("highestKillstreak")]
        public int highestKillstreak { get; set; }

        [JsonProperty("highestWinstreak")]
        public int highestWinstreak { get; set; }

        [JsonProperty("killstreak_kit_defending_team_armorer")]
        public int killstreak_kit_defending_team_armorer { get; set; }

        [JsonProperty("killstreak_team")]
        public int killstreak_team { get; set; }

        [JsonProperty("winstreak_team")]
        public int winstreak_team { get; set; }

        [JsonProperty("winstreak_kit_defending_team_armorer")]
        public int winstreak_kit_defending_team_armorer { get; set; }

        [JsonProperty("killstreak_solo")]
        public int killstreak_solo { get; set; }

        [JsonProperty("winstreak_kit_basic_solo_snowman")]
        public int winstreak_kit_basic_solo_snowman { get; set; }

        [JsonProperty("winstreak_solo")]
        public int winstreak_solo { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_snowman")]
        public int killstreak_kit_basic_solo_snowman { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_knight")]
        public int winstreak_kit_advanced_solo_knight { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_knight")]
        public int killstreak_kit_advanced_solo_knight { get; set; }

        [JsonProperty("ranked_instant_smelting")]
        public int ranked_instant_smelting { get; set; }

        [JsonProperty("deaths_kit_ranked_ranked_default")]
        public int deaths_kit_ranked_ranked_default { get; set; }

        [JsonProperty("losses_ranked")]
        public int losses_ranked { get; set; }

        [JsonProperty("deaths_ranked_normal")]
        public int deaths_ranked_normal { get; set; }

        [JsonProperty("losses_kit_ranked_ranked_default")]
        public int losses_kit_ranked_ranked_default { get; set; }

        [JsonProperty("losses_ranked_normal")]
        public int losses_ranked_normal { get; set; }

        [JsonProperty("deaths_ranked")]
        public int deaths_ranked { get; set; }

        [JsonProperty("assists_ranked")]
        public int assists_ranked { get; set; }

        [JsonProperty("assists_kit_ranked_ranked_default")]
        public int assists_kit_ranked_ranked_default { get; set; }

        [JsonProperty("solo_speed_boost")]
        public int solo_speed_boost { get; set; }

        [JsonProperty("team_nourishment")]
        public int team_nourishment { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_knight")]
        public int winstreak_kit_attacking_team_knight { get; set; }

        [JsonProperty("solo_nourishment")]
        public int solo_nourishment { get; set; }

        [JsonProperty("solo_bulldozer")]
        public int solo_bulldozer { get; set; }

        [JsonProperty("killstreak_kit_supporting_team_armorsmith")]
        public int killstreak_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("winstreak_kit_supporting_team_armorsmith")]
        public int winstreak_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("wins_kit_supporting_team_armorsmith")]
        public int wins_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("kills_kit_supporting_team_armorsmith")]
        public int kills_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("assists_kit_supporting_team_armorsmith")]
        public int assists_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("games_kit_supporting_team_armorsmith")]
        public int games_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_armorer")]
        public int winstreak_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_armorer")]
        public int killstreak_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_armorsmith")]
        public int killstreak_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("winstreak_kit_basic_solo_armorsmith")]
        public int winstreak_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("games_kit_advanced_solo_farmer")]
        public int games_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("wins_kit_advanced_solo_farmer")]
        public int wins_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_farmer")]
        public int killstreak_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_farmer")]
        public int winstreak_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("solo_fat")]
        public int solo_fat { get; set; }

        [JsonProperty("mega_nourishment")]
        public int mega_nourishment { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_knight")]
        public int killstreak_kit_attacking_team_knight { get; set; }

        [JsonProperty("solo_knowledge")]
        public int solo_knowledge { get; set; }

        [JsonProperty("solo_revenge")]
        public int solo_revenge { get; set; }

        [JsonProperty("assists_kit_basic_solo_armorsmith")]
        public int assists_kit_basic_solo_armorsmith { get; set; }

        [JsonProperty("winstreak_kit_enderchest_solo_enderchest")]
        public int winstreak_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("games_kit_enderchest_solo_enderchest")]
        public int games_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("wins_kit_enderchest_solo_enderchest")]
        public int wins_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("kills_kit_enderchest_solo_enderchest")]
        public int kills_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("survived_players_kit_enderchest_solo_enderchest")]
        public int survived_players_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("killstreak_kit_enderchest_solo_enderchest")]
        public int killstreak_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("team_fat")]
        public int team_fat { get; set; }

        [JsonProperty("losses_kit_basic_solo_rookie")]
        public int losses_kit_basic_solo_rookie { get; set; }

        [JsonProperty("deaths_kit_basic_solo_rookie")]
        public int deaths_kit_basic_solo_rookie { get; set; }

        [JsonProperty("killstreak_kit_mega_mega_armorer")]
        public int killstreak_kit_mega_mega_armorer { get; set; }

        [JsonProperty("winstreak_kit_mega_mega_armorer")]
        public int winstreak_kit_mega_mega_armorer { get; set; }

        [JsonProperty("winstreak_mega")]
        public int winstreak_mega { get; set; }

        [JsonProperty("killstreak_mega")]
        public int killstreak_mega { get; set; }

        [JsonProperty("team_knowledge")]
        public int team_knowledge { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_snowman")]
        public int winstreak_kit_attacking_team_snowman { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_snowman")]
        public int killstreak_kit_attacking_team_snowman { get; set; }

        [JsonProperty("team_savior")]
        public int team_savior { get; set; }

        [JsonProperty("assists_kit_advanced_solo_farmer")]
        public int assists_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_cannoneer")]
        public int winstreak_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_cannoneer")]
        public int killstreak_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("survived_players_kit_mining_team_cannoneer")]
        public int survived_players_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("kills_kit_mining_team_cannoneer")]
        public int kills_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("losses_kit_mining_team_cannoneer")]
        public int losses_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("deaths_kit_mining_team_cannoneer")]
        public int deaths_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("games_kit_mining_team_cannoneer")]
        public int games_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("losses_kit_enderchest_solo_enderchest")]
        public int losses_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("deaths_kit_enderchest_solo_enderchest")]
        public int deaths_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("assists_kit_enderchest_solo_enderchest")]
        public int assists_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("solo_juggernaut")]
        public int solo_juggernaut { get; set; }

        [JsonProperty("mega_tank")]
        public int mega_tank { get; set; }

        [JsonProperty("mega_juggernaut")]
        public int mega_juggernaut { get; set; }

        [JsonProperty("mega_instant_smelting")]
        public int mega_instant_smelting { get; set; }

        [JsonProperty("team_juggernaut")]
        public int team_juggernaut { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_rookie")]
        public int survived_players_kit_basic_solo_rookie { get; set; }

        [JsonProperty("kills_kit_basic_solo_rookie")]
        public int kills_kit_basic_solo_rookie { get; set; }

        [JsonProperty("games_kit_basic_solo_rookie")]
        public int games_kit_basic_solo_rookie { get; set; }

        [JsonProperty("wins_kit_basic_solo_rookie")]
        public int wins_kit_basic_solo_rookie { get; set; }

        [JsonProperty("winstreak_kit_basic_solo_rookie")]
        public int winstreak_kit_basic_solo_rookie { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_rookie")]
        public int killstreak_kit_basic_solo_rookie { get; set; }

        [JsonProperty("games_kit_advanced_solo_enderman")]
        public int games_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("losses_kit_advanced_solo_enderman")]
        public int losses_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_enderman")]
        public int survived_players_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_enderman")]
        public int deaths_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("harvesting_season")]
        public int harvesting_season { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_enderman")]
        public int winstreak_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("wins_kit_advanced_solo_enderman")]
        public int wins_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("kills_kit_advanced_solo_enderman")]
        public int kills_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_enderman")]
        public int killstreak_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("losses_kit_supporting_team_rookie")]
        public int losses_kit_supporting_team_rookie { get; set; }

        [JsonProperty("deaths_kit_supporting_team_rookie")]
        public int deaths_kit_supporting_team_rookie { get; set; }

        [JsonProperty("kills_kit_supporting_team_rookie")]
        public int kills_kit_supporting_team_rookie { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_rookie")]
        public int survived_players_kit_supporting_team_rookie { get; set; }

        [JsonProperty("kills_kit_attacking_team_enderman")]
        public int kills_kit_attacking_team_enderman { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_enderman")]
        public int killstreak_kit_attacking_team_enderman { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_enderman")]
        public int survived_players_kit_attacking_team_enderman { get; set; }

        [JsonProperty("wins_kit_attacking_team_enderman")]
        public int wins_kit_attacking_team_enderman { get; set; }

        [JsonProperty("games_kit_attacking_team_enderman")]
        public int games_kit_attacking_team_enderman { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_enderman")]
        public int winstreak_kit_attacking_team_enderman { get; set; }

        [JsonProperty("deaths_kit_ranked_ranked_armorer")]
        public int deaths_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("losses_kit_ranked_ranked_armorer")]
        public int losses_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("wins_kit_ranked_ranked_armorer")]
        public int wins_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("winstreak_kit_ranked_ranked_armorer")]
        public int winstreak_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("games_kit_ranked_ranked_armorer")]
        public int games_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("survived_players_kit_ranked_ranked_armorer")]
        public int survived_players_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("kills_kit_ranked_ranked_armorer")]
        public int kills_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("killstreak_kit_ranked_ranked_armorer")]
        public int killstreak_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("assists_kit_ranked_ranked_armorer")]
        public int assists_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("quickjoin_uses_Aquarius")]
        public int quickjoin_uses_Aquarius { get; set; }

        [JsonProperty("quickjoin_uses_total")]
        public int quickjoin_uses_total { get; set; }

        [JsonProperty("quickjoin_uses_Shattered")]
        public int quickjoin_uses_Shattered { get; set; }

        [JsonProperty("quickjoin_uses_random")]
        public int quickjoin_uses_random { get; set; }

        [JsonProperty("mega_marksmanship")]
        public int mega_marksmanship { get; set; }

        [JsonProperty("quickjoin_uses_Tribute")]
        public int quickjoin_uses_Tribute { get; set; }

        [JsonProperty("quickjoin_uses_Plateau")]
        public int quickjoin_uses_Plateau { get; set; }

        [JsonProperty("quickjoin_uses_Atuin")]
        public int quickjoin_uses_Atuin { get; set; }

        [JsonProperty("quickjoin_uses_Dwarven")]
        public int quickjoin_uses_Dwarven { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_hunter")]
        public int winstreak_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("kills_kit_advanced_solo_hunter")]
        public int kills_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("games_kit_advanced_solo_hunter")]
        public int games_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_hunter")]
        public int survived_players_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("wins_kit_advanced_solo_hunter")]
        public int wins_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_hunter")]
        public int killstreak_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("solo_lucky_charm")]
        public int solo_lucky_charm { get; set; }

        [JsonProperty("team_lucky_charm")]
        public int team_lucky_charm { get; set; }

        [JsonProperty("longest_bow_shot_team")]
        public int longest_bow_shot_team { get; set; }

        [JsonProperty("longest_bow_shot")]
        public int longest_bow_shot { get; set; }

        [JsonProperty("fastest_win")]
        public int fastest_win { get; set; }

        [JsonProperty("fastest_win_team")]
        public int fastest_win_team { get; set; }

        [JsonProperty("longest_bow_shot_kit_defending_team_armorer")]
        public int longest_bow_shot_kit_defending_team_armorer { get; set; }

        [JsonProperty("fastest_win_kit_defending_team_armorer")]
        public int fastest_win_kit_defending_team_armorer { get; set; }

        [JsonProperty("melee_kills_team")]
        public int melee_kills_team { get; set; }

        [JsonProperty("void_kills")]
        public int void_kills { get; set; }

        [JsonProperty("chests_opened_team")]
        public int chests_opened_team { get; set; }

        [JsonProperty("chests_opened_kit_defending_team_armorer")]
        public int chests_opened_kit_defending_team_armorer { get; set; }

        [JsonProperty("time_played")]
        public int time_played { get; set; }

        [JsonProperty("most_kills_game")]
        public int most_kills_game { get; set; }

        [JsonProperty("void_kills_kit_defending_team_armorer")]
        public int void_kills_kit_defending_team_armorer { get; set; }

        [JsonProperty("arrows_shot_team")]
        public int arrows_shot_team { get; set; }

        [JsonProperty("melee_kills_kit_defending_team_armorer")]
        public int melee_kills_kit_defending_team_armorer { get; set; }

        [JsonProperty("time_played_kit_defending_team_armorer")]
        public int time_played_kit_defending_team_armorer { get; set; }

        [JsonProperty("chests_opened")]
        public int chests_opened { get; set; }

        [JsonProperty("melee_kills")]
        public int melee_kills { get; set; }

        [JsonProperty("arrows_hit_team")]
        public int arrows_hit_team { get; set; }

        [JsonProperty("most_kills_game_team")]
        public int most_kills_game_team { get; set; }

        [JsonProperty("time_played_team")]
        public int time_played_team { get; set; }

        [JsonProperty("most_kills_game_kit_defending_team_armorer")]
        public int most_kills_game_kit_defending_team_armorer { get; set; }

        [JsonProperty("arrows_hit_kit_defending_team_armorer")]
        public int arrows_hit_kit_defending_team_armorer { get; set; }

        [JsonProperty("void_kills_team")]
        public int void_kills_team { get; set; }

        [JsonProperty("arrows_shot_kit_defending_team_armorer")]
        public int arrows_shot_kit_defending_team_armorer { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_knight")]
        public int fastest_win_kit_attacking_team_knight { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_knight")]
        public int longest_bow_shot_kit_attacking_team_knight { get; set; }

        [JsonProperty("time_played_kit_attacking_team_knight")]
        public int time_played_kit_attacking_team_knight { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_knight")]
        public int void_kills_kit_attacking_team_knight { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_knight")]
        public int arrows_hit_kit_attacking_team_knight { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_knight")]
        public int melee_kills_kit_attacking_team_knight { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_knight")]
        public int most_kills_game_kit_attacking_team_knight { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_knight")]
        public int arrows_shot_kit_attacking_team_knight { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_knight")]
        public int chests_opened_kit_attacking_team_knight { get; set; }

        [JsonProperty("mega_lucky_charm")]
        public int mega_lucky_charm { get; set; }

        [JsonProperty("team_bridger")]
        public int team_bridger { get; set; }

        [JsonProperty("chests_opened_kit_mega_mega_armorer")]
        public int chests_opened_kit_mega_mega_armorer { get; set; }

        [JsonProperty("chests_opened_mega")]
        public int chests_opened_mega { get; set; }

        [JsonProperty("most_kills_game_mega")]
        public int most_kills_game_mega { get; set; }

        [JsonProperty("most_kills_game_kit_mega_mega_armorer")]
        public int most_kills_game_kit_mega_mega_armorer { get; set; }

        [JsonProperty("void_kills_mega")]
        public int void_kills_mega { get; set; }

        [JsonProperty("void_kills_kit_mega_mega_armorer")]
        public int void_kills_kit_mega_mega_armorer { get; set; }

        [JsonProperty("time_played_kit_mega_mega_armorer")]
        public int time_played_kit_mega_mega_armorer { get; set; }

        [JsonProperty("time_played_mega")]
        public int time_played_mega { get; set; }

        [JsonProperty("melee_kills_kit_mega_mega_armorer")]
        public int melee_kills_kit_mega_mega_armorer { get; set; }

        [JsonProperty("arrows_shot_kit_mega_mega_armorer")]
        public int arrows_shot_kit_mega_mega_armorer { get; set; }

        [JsonProperty("melee_kills_mega")]
        public int melee_kills_mega { get; set; }

        [JsonProperty("arrows_shot_mega")]
        public int arrows_shot_mega { get; set; }

        [JsonProperty("longest_bow_shot_kit_mega_mega_armorer")]
        public int longest_bow_shot_kit_mega_mega_armorer { get; set; }

        [JsonProperty("longest_bow_shot_mega")]
        public int longest_bow_shot_mega { get; set; }

        [JsonProperty("arrows_hit_kit_mega_mega_armorer")]
        public int arrows_hit_kit_mega_mega_armorer { get; set; }

        [JsonProperty("arrows_hit_mega")]
        public int arrows_hit_mega { get; set; }

        [JsonProperty("fastest_win_kit_mega_mega_armorer")]
        public int fastest_win_kit_mega_mega_armorer { get; set; }

        [JsonProperty("fastest_win_mega")]
        public int fastest_win_mega { get; set; }

        [JsonProperty("longest_bow_shot_kit_enderchest_solo_enderchest")]
        public int longest_bow_shot_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("fastest_win_kit_enderchest_solo_enderchest")]
        public int fastest_win_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("fastest_win_solo")]
        public int fastest_win_solo { get; set; }

        [JsonProperty("longest_bow_shot_solo")]
        public int longest_bow_shot_solo { get; set; }

        [JsonProperty("melee_kills_solo")]
        public int melee_kills_solo { get; set; }

        [JsonProperty("most_kills_game_kit_enderchest_solo_enderchest")]
        public int most_kills_game_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("arrows_hit_kit_enderchest_solo_enderchest")]
        public int arrows_hit_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("arrows_hit_solo")]
        public int arrows_hit_solo { get; set; }

        [JsonProperty("melee_kills_kit_enderchest_solo_enderchest")]
        public int melee_kills_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("most_kills_game_solo")]
        public int most_kills_game_solo { get; set; }

        [JsonProperty("chests_opened_solo")]
        public int chests_opened_solo { get; set; }

        [JsonProperty("time_played_solo")]
        public int time_played_solo { get; set; }

        [JsonProperty("time_played_kit_enderchest_solo_enderchest")]
        public int time_played_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("arrows_shot_kit_enderchest_solo_enderchest")]
        public int arrows_shot_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("chests_opened_kit_enderchest_solo_enderchest")]
        public int chests_opened_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("arrows_shot_solo")]
        public int arrows_shot_solo { get; set; }

        [JsonProperty("longest_bow_shot_kit_mining_team_cannoneer")]
        public int longest_bow_shot_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("arrows_hit_kit_mining_team_cannoneer")]
        public int arrows_hit_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("chests_opened_kit_mining_team_cannoneer")]
        public int chests_opened_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("arrows_shot_kit_mining_team_cannoneer")]
        public int arrows_shot_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("time_played_kit_mining_team_cannoneer")]
        public int time_played_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("void_kills_kit_enderchest_solo_enderchest")]
        public int void_kills_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("void_kills_solo")]
        public int void_kills_solo { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_snowman")]
        public int longest_bow_shot_kit_attacking_team_snowman { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_snowman")]
        public int fastest_win_kit_attacking_team_snowman { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_snowman")]
        public int void_kills_kit_attacking_team_snowman { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_snowman")]
        public int arrows_shot_kit_attacking_team_snowman { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_snowman")]
        public int melee_kills_kit_attacking_team_snowman { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_snowman")]
        public int arrows_hit_kit_attacking_team_snowman { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_snowman")]
        public int most_kills_game_kit_attacking_team_snowman { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_snowman")]
        public int chests_opened_kit_attacking_team_snowman { get; set; }

        [JsonProperty("time_played_kit_attacking_team_snowman")]
        public int time_played_kit_attacking_team_snowman { get; set; }

        [JsonProperty("mob_kills_kit_enderchest_solo_enderchest")]
        public int mob_kills_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("mob_kills")]
        public int mob_kills { get; set; }

        [JsonProperty("mob_kills_solo")]
        public int mob_kills_solo { get; set; }

        [JsonProperty("void_kills_kit_basic_solo_snowman")]
        public int void_kills_kit_basic_solo_snowman { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_snowman")]
        public int chests_opened_kit_basic_solo_snowman { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_snowman")]
        public int most_kills_game_kit_basic_solo_snowman { get; set; }

        [JsonProperty("time_played_kit_basic_solo_snowman")]
        public int time_played_kit_basic_solo_snowman { get; set; }

        [JsonProperty("longest_bow_shot_kit_basic_solo_snowman")]
        public int longest_bow_shot_kit_basic_solo_snowman { get; set; }

        [JsonProperty("arrows_shot_kit_basic_solo_snowman")]
        public int arrows_shot_kit_basic_solo_snowman { get; set; }

        [JsonProperty("arrows_hit_kit_basic_solo_snowman")]
        public int arrows_hit_kit_basic_solo_snowman { get; set; }

        [JsonProperty("longest_bow_shot_kit_basic_solo_grenade")]
        public int longest_bow_shot_kit_basic_solo_grenade { get; set; }

        [JsonProperty("fastest_win_kit_basic_solo_grenade")]
        public int fastest_win_kit_basic_solo_grenade { get; set; }

        [JsonProperty("melee_kills_kit_basic_solo_grenade")]
        public int melee_kills_kit_basic_solo_grenade { get; set; }

        [JsonProperty("arrows_shot_kit_basic_solo_grenade")]
        public int arrows_shot_kit_basic_solo_grenade { get; set; }

        [JsonProperty("winstreak_kit_basic_solo_grenade")]
        public int winstreak_kit_basic_solo_grenade { get; set; }

        [JsonProperty("time_played_kit_basic_solo_grenade")]
        public int time_played_kit_basic_solo_grenade { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_grenade")]
        public int most_kills_game_kit_basic_solo_grenade { get; set; }

        [JsonProperty("kills_kit_basic_solo_grenade")]
        public int kills_kit_basic_solo_grenade { get; set; }

        [JsonProperty("games_kit_basic_solo_grenade")]
        public int games_kit_basic_solo_grenade { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_grenade")]
        public int survived_players_kit_basic_solo_grenade { get; set; }

        [JsonProperty("wins_kit_basic_solo_grenade")]
        public int wins_kit_basic_solo_grenade { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_grenade")]
        public int killstreak_kit_basic_solo_grenade { get; set; }

        [JsonProperty("arrows_hit_kit_basic_solo_grenade")]
        public int arrows_hit_kit_basic_solo_grenade { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_grenade")]
        public int chests_opened_kit_basic_solo_grenade { get; set; }

        [JsonProperty("mega_bridger")]
        public int mega_bridger { get; set; }

        [JsonProperty("mob_kills_kit_defending_team_armorer")]
        public int mob_kills_kit_defending_team_armorer { get; set; }

        [JsonProperty("mob_kills_team")]
        public int mob_kills_team { get; set; }

        [JsonProperty("longest_bow_shot_kit_supporting_team_armorsmith")]
        public int longest_bow_shot_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("void_kills_kit_supporting_team_armorsmith")]
        public int void_kills_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("most_kills_game_kit_supporting_team_armorsmith")]
        public int most_kills_game_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("chests_opened_kit_supporting_team_armorsmith")]
        public int chests_opened_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("time_played_kit_supporting_team_armorsmith")]
        public int time_played_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("arrows_hit_kit_supporting_team_armorsmith")]
        public int arrows_hit_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("arrows_shot_kit_supporting_team_armorsmith")]
        public int arrows_shot_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("melee_kills_kit_supporting_team_armorsmith")]
        public int melee_kills_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("most_kills_game_kit_advanced_solo_knight")]
        public int most_kills_game_kit_advanced_solo_knight { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_knight")]
        public int time_played_kit_advanced_solo_knight { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_knight")]
        public int chests_opened_kit_advanced_solo_knight { get; set; }

        [JsonProperty("melee_kills_kit_advanced_solo_knight")]
        public int melee_kills_kit_advanced_solo_knight { get; set; }

        [JsonProperty("void_kills_kit_advanced_solo_knight")]
        public int void_kills_kit_advanced_solo_knight { get; set; }

        [JsonProperty("chests_opened_kit_ranked_ranked_armorer")]
        public int chests_opened_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("chests_opened_ranked")]
        public int chests_opened_ranked { get; set; }

        [JsonProperty("time_played_ranked")]
        public int time_played_ranked { get; set; }

        [JsonProperty("time_played_kit_ranked_ranked_armorer")]
        public int time_played_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("fastest_win_kit_ranked_ranked_armorer")]
        public int fastest_win_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("fastest_win_ranked")]
        public int fastest_win_ranked { get; set; }

        [JsonProperty("void_kills_kit_ranked_ranked_armorer")]
        public int void_kills_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("void_kills_ranked")]
        public int void_kills_ranked { get; set; }

        [JsonProperty("most_kills_game_ranked")]
        public int most_kills_game_ranked { get; set; }

        [JsonProperty("most_kills_game_kit_ranked_ranked_armorer")]
        public int most_kills_game_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("longest_bow_shot_kit_advanced_solo_armorer")]
        public int longest_bow_shot_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("fastest_win_kit_advanced_solo_armorer")]
        public int fastest_win_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("arrows_hit_kit_advanced_solo_armorer")]
        public int arrows_hit_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_armorer")]
        public int chests_opened_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("most_kills_game_kit_advanced_solo_armorer")]
        public int most_kills_game_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("arrows_shot_kit_advanced_solo_armorer")]
        public int arrows_shot_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("void_kills_kit_advanced_solo_armorer")]
        public int void_kills_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_armorer")]
        public int time_played_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("melee_kills_kit_ranked_ranked_armorer")]
        public int melee_kills_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("melee_kills_ranked")]
        public int melee_kills_ranked { get; set; }

        [JsonProperty("longest_bow_shot_ranked")]
        public int longest_bow_shot_ranked { get; set; }

        [JsonProperty("longest_bow_shot_kit_ranked_ranked_armorer")]
        public int longest_bow_shot_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("arrows_hit_ranked")]
        public int arrows_hit_ranked { get; set; }

        [JsonProperty("arrows_hit_kit_ranked_ranked_armorer")]
        public int arrows_hit_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("arrows_shot_ranked")]
        public int arrows_shot_ranked { get; set; }

        [JsonProperty("arrows_shot_kit_ranked_ranked_armorer")]
        public int arrows_shot_kit_ranked_ranked_armorer { get; set; }

        [JsonProperty("melee_kills_kit_advanced_solo_armorer")]
        public int melee_kills_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("fastest_win_kit_advanced_solo_knight")]
        public int fastest_win_kit_advanced_solo_knight { get; set; }

        [JsonProperty("longest_bow_shot_kit_advanced_solo_knight")]
        public int longest_bow_shot_kit_advanced_solo_knight { get; set; }

        [JsonProperty("arrows_hit_kit_advanced_solo_knight")]
        public int arrows_hit_kit_advanced_solo_knight { get; set; }

        [JsonProperty("arrows_shot_kit_advanced_solo_knight")]
        public int arrows_shot_kit_advanced_solo_knight { get; set; }

        [JsonProperty("mob_kills_mega")]
        public int mob_kills_mega { get; set; }

        [JsonProperty("mob_kills_kit_mega_mega_armorer")]
        public int mob_kills_kit_mega_mega_armorer { get; set; }

        [JsonProperty("solo_bridger")]
        public int solo_bridger { get; set; }

        [JsonProperty("mob_kills_kit_advanced_solo_armorer")]
        public int mob_kills_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("most_kills_game_kit_mining_team_cannoneer")]
        public int most_kills_game_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("void_kills_kit_mining_team_cannoneer")]
        public int void_kills_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("most_kills_game_kit_supporting_team_ecologist")]
        public int most_kills_game_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("melee_kills_kit_supporting_team_ecologist")]
        public int melee_kills_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("void_kills_kit_supporting_team_ecologist")]
        public int void_kills_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("chests_opened_kit_supporting_team_ecologist")]
        public int chests_opened_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("time_played_kit_supporting_team_ecologist")]
        public int time_played_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("fastest_win_kit_supporting_team_ecologist")]
        public int fastest_win_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("winstreak_kit_supporting_team_ecologist")]
        public int winstreak_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("killstreak_kit_supporting_team_ecologist")]
        public int killstreak_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("longest_bow_shot_kit_supporting_team_ecologist")]
        public int longest_bow_shot_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("arrows_hit_kit_supporting_team_ecologist")]
        public int arrows_hit_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("arrows_shot_kit_supporting_team_ecologist")]
        public int arrows_shot_kit_supporting_team_ecologist { get; set; }

        [JsonProperty("melee_kills_kit_mining_team_cannoneer")]
        public int melee_kills_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("melee_kills_kit_basic_solo_snowman")]
        public int melee_kills_kit_basic_solo_snowman { get; set; }

        [JsonProperty("fastest_win_kit_basic_solo_snowman")]
        public int fastest_win_kit_basic_solo_snowman { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_cannoneer")]
        public int time_played_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_cannoneer")]
        public int chests_opened_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("quickjoin_uses_LongIsland")]
        public int quickjoin_uses_LongIsland { get; set; }

        [JsonProperty("losses_kit_attacking_team_enderman")]
        public int losses_kit_attacking_team_enderman { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_enderman")]
        public int void_kills_kit_attacking_team_enderman { get; set; }

        [JsonProperty("deaths_kit_attacking_team_enderman")]
        public int deaths_kit_attacking_team_enderman { get; set; }

        [JsonProperty("time_played_kit_attacking_team_enderman")]
        public int time_played_kit_attacking_team_enderman { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_enderman")]
        public int chests_opened_kit_attacking_team_enderman { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_enderman")]
        public int most_kills_game_kit_attacking_team_enderman { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_grenade")]
        public int longest_bow_shot_kit_attacking_team_grenade { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_grenade")]
        public int fastest_win_kit_attacking_team_grenade { get; set; }

        [JsonProperty("kills_kit_attacking_team_grenade")]
        public int kills_kit_attacking_team_grenade { get; set; }

        [JsonProperty("time_played_kit_attacking_team_grenade")]
        public int time_played_kit_attacking_team_grenade { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_grenade")]
        public int winstreak_kit_attacking_team_grenade { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_grenade")]
        public int arrows_shot_kit_attacking_team_grenade { get; set; }

        [JsonProperty("games_kit_attacking_team_grenade")]
        public int games_kit_attacking_team_grenade { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_grenade")]
        public int void_kills_kit_attacking_team_grenade { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_grenade")]
        public int arrows_hit_kit_attacking_team_grenade { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_grenade")]
        public int chests_opened_kit_attacking_team_grenade { get; set; }

        [JsonProperty("assists_kit_attacking_team_grenade")]
        public int assists_kit_attacking_team_grenade { get; set; }

        [JsonProperty("wins_kit_attacking_team_grenade")]
        public int wins_kit_attacking_team_grenade { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_grenade")]
        public int most_kills_game_kit_attacking_team_grenade { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_grenade")]
        public int survived_players_kit_attacking_team_grenade { get; set; }

        [JsonProperty("mob_kills_kit_attacking_team_grenade")]
        public int mob_kills_kit_attacking_team_grenade { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_grenade")]
        public int killstreak_kit_attacking_team_grenade { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_grenade")]
        public int melee_kills_kit_attacking_team_grenade { get; set; }

        [JsonProperty("longest_bow_shot_kit_advanced_solo_cannoneer")]
        public int longest_bow_shot_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("fastest_win_kit_advanced_solo_cannoneer")]
        public int fastest_win_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("arrows_shot_kit_advanced_solo_cannoneer")]
        public int arrows_shot_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("most_kills_game_kit_advanced_solo_cannoneer")]
        public int most_kills_game_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("melee_kills_kit_advanced_solo_cannoneer")]
        public int melee_kills_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("arrows_hit_kit_advanced_solo_cannoneer")]
        public int arrows_hit_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("assists_kit_mining_team_cannoneer")]
        public int assists_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("fastest_win_kit_mining_team_cannoneer")]
        public int fastest_win_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("winstreak_kit_mining_team_cannoneer")]
        public int winstreak_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("wins_kit_mining_team_cannoneer")]
        public int wins_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("killstreak_kit_mining_team_cannoneer")]
        public int killstreak_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_enderman")]
        public int longest_bow_shot_kit_attacking_team_enderman { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_enderman")]
        public int melee_kills_kit_attacking_team_enderman { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_enderman")]
        public int arrows_shot_kit_attacking_team_enderman { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_enderman")]
        public int arrows_hit_kit_attacking_team_enderman { get; set; }

        [JsonProperty("solo_marksmanship")]
        public int solo_marksmanship { get; set; }

        [JsonProperty("mega_notoriety")]
        public int mega_notoriety { get; set; }

        [JsonProperty("assists_kit_advanced_solo_enderman")]
        public int assists_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_enderman")]
        public int time_played_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_enderman")]
        public int chests_opened_kit_advanced_solo_enderman { get; set; }

        [JsonProperty("void_kills_kit_basic_solo_grenade")]
        public int void_kills_kit_basic_solo_grenade { get; set; }

        [JsonProperty("deaths_kit_basic_solo_grenade")]
        public int deaths_kit_basic_solo_grenade { get; set; }

        [JsonProperty("losses_kit_basic_solo_grenade")]
        public int losses_kit_basic_solo_grenade { get; set; }

        [JsonProperty("time_played_kit_basic_solo_energix")]
        public int time_played_kit_basic_solo_energix { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_energix")]
        public int survived_players_kit_basic_solo_energix { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_energix")]
        public int chests_opened_kit_basic_solo_energix { get; set; }

        [JsonProperty("losses_kit_basic_solo_energix")]
        public int losses_kit_basic_solo_energix { get; set; }

        [JsonProperty("deaths_kit_basic_solo_energix")]
        public int deaths_kit_basic_solo_energix { get; set; }

        [JsonProperty("mob_kills_kit_advanced_solo_knight")]
        public int mob_kills_kit_advanced_solo_knight { get; set; }

        [JsonProperty("games_played_skywars")]
        public int games_played_skywars { get; set; }

        [JsonProperty("public string lastMode")]
        public string lastMode { get; set; }

        [JsonProperty("losses_kit_attacking_team_grenade")]
        public int losses_kit_attacking_team_grenade { get; set; }

        [JsonProperty("deaths_kit_attacking_team_grenade")]
        public int deaths_kit_attacking_team_grenade { get; set; }

        [JsonProperty("quickjoin_uses_Tribal")]
        public int quickjoin_uses_Tribal { get; set; }

        [JsonProperty("longest_bow_shot_kit_defending_team_disco")]
        public int longest_bow_shot_kit_defending_team_disco { get; set; }

        [JsonProperty("void_kills_kit_defending_team_disco")]
        public int void_kills_kit_defending_team_disco { get; set; }

        [JsonProperty("assists_kit_defending_team_disco")]
        public int assists_kit_defending_team_disco { get; set; }

        [JsonProperty("kills_kit_defending_team_disco")]
        public int kills_kit_defending_team_disco { get; set; }

        [JsonProperty("chests_opened_kit_defending_team_disco")]
        public int chests_opened_kit_defending_team_disco { get; set; }

        [JsonProperty("time_played_kit_defending_team_disco")]
        public int time_played_kit_defending_team_disco { get; set; }

        [JsonProperty("most_kills_game_kit_defending_team_disco")]
        public int most_kills_game_kit_defending_team_disco { get; set; }

        [JsonProperty("survived_players_kit_defending_team_disco")]
        public int survived_players_kit_defending_team_disco { get; set; }

        [JsonProperty("losses_kit_defending_team_disco")]
        public int losses_kit_defending_team_disco { get; set; }

        [JsonProperty("arrows_hit_kit_defending_team_disco")]
        public int arrows_hit_kit_defending_team_disco { get; set; }

        [JsonProperty("arrows_shot_kit_defending_team_disco")]
        public int arrows_shot_kit_defending_team_disco { get; set; }

        [JsonProperty("deaths_kit_defending_team_disco")]
        public int deaths_kit_defending_team_disco { get; set; }

        [JsonProperty("void_kills_kit_advanced_solo_cannoneer")]
        public int void_kills_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("longest_bow_shot_kit_basic_solo_disco")]
        public int longest_bow_shot_kit_basic_solo_disco { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_disco")]
        public int survived_players_kit_basic_solo_disco { get; set; }

        [JsonProperty("void_kills_kit_basic_solo_disco")]
        public int void_kills_kit_basic_solo_disco { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_disco")]
        public int most_kills_game_kit_basic_solo_disco { get; set; }

        [JsonProperty("deaths_kit_basic_solo_disco")]
        public int deaths_kit_basic_solo_disco { get; set; }

        [JsonProperty("kills_kit_basic_solo_disco")]
        public int kills_kit_basic_solo_disco { get; set; }

        [JsonProperty("arrows_hit_kit_basic_solo_disco")]
        public int arrows_hit_kit_basic_solo_disco { get; set; }

        [JsonProperty("losses_kit_basic_solo_disco")]
        public int losses_kit_basic_solo_disco { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_disco")]
        public int chests_opened_kit_basic_solo_disco { get; set; }

        [JsonProperty("time_played_kit_basic_solo_disco")]
        public int time_played_kit_basic_solo_disco { get; set; }

        [JsonProperty("arrows_shot_kit_basic_solo_disco")]
        public int arrows_shot_kit_basic_solo_disco { get; set; }

        [JsonProperty("team_environmental_expert")]
        public int team_environmental_expert { get; set; }

        [JsonProperty("longest_bow_shot_kit_basic_solo_ecologist")]
        public int longest_bow_shot_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("losses_kit_basic_solo_ecologist")]
        public int losses_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_ecologist")]
        public int survived_players_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("arrows_hit_kit_basic_solo_ecologist")]
        public int arrows_hit_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("time_played_kit_basic_solo_ecologist")]
        public int time_played_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("deaths_kit_basic_solo_ecologist")]
        public int deaths_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("arrows_shot_kit_basic_solo_ecologist")]
        public int arrows_shot_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_ecologist")]
        public int chests_opened_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("games_kit_basic_solo_ecologist")]
        public int games_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("kills_kit_basic_solo_ecologist")]
        public int kills_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_ecologist")]
        public int most_kills_game_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("melee_kills_kit_basic_solo_ecologist")]
        public int melee_kills_kit_basic_solo_ecologist { get; set; }

        [JsonProperty("quickjoin_uses_Frostbite")]
        public int quickjoin_uses_Frostbite { get; set; }

        [JsonProperty("blizzard_explained_last")]
        public long blizzard_explained_last { get; set; }

        [JsonProperty("blizzard_explained")]
        public int blizzard_explained { get; set; }

        [JsonProperty("tnt_madness_explained")]
        public int tnt_madness_explained { get; set; }

        [JsonProperty("tnt_madness_explained_last")]
        public long tnt_madness_explained_last { get; set; }

        [JsonProperty("rush_explained")]
        public int rush_explained { get; set; }

        [JsonProperty("rush_explained_last")]
        public long rush_explained_last { get; set; }

        [JsonProperty("floor_is_lava_explained")]
        public int floor_is_lava_explained { get; set; }

        [JsonProperty("floor_is_lava_explained_last")]
        public long floor_is_lava_explained_last { get; set; }

        [JsonProperty("kill_by_color_explained")]
        public int kill_by_color_explained { get; set; }

        [JsonProperty("kill_by_color_explained_last")]
        public long kill_by_color_explained_last { get; set; }

        [JsonProperty("quickjoin_uses_Entangled")]
        public int quickjoin_uses_Entangled { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_default")]
        public int most_kills_game_kit_attacking_team_default { get; set; }

        [JsonProperty("time_played_kit_attacking_team_default")]
        public int time_played_kit_attacking_team_default { get; set; }

        [JsonProperty("losses_kit_attacking_team_default")]
        public int losses_kit_attacking_team_default { get; set; }

        [JsonProperty("deaths_kit_attacking_team_default")]
        public int deaths_kit_attacking_team_default { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_default")]
        public int chests_opened_kit_attacking_team_default { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_default")]
        public int melee_kills_kit_attacking_team_default { get; set; }

        [JsonProperty("games_kit_attacking_team_default")]
        public int games_kit_attacking_team_default { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_default")]
        public int survived_players_kit_attacking_team_default { get; set; }

        [JsonProperty("kills_kit_attacking_team_default")]
        public int kills_kit_attacking_team_default { get; set; }

        [JsonProperty("quickjoin_uses_Towers")]
        public int quickjoin_uses_Towers { get; set; }

        [JsonProperty("quickjoin_uses_Winterhelm")]
        public int quickjoin_uses_Winterhelm { get; set; }

        [JsonProperty("public string activeKit_TEAMS")]
        public string activeKit_TEAMS { get; set; }

        [JsonProperty("survived_players_lab_solo")]
        public int survived_players_lab_solo { get; set; }

        [JsonProperty("wins_lab")]
        public int wins_lab { get; set; }

        [JsonProperty("killstreak_lab")]
        public int killstreak_lab { get; set; }

        [JsonProperty("void_kills_lab")]
        public int void_kills_lab { get; set; }

        [JsonProperty("souls_gathered_lab")]
        public int souls_gathered_lab { get; set; }

        [JsonProperty("games_lab")]
        public int games_lab { get; set; }

        [JsonProperty("survived_players_lab_kit_enderchest_solo_enderchest")]
        public int survived_players_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("survived_players_lab")]
        public int survived_players_lab { get; set; }

        [JsonProperty("coins_gained_lab")]
        public int coins_gained_lab { get; set; }

        [JsonProperty("wins_lab_kit_enderchest_solo_enderchest")]
        public int wins_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("games_lab_kit_enderchest_solo_enderchest")]
        public int games_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("winstreak_lab_kit_enderchest_solo_enderchest")]
        public int winstreak_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("kills_lab")]
        public int kills_lab { get; set; }

        [JsonProperty("winstreak_lab")]
        public int winstreak_lab { get; set; }

        [JsonProperty("games_lab_solo")]
        public int games_lab_solo { get; set; }

        [JsonProperty("egg_thrown_lab")]
        public int egg_thrown_lab { get; set; }

        [JsonProperty("melee_kills_lab_solo")]
        public int melee_kills_lab_solo { get; set; }

        [JsonProperty("blocks_placed_lab")]
        public int blocks_placed_lab { get; set; }

        [JsonProperty("chests_opened_lab_kit_enderchest_solo_enderchest")]
        public int chests_opened_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("kills_lab_solo")]
        public int kills_lab_solo { get; set; }

        [JsonProperty("kills_lab_kit_enderchest_solo_enderchest")]
        public int kills_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("melee_kills_lab_kit_enderchest_solo_enderchest")]
        public int melee_kills_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("chests_opened_lab_solo")]
        public int chests_opened_lab_solo { get; set; }

        [JsonProperty("winstreak_lab_solo")]
        public int winstreak_lab_solo { get; set; }

        [JsonProperty("time_played_lab_solo")]
        public int time_played_lab_solo { get; set; }

        [JsonProperty("time_played_lab")]
        public int time_played_lab { get; set; }

        [JsonProperty("void_kills_lab_kit_enderchest_solo_enderchest")]
        public int void_kills_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("killstreak_lab_solo")]
        public int killstreak_lab_solo { get; set; }

        [JsonProperty("chests_opened_lab")]
        public int chests_opened_lab { get; set; }

        [JsonProperty("wins_lab_solo")]
        public int wins_lab_solo { get; set; }

        [JsonProperty("void_kills_lab_solo")]
        public int void_kills_lab_solo { get; set; }

        [JsonProperty("melee_kills_lab")]
        public int melee_kills_lab { get; set; }

        [JsonProperty("time_played_lab_kit_enderchest_solo_enderchest")]
        public int time_played_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("souls_lab")]
        public int souls_lab { get; set; }

        [JsonProperty("killstreak_lab_kit_enderchest_solo_enderchest")]
        public int killstreak_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("solo_black_magic")]
        public int solo_black_magic { get; set; }

        [JsonProperty("win_streak_lab")]
        public int win_streak_lab { get; set; }

        [JsonProperty("deaths_lab")]
        public int deaths_lab { get; set; }

        [JsonProperty("deaths_lab_solo")]
        public int deaths_lab_solo { get; set; }

        [JsonProperty("losses_lab_kit_enderchest_solo_enderchest")]
        public int losses_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("deaths_lab_kit_enderchest_solo_enderchest")]
        public int deaths_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("losses_lab_solo")]
        public int losses_lab_solo { get; set; }

        [JsonProperty("losses_lab")]
        public int losses_lab { get; set; }

        [JsonProperty("quits_lab")]
        public int quits_lab { get; set; }

        [JsonProperty("blocks_broken_lab")]
        public int blocks_broken_lab { get; set; }

        [JsonProperty("arrows_shot_lab_kit_enderchest_solo_enderchest")]
        public int arrows_shot_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("arrows_shot_lab_solo")]
        public int arrows_shot_lab_solo { get; set; }

        [JsonProperty("arrows_shot_lab")]
        public int arrows_shot_lab { get; set; }

        [JsonProperty("void_kills_lab_kit_mining_team_cannoneer")]
        public int void_kills_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("melee_kills_lab_kit_mining_team_cannoneer")]
        public int melee_kills_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("survived_players_lab_team")]
        public int survived_players_lab_team { get; set; }

        [JsonProperty("time_played_lab_kit_mining_team_cannoneer")]
        public int time_played_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("chests_opened_lab_kit_mining_team_cannoneer")]
        public int chests_opened_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("kills_lab_kit_mining_team_cannoneer")]
        public int kills_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("losses_lab_team")]
        public int losses_lab_team { get; set; }

        [JsonProperty("melee_kills_lab_team")]
        public int melee_kills_lab_team { get; set; }

        [JsonProperty("kills_lab_team")]
        public int kills_lab_team { get; set; }

        [JsonProperty("deaths_lab_team")]
        public int deaths_lab_team { get; set; }

        [JsonProperty("survived_players_lab_kit_mining_team_cannoneer")]
        public int survived_players_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("chests_opened_lab_team")]
        public int chests_opened_lab_team { get; set; }

        [JsonProperty("time_played_lab_team")]
        public int time_played_lab_team { get; set; }

        [JsonProperty("deaths_lab_kit_mining_team_cannoneer")]
        public int deaths_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("losses_lab_kit_mining_team_cannoneer")]
        public int losses_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("enderpearls_thrown_lab")]
        public int enderpearls_thrown_lab { get; set; }

        [JsonProperty("void_kills_lab_team")]
        public int void_kills_lab_team { get; set; }

        [JsonProperty("games_lab_kit_mining_team_cannoneer")]
        public int games_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("games_lab_team")]
        public int games_lab_team { get; set; }

        [JsonProperty("fastest_win_lab_kit_mining_team_cannoneer")]
        public int fastest_win_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("fastest_win_lab_team")]
        public int fastest_win_lab_team { get; set; }

        [JsonProperty("fastest_win_lab")]
        public int fastest_win_lab { get; set; }

        [JsonProperty("wins_lab_kit_mining_team_cannoneer")]
        public int wins_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_team")]
        public int lab_win_tnt_madness_lab_team { get; set; }

        [JsonProperty("killstreak_lab_kit_mining_team_cannoneer")]
        public int killstreak_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("winstreak_lab_team")]
        public int winstreak_lab_team { get; set; }

        [JsonProperty("killstreak_lab_team")]
        public int killstreak_lab_team { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_kit_mining_team_cannoneer")]
        public int lab_win_tnt_madness_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("wins_lab_team")]
        public int wins_lab_team { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab")]
        public int lab_win_tnt_madness_lab { get; set; }

        [JsonProperty("winstreak_lab_kit_mining_team_cannoneer")]
        public int winstreak_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("slime_explained_last")]
        public long slime_explained_last { get; set; }

        [JsonProperty("slime_explained")]
        public int slime_explained { get; set; }

        [JsonProperty("arrows_hit_lab_kit_enderchest_solo_enderchest")]
        public int arrows_hit_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("lab_win_slime_lab")]
        public int lab_win_slime_lab { get; set; }

        [JsonProperty("lab_win_slime_lab_kit_enderchest_solo_enderchest")]
        public int lab_win_slime_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("lab_win_slime_lab_solo")]
        public int lab_win_slime_lab_solo { get; set; }

        [JsonProperty("arrows_hit_lab")]
        public int arrows_hit_lab { get; set; }

        [JsonProperty("arrows_hit_lab_solo")]
        public int arrows_hit_lab_solo { get; set; }

        [JsonProperty("assists_lab")]
        public int assists_lab { get; set; }

        [JsonProperty("assists_lab_solo")]
        public int assists_lab_solo { get; set; }

        [JsonProperty("assists_lab_kit_enderchest_solo_enderchest")]
        public int assists_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("arrows_shot_lab_team")]
        public int arrows_shot_lab_team { get; set; }

        [JsonProperty("arrows_shot_lab_kit_mining_team_cannoneer")]
        public int arrows_shot_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("lab_win_slime_lab_kit_mining_team_cannoneer")]
        public int lab_win_slime_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("lab_win_slime_lab_team")]
        public int lab_win_slime_lab_team { get; set; }

        [JsonProperty("assists_lab_team")]
        public int assists_lab_team { get; set; }

        [JsonProperty("assists_lab_kit_mining_team_cannoneer")]
        public int assists_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("arrows_hit_lab_team")]
        public int arrows_hit_lab_team { get; set; }

        [JsonProperty("arrows_hit_lab_kit_mining_team_cannoneer")]
        public int arrows_hit_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("losses_lab_kit_advanced_solo_knight")]
        public int losses_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("time_played_lab_kit_advanced_solo_knight")]
        public int time_played_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("chests_opened_lab_kit_advanced_solo_knight")]
        public int chests_opened_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("survived_players_lab_kit_advanced_solo_knight")]
        public int survived_players_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("deaths_lab_kit_advanced_solo_knight")]
        public int deaths_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("deaths_lab_kit_attacking_team_knight")]
        public int deaths_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("games_lab_kit_attacking_team_knight")]
        public int games_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("survived_players_lab_kit_attacking_team_knight")]
        public int survived_players_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("losses_lab_kit_attacking_team_knight")]
        public int losses_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("arrows_shot_lab_kit_attacking_team_knight")]
        public int arrows_shot_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("time_played_lab_kit_attacking_team_knight")]
        public int time_played_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("void_kills_lab_kit_attacking_team_knight")]
        public int void_kills_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("melee_kills_lab_kit_attacking_team_knight")]
        public int melee_kills_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("arrows_hit_lab_kit_attacking_team_knight")]
        public int arrows_hit_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("kills_lab_kit_attacking_team_knight")]
        public int kills_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("chests_opened_lab_kit_attacking_team_knight")]
        public int chests_opened_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("mob_kills_lab_team")]
        public int mob_kills_lab_team { get; set; }

        [JsonProperty("mob_kills_lab")]
        public int mob_kills_lab { get; set; }

        [JsonProperty("mob_kills_lab_kit_attacking_team_knight")]
        public int mob_kills_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("killstreak_lab_kit_attacking_team_knight")]
        public int killstreak_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("winstreak_lab_kit_attacking_team_knight")]
        public int winstreak_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("lab_win_slime_lab_kit_attacking_team_knight")]
        public int lab_win_slime_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("wins_lab_kit_attacking_team_knight")]
        public int wins_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("assists_lab_kit_attacking_team_knight")]
        public int assists_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("arrows_shot_lab_kit_advanced_solo_knight")]
        public int arrows_shot_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("winstreak_lab_kit_advanced_solo_knight")]
        public int winstreak_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("killstreak_lab_kit_advanced_solo_knight")]
        public int killstreak_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("kills_lab_kit_advanced_solo_knight")]
        public int kills_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("lab_win_slime_lab_kit_advanced_solo_knight")]
        public int lab_win_slime_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("arrows_hit_lab_kit_advanced_solo_knight")]
        public int arrows_hit_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("void_kills_lab_kit_advanced_solo_knight")]
        public int void_kills_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("games_lab_kit_advanced_solo_knight")]
        public int games_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("wins_lab_kit_advanced_solo_knight")]
        public int wins_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_kit_advanced_solo_knight")]
        public int lab_win_tnt_madness_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_solo")]
        public int lab_win_tnt_madness_lab_solo { get; set; }

        [JsonProperty("longest_bow_shot_lab_kit_attacking_team_knight")]
        public int longest_bow_shot_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("longest_bow_shot_lab")]
        public int longest_bow_shot_lab { get; set; }

        [JsonProperty("longest_bow_shot_lab_team")]
        public int longest_bow_shot_lab_team { get; set; }

        [JsonProperty("melee_kills_lab_kit_advanced_solo_knight")]
        public int melee_kills_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("lab_win_rush_lab_team")]
        public int lab_win_rush_lab_team { get; set; }

        [JsonProperty("lab_win_rush_lab_kit_attacking_team_knight")]
        public int lab_win_rush_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("lab_win_rush_lab")]
        public int lab_win_rush_lab { get; set; }

        [JsonProperty("assists_lab_kit_advanced_solo_knight")]
        public int assists_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_kit_attacking_team_knight")]
        public int lab_win_tnt_madness_lab_kit_attacking_team_knight { get; set; }

        [JsonProperty("chests_opened_lab_kit_defending_team_armorer")]
        public int chests_opened_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("arrows_hit_lab_kit_defending_team_armorer")]
        public int arrows_hit_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("deaths_lab_kit_defending_team_armorer")]
        public int deaths_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("arrows_shot_lab_kit_defending_team_armorer")]
        public int arrows_shot_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("time_played_lab_kit_defending_team_armorer")]
        public int time_played_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("survived_players_lab_kit_defending_team_armorer")]
        public int survived_players_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("assists_lab_kit_defending_team_armorer")]
        public int assists_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("losses_lab_kit_defending_team_armorer")]
        public int losses_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("kills_lab_kit_defending_team_armorer")]
        public int kills_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("melee_kills_lab_kit_defending_team_armorer")]
        public int melee_kills_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("games_lab_kit_defending_team_armorer")]
        public int games_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("wins_lab_kit_defending_team_armorer")]
        public int wins_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("winstreak_lab_kit_defending_team_armorer")]
        public int winstreak_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("killstreak_lab_kit_defending_team_armorer")]
        public int killstreak_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("void_kills_lab_kit_defending_team_armorer")]
        public int void_kills_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("lab_win_slime_lab_kit_defending_team_armorer")]
        public int lab_win_slime_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("fastest_win_lab_kit_defending_team_armorer")]
        public int fastest_win_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("mob_kills_lab_kit_defending_team_armorer")]
        public int mob_kills_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_kit_defending_team_armorer")]
        public int lab_win_tnt_madness_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_kit_enderchest_solo_enderchest")]
        public int lab_win_tnt_madness_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("quickjoin_uses_Memorial")]
        public int quickjoin_uses_Memorial { get; set; }

        [JsonProperty("quickjoin_uses_Palette")]
        public int quickjoin_uses_Palette { get; set; }

        [JsonProperty("quickjoin_uses_Villa")]
        public int quickjoin_uses_Villa { get; set; }

        [JsonProperty("solo_environmental_expert")]
        public int solo_environmental_expert { get; set; }

        [JsonProperty("assists_kit_attacking_team_default")]
        public int assists_kit_attacking_team_default { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_default")]
        public int void_kills_kit_attacking_team_default { get; set; }

        [JsonProperty("lab_win_rush_lab_kit_enderchest_solo_enderchest")]
        public int lab_win_rush_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("lab_win_rush_lab_solo")]
        public int lab_win_rush_lab_solo { get; set; }

        [JsonProperty("lab_win_rush_lab_kit_defending_team_armorer")]
        public int lab_win_rush_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("mob_kills_lab_solo")]
        public int mob_kills_lab_solo { get; set; }

        [JsonProperty("mob_kills_lab_kit_enderchest_solo_enderchest")]
        public int mob_kills_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("fastest_win_kit_blacksmith_ranked_blacksmith")]
        public int fastest_win_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("void_kills_kit_blacksmith_ranked_blacksmith")]
        public int void_kills_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("most_kills_game_kit_blacksmith_ranked_blacksmith")]
        public int most_kills_game_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("games_kit_blacksmith_ranked_blacksmith")]
        public int games_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("killstreak_kit_blacksmith_ranked_blacksmith")]
        public int killstreak_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("wins_kit_blacksmith_ranked_blacksmith")]
        public int wins_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("survived_players_kit_blacksmith_ranked_blacksmith")]
        public int survived_players_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("time_played_kit_blacksmith_ranked_blacksmith")]
        public int time_played_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("winstreak_kit_blacksmith_ranked_blacksmith")]
        public int winstreak_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("kills_kit_blacksmith_ranked_blacksmith")]
        public int kills_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("chests_opened_kit_blacksmith_ranked_blacksmith")]
        public int chests_opened_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("losses_kit_blacksmith_ranked_blacksmith")]
        public int losses_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("deaths_kit_blacksmith_ranked_blacksmith")]
        public int deaths_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("melee_kills_kit_blacksmith_ranked_blacksmith")]
        public int melee_kills_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("longest_bow_shot_kit_blacksmith_ranked_blacksmith")]
        public int longest_bow_shot_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("arrows_shot_kit_blacksmith_ranked_blacksmith")]
        public int arrows_shot_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("arrows_hit_kit_blacksmith_ranked_blacksmith")]
        public int arrows_hit_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("assists_kit_blacksmith_ranked_blacksmith")]
        public int assists_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_enchanter")]
        public int time_played_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("losses_kit_advanced_solo_enchanter")]
        public int losses_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_enchanter")]
        public int deaths_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_enchanter")]
        public int survived_players_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_enchanter")]
        public int chests_opened_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("fastest_win_kit_advanced_solo_enchanter")]
        public int fastest_win_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("longest_bow_shot_kit_advanced_solo_enchanter")]
        public int longest_bow_shot_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("wins_kit_advanced_solo_enchanter")]
        public int wins_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("void_kills_kit_advanced_solo_enchanter")]
        public int void_kills_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("winstreak_kit_advanced_solo_enchanter")]
        public int winstreak_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("arrows_shot_kit_advanced_solo_enchanter")]
        public int arrows_shot_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("games_kit_advanced_solo_enchanter")]
        public int games_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("kills_kit_advanced_solo_enchanter")]
        public int kills_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("most_kills_game_kit_advanced_solo_enchanter")]
        public int most_kills_game_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("arrows_hit_kit_advanced_solo_enchanter")]
        public int arrows_hit_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("killstreak_kit_advanced_solo_enchanter")]
        public int killstreak_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("assists_kit_advanced_solo_enchanter")]
        public int assists_kit_advanced_solo_enchanter { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_scout")]
        public int longest_bow_shot_kit_attacking_team_scout { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_scout")]
        public int chests_opened_kit_attacking_team_scout { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_scout")]
        public int arrows_shot_kit_attacking_team_scout { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_scout")]
        public int melee_kills_kit_attacking_team_scout { get; set; }

        [JsonProperty("time_played_kit_attacking_team_scout")]
        public int time_played_kit_attacking_team_scout { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_scout")]
        public int void_kills_kit_attacking_team_scout { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_scout")]
        public int arrows_hit_kit_attacking_team_scout { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_scout")]
        public int most_kills_game_kit_attacking_team_scout { get; set; }

        [JsonProperty("longest_bow_kill_kit_enderchest_solo_enderchest")]
        public int longest_bow_kill_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("longest_bow_kill")]
        public int longest_bow_kill { get; set; }

        [JsonProperty("longest_bow_kill_solo")]
        public int longest_bow_kill_solo { get; set; }

        [JsonProperty("longest_bow_kill_kit_advanced_solo_knight")]
        public int longest_bow_kill_kit_advanced_solo_knight { get; set; }

        [JsonProperty("longest_bow_kill_kit_supporting_team_armorsmith")]
        public int longest_bow_kill_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("longest_bow_kill_team")]
        public int longest_bow_kill_team { get; set; }

        [JsonProperty("fastest_win_kit_supporting_team_armorsmith")]
        public int fastest_win_kit_supporting_team_armorsmith { get; set; }

        [JsonProperty("longest_bow_kill_kit_mining_team_cannoneer")]
        public int longest_bow_kill_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("longest_bow_kill_kit_blacksmith_ranked_blacksmith")]
        public int longest_bow_kill_kit_blacksmith_ranked_blacksmith { get; set; }

        [JsonProperty("longest_bow_kill_ranked")]
        public int longest_bow_kill_ranked { get; set; }

        [JsonProperty("team_necromancer")]
        public int team_necromancer { get; set; }

        [JsonProperty("longest_bow_kill_kit_advanced_solo_cannoneer")]
        public int longest_bow_kill_kit_advanced_solo_cannoneer { get; set; }

        [JsonProperty("longest_bow_kill_kit_defending_team_armorer")]
        public int longest_bow_kill_kit_defending_team_armorer { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_knight")]
        public int longest_bow_kill_kit_attacking_team_knight { get; set; }

        [JsonProperty("inGamePresentsCap_2017_2")]
        public int inGamePresentsCap_2017_2 { get; set; }

        [JsonProperty("longest_bow_shot_kit_advanced_solo_hunter")]
        public int longest_bow_shot_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("arrows_hit_kit_advanced_solo_hunter")]
        public int arrows_hit_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_hunter")]
        public int deaths_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_hunter")]
        public int time_played_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("arrows_shot_kit_advanced_solo_hunter")]
        public int arrows_shot_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_hunter")]
        public int chests_opened_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("losses_kit_advanced_solo_hunter")]
        public int losses_kit_advanced_solo_hunter { get; set; }

        [JsonProperty("inGamePresentsCap_2017_3")]
        public int inGamePresentsCap_2017_3 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_4")]
        public int inGamePresentsCap_2017_4 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_6")]
        public int inGamePresentsCap_2017_6 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_7")]
        public int inGamePresentsCap_2017_7 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_9")]
        public int inGamePresentsCap_2017_9 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_10")]
        public int inGamePresentsCap_2017_10 { get; set; }

        [JsonProperty("time_played_kit_basic_solo_troll")]
        public int time_played_kit_basic_solo_troll { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_troll")]
        public int chests_opened_kit_basic_solo_troll { get; set; }

        [JsonProperty("assists_kit_basic_solo_troll")]
        public int assists_kit_basic_solo_troll { get; set; }

        [JsonProperty("fastest_win_kit_basic_solo_troll")]
        public int fastest_win_kit_basic_solo_troll { get; set; }

        [JsonProperty("longest_bow_kill_kit_basic_solo_troll")]
        public int longest_bow_kill_kit_basic_solo_troll { get; set; }

        [JsonProperty("longest_bow_shot_kit_basic_solo_troll")]
        public int longest_bow_shot_kit_basic_solo_troll { get; set; }

        [JsonProperty("arrows_hit_kit_basic_solo_troll")]
        public int arrows_hit_kit_basic_solo_troll { get; set; }

        [JsonProperty("arrows_shot_kit_basic_solo_troll")]
        public int arrows_shot_kit_basic_solo_troll { get; set; }

        [JsonProperty("melee_kills_kit_basic_solo_troll")]
        public int melee_kills_kit_basic_solo_troll { get; set; }

        [JsonProperty("winstreak_kit_basic_solo_troll")]
        public int winstreak_kit_basic_solo_troll { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_troll")]
        public int most_kills_game_kit_basic_solo_troll { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_troll")]
        public int killstreak_kit_basic_solo_troll { get; set; }

        [JsonProperty("wins_kit_basic_solo_troll")]
        public int wins_kit_basic_solo_troll { get; set; }

        [JsonProperty("games_kit_basic_solo_troll")]
        public int games_kit_basic_solo_troll { get; set; }

        [JsonProperty("kit_mega_mega_armorsmith")]
        public int kit_mega_mega_armorsmith { get; set; }

        [JsonProperty("kit_mega_mega_cannoneer")]
        public int kit_mega_mega_cannoneer { get; set; }

        [JsonProperty("kit_mega_mega_healer")]
        public int kit_mega_mega_healer { get; set; }

        [JsonProperty("kit_mega_mega_hunter")]
        public int kit_mega_mega_hunter { get; set; }

        [JsonProperty("kit_mega_mega_knight")]
        public int kit_mega_mega_knight { get; set; }

        [JsonProperty("kit_mega_mega_paladin")]
        public int kit_mega_mega_paladin { get; set; }

        [JsonProperty("kit_mega_mega_scout")]
        public int kit_mega_mega_scout { get; set; }

        [JsonProperty("kit_mega_mega_skeletor")]
        public int kit_mega_mega_skeletor { get; set; }

        [JsonProperty("inGamePresentsCap_2017_11")]
        public int inGamePresentsCap_2017_11 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_12")]
        public int inGamePresentsCap_2017_12 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_13")]
        public int inGamePresentsCap_2017_13 { get; set; }

        [JsonProperty("team_black_magic")]
        public int team_black_magic { get; set; }

        [JsonProperty("longest_bow_kill_kit_mega_mega_armorer")]
        public int longest_bow_kill_kit_mega_mega_armorer { get; set; }

        [JsonProperty("longest_bow_kill_mega")]
        public int longest_bow_kill_mega { get; set; }

        [JsonProperty("inGamePresentsCap_2017_17")]
        public int inGamePresentsCap_2017_17 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_19")]
        public int inGamePresentsCap_2017_19 { get; set; }

        [JsonProperty("inGamePresentsCap_2017_23")]
        public int inGamePresentsCap_2017_23 { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_slime")]
        public int longest_bow_kill_kit_attacking_team_slime { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_slime")]
        public int longest_bow_shot_kit_attacking_team_slime { get; set; }

        [JsonProperty("losses_kit_attacking_team_slime")]
        public int losses_kit_attacking_team_slime { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_slime")]
        public int chests_opened_kit_attacking_team_slime { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_slime")]
        public int arrows_hit_kit_attacking_team_slime { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_slime")]
        public int survived_players_kit_attacking_team_slime { get; set; }

        [JsonProperty("time_played_kit_attacking_team_slime")]
        public int time_played_kit_attacking_team_slime { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_slime")]
        public int most_kills_game_kit_attacking_team_slime { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_slime")]
        public int arrows_shot_kit_attacking_team_slime { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_slime")]
        public int melee_kills_kit_attacking_team_slime { get; set; }

        [JsonProperty("deaths_kit_attacking_team_slime")]
        public int deaths_kit_attacking_team_slime { get; set; }

        [JsonProperty("games_kit_attacking_team_slime")]
        public int games_kit_attacking_team_slime { get; set; }

        [JsonProperty("kills_kit_attacking_team_slime")]
        public int kills_kit_attacking_team_slime { get; set; }

        [JsonProperty("inGamePresentsCap_2017_24")]
        public int inGamePresentsCap_2017_24 { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_salmon")]
        public int chests_opened_kit_attacking_team_salmon { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_salmon")]
        public int most_kills_game_kit_attacking_team_salmon { get; set; }

        [JsonProperty("games_kit_attacking_team_salmon")]
        public int games_kit_attacking_team_salmon { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_salmon")]
        public int survived_players_kit_attacking_team_salmon { get; set; }

        [JsonProperty("kills_kit_attacking_team_salmon")]
        public int kills_kit_attacking_team_salmon { get; set; }

        [JsonProperty("deaths_kit_attacking_team_salmon")]
        public int deaths_kit_attacking_team_salmon { get; set; }

        [JsonProperty("losses_kit_attacking_team_salmon")]
        public int losses_kit_attacking_team_salmon { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_salmon")]
        public int void_kills_kit_attacking_team_salmon { get; set; }

        [JsonProperty("time_played_kit_attacking_team_salmon")]
        public int time_played_kit_attacking_team_salmon { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_salmon")]
        public int longest_bow_shot_kit_attacking_team_salmon { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_salmon")]
        public int longest_bow_kill_kit_attacking_team_salmon { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_salmon")]
        public int arrows_shot_kit_attacking_team_salmon { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_salmon")]
        public int arrows_hit_kit_attacking_team_salmon { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_salmon")]
        public int melee_kills_kit_attacking_team_salmon { get; set; }

        [JsonProperty("inGamePresentsCap_2017_25")]
        public int inGamePresentsCap_2017_25 { get; set; }

        [JsonProperty("mega_black_magic")]
        public int mega_black_magic { get; set; }

        [JsonProperty("inGamePresentsCap_2017_26")]
        public int inGamePresentsCap_2017_26 { get; set; }

        [JsonProperty("assists_kit_attacking_team_salmon")]
        public int assists_kit_attacking_team_salmon { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_salmon")]
        public int fastest_win_kit_attacking_team_salmon { get; set; }

        [JsonProperty("wins_kit_attacking_team_salmon")]
        public int wins_kit_attacking_team_salmon { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_salmon")]
        public int winstreak_kit_attacking_team_salmon { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_salmon")]
        public int killstreak_kit_attacking_team_salmon { get; set; }

        [JsonProperty("inGamePresentsCap_2017_27")]
        public int inGamePresentsCap_2017_27 { get; set; }

        [JsonProperty("inGamePresentsCap_2018_1")]
        public int inGamePresentsCap_2018_1 { get; set; }

        [JsonProperty("inGamePresentsCap_2018_2")]
        public int inGamePresentsCap_2018_2 { get; set; }

        [JsonProperty("inGamePresentsCap_2018_5")]
        public int inGamePresentsCap_2018_5 { get; set; }

        [JsonProperty("inGamePresentsCap_2018_7")]
        public int inGamePresentsCap_2018_7 { get; set; }

        [JsonProperty("lucky_explained")]
        public int lucky_explained { get; set; }

        [JsonProperty("lucky_explained_last")]
        public long lucky_explained_last { get; set; }

        [JsonProperty("freeLootChestNpc")]
        public long freeLootChestNpc { get; set; }

        [JsonProperty("skywars_chests")]
        public int skywars_chests { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_team")]
        public int lab_win_lucky_blocks_lab_team { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab")]
        public int lab_win_lucky_blocks_lab { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_kit_mining_team_cannoneer")]
        public int lab_win_lucky_blocks_lab_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("SkyWars_openedCommons")]
        public int SkyWars_openedCommons { get; set; }

        [JsonProperty("skywars_chest_history")]
        public List<string> skywars_chest_history { get; set; }

        [JsonProperty("SkyWars_openedChests")]
        public int SkyWars_openedChests { get; set; }

        [JsonProperty("SkyWars_openedRares")]
        public int SkyWars_openedRares { get; set; }

        [JsonProperty("fastest_win_kit_ranked_ranked_champion")]
        public int fastest_win_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("longest_bow_kill_kit_ranked_ranked_champion")]
        public int longest_bow_kill_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("chests_opened_kit_ranked_ranked_champion")]
        public int chests_opened_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("survived_players_kit_ranked_ranked_champion")]
        public int survived_players_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("killstreak_kit_ranked_ranked_champion")]
        public int killstreak_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("wins_kit_ranked_ranked_champion")]
        public int wins_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("kills_kit_ranked_ranked_champion")]
        public int kills_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("most_kills_game_kit_ranked_ranked_champion")]
        public int most_kills_game_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("time_played_kit_ranked_ranked_champion")]
        public int time_played_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("winstreak_kit_ranked_ranked_champion")]
        public int winstreak_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("melee_kills_kit_ranked_ranked_champion")]
        public int melee_kills_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("games_kit_ranked_ranked_champion")]
        public int games_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_solo")]
        public int lab_win_lucky_blocks_lab_solo { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_kit_enderchest_solo_enderchest")]
        public int lab_win_lucky_blocks_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("refill_chest_destroy_lab")]
        public int refill_chest_destroy_lab { get; set; }

        [JsonProperty("cosmetic_tokens")]
        public int cosmetic_tokens { get; set; }

        [JsonProperty("losses_kit_ranked_ranked_champion")]
        public int losses_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("deaths_kit_ranked_ranked_champion")]
        public int deaths_kit_ranked_ranked_champion { get; set; }

        [JsonProperty("arrows_shot_lab_kit_attacking_team_salmon")]
        public int arrows_shot_lab_kit_attacking_team_salmon { get; set; }

        [JsonProperty("losses_lab_kit_attacking_team_salmon")]
        public int losses_lab_kit_attacking_team_salmon { get; set; }

        [JsonProperty("chests_opened_lab_kit_attacking_team_salmon")]
        public int chests_opened_lab_kit_attacking_team_salmon { get; set; }

        [JsonProperty("time_played_lab_kit_attacking_team_salmon")]
        public int time_played_lab_kit_attacking_team_salmon { get; set; }

        [JsonProperty("deaths_lab_kit_attacking_team_salmon")]
        public int deaths_lab_kit_attacking_team_salmon { get; set; }

        [JsonProperty("survived_players_lab_kit_attacking_team_salmon")]
        public int survived_players_lab_kit_attacking_team_salmon { get; set; }

        [JsonProperty("quickjoin_uses_Shire")]
        public int quickjoin_uses_Shire { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_scout")]
        public int fastest_win_kit_attacking_team_scout { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_scout")]
        public int winstreak_kit_attacking_team_scout { get; set; }

        [JsonProperty("fastest_win_kit_ranked_ranked_scout")]
        public int fastest_win_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("games_kit_ranked_ranked_scout")]
        public int games_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("survived_players_kit_ranked_ranked_scout")]
        public int survived_players_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("time_played_kit_ranked_ranked_scout")]
        public int time_played_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("most_kills_game_kit_ranked_ranked_scout")]
        public int most_kills_game_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("void_kills_kit_ranked_ranked_scout")]
        public int void_kills_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("winstreak_kit_ranked_ranked_scout")]
        public int winstreak_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("killstreak_kit_ranked_ranked_scout")]
        public int killstreak_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("kills_kit_ranked_ranked_scout")]
        public int kills_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("wins_kit_ranked_ranked_scout")]
        public int wins_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("deaths_kit_ranked_ranked_scout")]
        public int deaths_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("losses_kit_ranked_ranked_scout")]
        public int losses_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("longest_bow_kill_kit_ranked_ranked_scout")]
        public int longest_bow_kill_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("melee_kills_kit_ranked_ranked_scout")]
        public int melee_kills_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("longest_bow_shot_kit_ranked_ranked_scout")]
        public int longest_bow_shot_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("arrows_shot_kit_ranked_ranked_scout")]
        public int arrows_shot_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("arrows_hit_kit_ranked_ranked_scout")]
        public int arrows_hit_kit_ranked_ranked_scout { get; set; }

        [JsonProperty("longest_bow_kill_kit_advanced_solo_armorer")]
        public int longest_bow_kill_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("public string active_victorydance")]
        public string active_victorydance { get; set; }

        [JsonProperty("bow_kills_team")]
        public int bow_kills_team { get; set; }

        [JsonProperty("bow_kills")]
        public int bow_kills { get; set; }

        [JsonProperty("bow_kills_kit_defending_team_armorer")]
        public int bow_kills_kit_defending_team_armorer { get; set; }

        [JsonProperty("bow_kills_solo")]
        public int bow_kills_solo { get; set; }

        [JsonProperty("bow_kills_kit_enderchest_solo_enderchest")]
        public int bow_kills_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("bow_kills_kit_advanced_solo_armorer")]
        public int bow_kills_kit_advanced_solo_armorer { get; set; }

        [JsonProperty("skywars_easter_boxes")]
        public int skywars_easter_boxes { get; set; }

        [JsonProperty("longest_bow_kill_lab_solo")]
        public int longest_bow_kill_lab_solo { get; set; }

        [JsonProperty("longest_bow_kill_lab")]
        public int longest_bow_kill_lab { get; set; }

        [JsonProperty("longest_bow_kill_lab_kit_advanced_solo_knight")]
        public int longest_bow_kill_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("bow_kills_lab")]
        public int bow_kills_lab { get; set; }

        [JsonProperty("bow_kills_lab_solo")]
        public int bow_kills_lab_solo { get; set; }

        [JsonProperty("bow_kills_lab_kit_advanced_solo_knight")]
        public int bow_kills_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_kit_advanced_solo_knight")]
        public int lab_win_lucky_blocks_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_default")]
        public int chests_opened_kit_basic_solo_default { get; set; }

        [JsonProperty("time_played_kit_basic_solo_default")]
        public int time_played_kit_basic_solo_default { get; set; }

        [JsonProperty("fastest_win_kit_basic_solo_default")]
        public int fastest_win_kit_basic_solo_default { get; set; }

        [JsonProperty("longest_bow_kill_kit_basic_solo_default")]
        public int longest_bow_kill_kit_basic_solo_default { get; set; }

        [JsonProperty("void_kills_kit_basic_solo_default")]
        public int void_kills_kit_basic_solo_default { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_default")]
        public int most_kills_game_kit_basic_solo_default { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_default")]
        public int killstreak_kit_basic_solo_default { get; set; }

        [JsonProperty("winstreak_kit_basic_solo_default")]
        public int winstreak_kit_basic_solo_default { get; set; }

        [JsonProperty("melee_kills_kit_basic_solo_default")]
        public int melee_kills_kit_basic_solo_default { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_farmer")]
        public int chests_opened_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("most_kills_game_kit_advanced_solo_farmer")]
        public int most_kills_game_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_farmer")]
        public int time_played_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("void_kills_kit_advanced_solo_farmer")]
        public int void_kills_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("fastest_win_kit_advanced_solo_farmer")]
        public int fastest_win_kit_advanced_solo_farmer { get; set; }

        [JsonProperty("mob_kills_kit_attacking_team_knight")]
        public int mob_kills_kit_attacking_team_knight { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_knight")]
        public int bow_kills_kit_attacking_team_knight { get; set; }

        [JsonProperty("bow_kills_kit_advanced_solo_knight")]
        public int bow_kills_kit_advanced_solo_knight { get; set; }

        [JsonProperty("bow_kills_kit_mining_team_cannoneer")]
        public int bow_kills_kit_mining_team_cannoneer { get; set; }

        [JsonProperty("bow_kills_lab_team")]
        public int bow_kills_lab_team { get; set; }

        [JsonProperty("bow_kills_lab_kit_defending_team_armorer")]
        public int bow_kills_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("hunters_vs_beasts_explained")]
        public int hunters_vs_beasts_explained { get; set; }

        [JsonProperty("hunters_vs_beasts_explained_last")]
        public long hunters_vs_beasts_explained_last { get; set; }

        [JsonProperty("beast_chance")]
        public int beast_chance { get; set; }

        [JsonProperty("fastest_win_lab_solo")]
        public int fastest_win_lab_solo { get; set; }

        [JsonProperty("fastest_win_lab_kit_enderchest_solo_enderchest")]
        public int fastest_win_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_kit_enderchest_solo_enderchest")]
        public int lab_win_hunters_vs_beasts_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_solo")]
        public int lab_win_hunters_vs_beasts_lab_solo { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab")]
        public int lab_win_hunters_vs_beasts_lab { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_kit_advanced_solo_knight")]
        public int lab_win_hunters_vs_beasts_lab_kit_advanced_solo_knight { get; set; }

        [JsonProperty("team_marksmanship")]
        public int team_marksmanship { get; set; }

        [JsonProperty("public bool activeKit_MEGA_DOUBLES_random")]
        public bool activeKit_MEGA_DOUBLES_random { get; set; }

        [JsonProperty("public string activeKit_MEGA_DOUBLES")]
        public string activeKit_MEGA_DOUBLES { get; set; }

        [JsonProperty("time_played_mega_doubles")]
        public int time_played_mega_doubles { get; set; }

        [JsonProperty("losses_mega_doubles_normal")]
        public int losses_mega_doubles_normal { get; set; }

        [JsonProperty("kills_mega_doubles_normal")]
        public int kills_mega_doubles_normal { get; set; }

        [JsonProperty("deaths_mega_doubles_normal")]
        public int deaths_mega_doubles_normal { get; set; }

        [JsonProperty("survived_players_mega_doubles")]
        public int survived_players_mega_doubles { get; set; }

        [JsonProperty("losses_mega_doubles")]
        public int losses_mega_doubles { get; set; }

        [JsonProperty("melee_kills_mega_doubles")]
        public int melee_kills_mega_doubles { get; set; }

        [JsonProperty("kills_mega_doubles")]
        public int kills_mega_doubles { get; set; }

        [JsonProperty("deaths_mega_doubles")]
        public int deaths_mega_doubles { get; set; }

        [JsonProperty("chests_opened_mega_doubles")]
        public int chests_opened_mega_doubles { get; set; }

        [JsonProperty("games_mega_doubles")]
        public int games_mega_doubles { get; set; }

        [JsonProperty("public bool activeKit_SOLO_random")]
        public bool activeKit_SOLO_random { get; set; }

        [JsonProperty("lab_hvb_hunter_wins_lab")]
        public int lab_hvb_hunter_wins_lab { get; set; }

        [JsonProperty("public bool activeKit_TEAMS_random")]
        public bool activeKit_TEAMS_random { get; set; }

        [JsonProperty("arrows_shot_mega_doubles")]
        public int arrows_shot_mega_doubles { get; set; }

        [JsonProperty("arrows_hit_mega_doubles")]
        public int arrows_hit_mega_doubles { get; set; }

        [JsonProperty("void_kills_mega_doubles")]
        public int void_kills_mega_doubles { get; set; }

        [JsonProperty("lab_hvb_beast_wins_lab")]
        public int lab_hvb_beast_wins_lab { get; set; }

        [JsonProperty("lab_hvb_beast_enraged_wins_lab")]
        public int lab_hvb_beast_enraged_wins_lab { get; set; }

        [JsonProperty("lab_hvb_beast_enrages_lab")]
        public int lab_hvb_beast_enrages_lab { get; set; }

        [JsonProperty("quickjoin_uses_Canopy")]
        public int quickjoin_uses_Canopy { get; set; }

        [JsonProperty("quickjoin_uses_Fragment")]
        public int quickjoin_uses_Fragment { get; set; }

        [JsonProperty("quickjoin_uses_Mothership")]
        public int quickjoin_uses_Mothership { get; set; }

        [JsonProperty("quickjoin_uses_Hibiscus")]
        public int quickjoin_uses_Hibiscus { get; set; }

        [JsonProperty("quickjoin_uses_Arule")]
        public int quickjoin_uses_Arule { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_salmon")]
        public int bow_kills_kit_attacking_team_salmon { get; set; }

        [JsonProperty("longest_bow_shot_kit_defending_team_frog")]
        public int longest_bow_shot_kit_defending_team_frog { get; set; }

        [JsonProperty("most_kills_game_kit_defending_team_frog")]
        public int most_kills_game_kit_defending_team_frog { get; set; }

        [JsonProperty("deaths_kit_defending_team_frog")]
        public int deaths_kit_defending_team_frog { get; set; }

        [JsonProperty("kills_kit_defending_team_frog")]
        public int kills_kit_defending_team_frog { get; set; }

        [JsonProperty("void_kills_kit_defending_team_frog")]
        public int void_kills_kit_defending_team_frog { get; set; }

        [JsonProperty("arrows_shot_kit_defending_team_frog")]
        public int arrows_shot_kit_defending_team_frog { get; set; }

        [JsonProperty("losses_kit_defending_team_frog")]
        public int losses_kit_defending_team_frog { get; set; }

        [JsonProperty("survived_players_kit_defending_team_frog")]
        public int survived_players_kit_defending_team_frog { get; set; }

        [JsonProperty("games_kit_defending_team_frog")]
        public int games_kit_defending_team_frog { get; set; }

        [JsonProperty("time_played_kit_defending_team_frog")]
        public int time_played_kit_defending_team_frog { get; set; }

        [JsonProperty("arrows_hit_kit_defending_team_frog")]
        public int arrows_hit_kit_defending_team_frog { get; set; }

        [JsonProperty("chests_opened_kit_defending_team_frog")]
        public int chests_opened_kit_defending_team_frog { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_jester")]
        public int most_kills_game_kit_attacking_team_jester { get; set; }

        [JsonProperty("deaths_kit_attacking_team_jester")]
        public int deaths_kit_attacking_team_jester { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_jester")]
        public int chests_opened_kit_attacking_team_jester { get; set; }

        [JsonProperty("games_kit_attacking_team_jester")]
        public int games_kit_attacking_team_jester { get; set; }

        [JsonProperty("kills_kit_attacking_team_jester")]
        public int kills_kit_attacking_team_jester { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_jester")]
        public int survived_players_kit_attacking_team_jester { get; set; }

        [JsonProperty("losses_kit_attacking_team_jester")]
        public int losses_kit_attacking_team_jester { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_jester")]
        public int arrows_shot_kit_attacking_team_jester { get; set; }

        [JsonProperty("time_played_kit_attacking_team_jester")]
        public int time_played_kit_attacking_team_jester { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_jester")]
        public int void_kills_kit_attacking_team_jester { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_jester")]
        public int longest_bow_shot_kit_attacking_team_jester { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_jester")]
        public int longest_bow_kill_kit_attacking_team_jester { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_jester")]
        public int arrows_hit_kit_attacking_team_jester { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_jester")]
        public int bow_kills_kit_attacking_team_jester { get; set; }

        [JsonProperty("public bool luckyBlockResourcePackEnabled")]
        public bool luckyBlockResourcePackEnabled { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_kit_defending_team_armorer")]
        public int lab_win_lucky_blocks_lab_kit_defending_team_armorer { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_jester")]
        public int fastest_win_kit_attacking_team_jester { get; set; }

        [JsonProperty("winstreak_kit_attacking_team_jester")]
        public int winstreak_kit_attacking_team_jester { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_jester")]
        public int killstreak_kit_attacking_team_jester { get; set; }

        [JsonProperty("wins_kit_attacking_team_jester")]
        public int wins_kit_attacking_team_jester { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_jester")]
        public int melee_kills_kit_attacking_team_jester { get; set; }

        [JsonProperty("assists_kit_attacking_team_jester")]
        public int assists_kit_attacking_team_jester { get; set; }

        [JsonProperty("bow_kills_lab_kit_enderchest_solo_enderchest")]
        public int bow_kills_lab_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("mega_necromancer")]
        public int mega_necromancer { get; set; }

        [JsonProperty("fastest_win_kit_supporting_team_zookeeper")]
        public int fastest_win_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("longest_bow_shot_kit_supporting_team_zookeeper")]
        public int longest_bow_shot_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("most_kills_game_kit_supporting_team_zookeeper")]
        public int most_kills_game_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("longest_bow_kill_kit_supporting_team_zookeeper")]
        public int longest_bow_kill_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("winstreak_kit_supporting_team_zookeeper")]
        public int winstreak_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("arrows_shot_kit_supporting_team_zookeeper")]
        public int arrows_shot_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("games_kit_supporting_team_zookeeper")]
        public int games_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("bow_kills_kit_supporting_team_zookeeper")]
        public int bow_kills_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("kills_kit_supporting_team_zookeeper")]
        public int kills_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("killstreak_kit_supporting_team_zookeeper")]
        public int killstreak_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("wins_kit_supporting_team_zookeeper")]
        public int wins_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_zookeeper")]
        public int survived_players_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("time_played_kit_supporting_team_zookeeper")]
        public int time_played_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("void_kills_kit_supporting_team_zookeeper")]
        public int void_kills_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("melee_kills_kit_supporting_team_zookeeper")]
        public int melee_kills_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("chests_opened_kit_supporting_team_zookeeper")]
        public int chests_opened_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("arrows_hit_kit_supporting_team_zookeeper")]
        public int arrows_hit_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("losses_kit_supporting_team_zookeeper")]
        public int losses_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("deaths_kit_supporting_team_zookeeper")]
        public int deaths_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("time_played_lab_kit_supporting_team_zookeeper")]
        public int time_played_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("deaths_lab_kit_supporting_team_zookeeper")]
        public int deaths_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("survived_players_lab_kit_supporting_team_zookeeper")]
        public int survived_players_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("losses_lab_kit_supporting_team_zookeeper")]
        public int losses_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("chests_opened_lab_kit_supporting_team_zookeeper")]
        public int chests_opened_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("games_lab_kit_supporting_team_zookeeper")]
        public int games_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("fastest_win_lab_kit_supporting_team_zookeeper")]
        public int fastest_win_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("wins_lab_kit_supporting_team_zookeeper")]
        public int wins_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("winstreak_lab_kit_supporting_team_zookeeper")]
        public int winstreak_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("quickjoin_uses_Dawn")]
        public int quickjoin_uses_Dawn { get; set; }

        [JsonProperty("longest_bow_kill_kit_basic_solo_snowman")]
        public int longest_bow_kill_kit_basic_solo_snowman { get; set; }

        [JsonProperty("solo_necromancer")]
        public int solo_necromancer { get; set; }

        [JsonProperty("longest_bow_kill_mega_doubles")]
        public int longest_bow_kill_mega_doubles { get; set; }

        [JsonProperty("assists_mega_doubles")]
        public int assists_mega_doubles { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_snowman")]
        public int longest_bow_kill_kit_attacking_team_snowman { get; set; }

        [JsonProperty("bow_kills_kit_basic_solo_snowman")]
        public int bow_kills_kit_basic_solo_snowman { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_jester")]
        public int time_played_kit_advanced_solo_jester { get; set; }

        [JsonProperty("games_kit_advanced_solo_jester")]
        public int games_kit_advanced_solo_jester { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_jester")]
        public int deaths_kit_advanced_solo_jester { get; set; }

        [JsonProperty("losses_kit_advanced_solo_jester")]
        public int losses_kit_advanced_solo_jester { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_jester")]
        public int chests_opened_kit_advanced_solo_jester { get; set; }

        [JsonProperty("survived_players_kit_advanced_solo_jester")]
        public int survived_players_kit_advanced_solo_jester { get; set; }

        [JsonProperty("inGamePresentsCap_2018_10")]
        public int inGamePresentsCap_2018_10 { get; set; }

        [JsonProperty("skywars_experience")]
        public int skywars_experience { get; set; }

        [JsonProperty("team_bulldozer")]
        public int team_bulldozer { get; set; }

        [JsonProperty("longest_bow_shot_kit_enderchest_team_enderchest")]
        public int longest_bow_shot_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("chests_opened_kit_enderchest_team_enderchest")]
        public int chests_opened_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("arrows_hit_kit_enderchest_team_enderchest")]
        public int arrows_hit_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("arrows_shot_kit_enderchest_team_enderchest")]
        public int arrows_shot_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("deaths_kit_enderchest_team_enderchest")]
        public int deaths_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("losses_kit_enderchest_team_enderchest")]
        public int losses_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("survived_players_kit_enderchest_team_enderchest")]
        public int survived_players_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("time_played_kit_enderchest_team_enderchest")]
        public int time_played_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("games_kit_enderchest_team_enderchest")]
        public int games_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("assists_kit_enderchest_team_enderchest")]
        public int assists_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("most_kills_game_kit_enderchest_team_enderchest")]
        public int most_kills_game_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("fastest_win_kit_enderchest_team_enderchest")]
        public int fastest_win_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("void_kills_kit_enderchest_team_enderchest")]
        public int void_kills_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("wins_kit_enderchest_team_enderchest")]
        public int wins_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("killstreak_kit_enderchest_team_enderchest")]
        public int killstreak_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("winstreak_kit_enderchest_team_enderchest")]
        public int winstreak_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("kills_kit_enderchest_team_enderchest")]
        public int kills_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("longest_bow_kill_lab_kit_enderchest_team_enderchest")]
        public int longest_bow_kill_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("most_kills_game_lab_kit_enderchest_team_enderchest")]
        public int most_kills_game_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("most_kills_game_lab_solo")]
        public int most_kills_game_lab_solo { get; set; }

        [JsonProperty("most_kills_game_lab")]
        public int most_kills_game_lab { get; set; }

        [JsonProperty("kills_lab_kit_enderchest_team_enderchest")]
        public int kills_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("chests_opened_lab_kit_enderchest_team_enderchest")]
        public int chests_opened_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("survived_players_lab_kit_enderchest_team_enderchest")]
        public int survived_players_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("time_played_lab_kit_enderchest_team_enderchest")]
        public int time_played_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("games_lab_kit_enderchest_team_enderchest")]
        public int games_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_kit_enderchest_team_enderchest")]
        public int lab_win_hunters_vs_beasts_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("killstreak_lab_kit_enderchest_team_enderchest")]
        public int killstreak_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("melee_kills_lab_kit_enderchest_team_enderchest")]
        public int melee_kills_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("winstreak_lab_kit_enderchest_team_enderchest")]
        public int winstreak_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("wins_lab_kit_enderchest_team_enderchest")]
        public int wins_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("void_kills_lab_kit_enderchest_team_enderchest")]
        public int void_kills_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("public string selected_prestige_icon")]
        public string selected_prestige_icon { get; set; }

        [JsonProperty("longest_bow_kill_kit_enderchest_team_enderchest")]
        public int longest_bow_kill_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_kit_enderchest_team_enderchest")]
        public int challenge_attempts_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("melee_kills_kit_enderchest_team_enderchest")]
        public int melee_kills_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_1_solo")]
        public int challenge_attempts_1_solo { get; set; }

        [JsonProperty("challenge_wins_1_solo")]
        public int challenge_wins_1_solo { get; set; }

        [JsonProperty("challenge_wins_uhc")]
        public int challenge_wins_uhc { get; set; }

        [JsonProperty("challenge_wins_kit_enderchest_team_enderchest")]
        public int challenge_wins_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_wins_1_kit_enderchest_team_enderchest")]
        public int challenge_wins_1_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_uhc_kit_enderchest_team_enderchest")]
        public int challenge_attempts_uhc_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_uhc_solo")]
        public int challenge_attempts_uhc_solo { get; set; }

        [JsonProperty("challenge_wins_uhc_kit_enderchest_team_enderchest")]
        public int challenge_wins_uhc_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_wins_uhc_solo")]
        public int challenge_wins_uhc_solo { get; set; }

        [JsonProperty("challenge_attempts_uhc")]
        public int challenge_attempts_uhc { get; set; }

        [JsonProperty("challenge_wins")]
        public int challenge_wins { get; set; }

        [JsonProperty("challenge_attempts_1")]
        public int challenge_attempts_1 { get; set; }

        [JsonProperty("challenge_attempts_solo")]
        public int challenge_attempts_solo { get; set; }

        [JsonProperty("challenge_wins_solo")]
        public int challenge_wins_solo { get; set; }

        [JsonProperty("challenge_attempts_1_kit_enderchest_team_enderchest")]
        public int challenge_attempts_1_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_wins_1")]
        public int challenge_wins_1 { get; set; }

        [JsonProperty("challenge_attempts")]
        public int challenge_attempts { get; set; }

        [JsonProperty("challenge_attempts_no_chest")]
        public int challenge_attempts_no_chest { get; set; }

        [JsonProperty("challenge_attempts_kit_attacking_team_knight")]
        public int challenge_attempts_kit_attacking_team_knight { get; set; }

        [JsonProperty("challenge_attempts_no_chest_solo")]
        public int challenge_attempts_no_chest_solo { get; set; }

        [JsonProperty("challenge_attempts_no_chest_kit_attacking_team_knight")]
        public int challenge_attempts_no_chest_kit_attacking_team_knight { get; set; }

        [JsonProperty("challenge_attempts_1_kit_attacking_team_knight")]
        public int challenge_attempts_1_kit_attacking_team_knight { get; set; }

        [JsonProperty("games_kit_supporting_team_rookie")]
        public int games_kit_supporting_team_rookie { get; set; }

        [JsonProperty("time_played_kit_supporting_team_rookie")]
        public int time_played_kit_supporting_team_rookie { get; set; }

        [JsonProperty("challenge_attempts_kit_supporting_team_rookie")]
        public int challenge_attempts_kit_supporting_team_rookie { get; set; }

        [JsonProperty("challenge_attempts_1_kit_supporting_team_rookie")]
        public int challenge_attempts_1_kit_supporting_team_rookie { get; set; }

        [JsonProperty("challenge_attempts_no_chest_kit_supporting_team_rookie")]
        public int challenge_attempts_no_chest_kit_supporting_team_rookie { get; set; }

        [JsonProperty("longest_bow_kill_kit_supporting_team_rookie")]
        public int longest_bow_kill_kit_supporting_team_rookie { get; set; }

        [JsonProperty("most_kills_game_kit_supporting_team_rookie")]
        public int most_kills_game_kit_supporting_team_rookie { get; set; }

        [JsonProperty("heads_kit_supporting_team_rookie")]
        public int heads_kit_supporting_team_rookie { get; set; }

        [JsonProperty("heads")]
        public int heads { get; set; }

        [JsonProperty("melee_kills_kit_supporting_team_rookie")]
        public int melee_kills_kit_supporting_team_rookie { get; set; }

        [JsonProperty("heads_solo")]
        public int heads_solo { get; set; }

        [JsonProperty("heads_succulent_solo")]
        public int heads_succulent_solo { get; set; }

        [JsonProperty("heads_succulent")]
        public int heads_succulent { get; set; }

        [JsonProperty("heads_succulent_kit_supporting_team_rookie")]
        public int heads_succulent_kit_supporting_team_rookie { get; set; }

        [JsonProperty("void_kills_kit_supporting_team_rookie")]
        public int void_kills_kit_supporting_team_rookie { get; set; }

        [JsonProperty("inGamePresentsCap_2018_24")]
        public int inGamePresentsCap_2018_24 { get; set; }

        [JsonProperty("chests_opened_kit_supporting_team_rookie")]
        public int chests_opened_kit_supporting_team_rookie { get; set; }

        [JsonProperty("longest_bow_shot_kit_supporting_team_rookie")]
        public int longest_bow_shot_kit_supporting_team_rookie { get; set; }

        [JsonProperty("arrows_hit_kit_supporting_team_rookie")]
        public int arrows_hit_kit_supporting_team_rookie { get; set; }

        [JsonProperty("bow_kills_kit_supporting_team_rookie")]
        public int bow_kills_kit_supporting_team_rookie { get; set; }

        [JsonProperty("arrows_shot_kit_supporting_team_rookie")]
        public int arrows_shot_kit_supporting_team_rookie { get; set; }

        [JsonProperty("fastest_win_lab_kit_supporting_team_rookie")]
        public int fastest_win_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("survived_players_lab_kit_supporting_team_rookie")]
        public int survived_players_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("killstreak_lab_kit_supporting_team_rookie")]
        public int killstreak_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("winstreak_lab_kit_supporting_team_rookie")]
        public int winstreak_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("void_kills_lab_kit_supporting_team_rookie")]
        public int void_kills_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("wins_lab_kit_supporting_team_rookie")]
        public int wins_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("deaths_lab_kit_supporting_team_rookie")]
        public int deaths_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("time_played_lab_kit_supporting_team_rookie")]
        public int time_played_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("chests_opened_lab_kit_supporting_team_rookie")]
        public int chests_opened_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_kit_supporting_team_rookie")]
        public int lab_win_hunters_vs_beasts_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("kills_lab_kit_supporting_team_rookie")]
        public int kills_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("games_lab_kit_supporting_team_rookie")]
        public int games_lab_kit_supporting_team_rookie { get; set; }

        [JsonProperty("fastest_win_lab_kit_enderchest_team_enderchest")]
        public int fastest_win_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("losses_lab_kit_enderchest_team_enderchest")]
        public int losses_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("deaths_lab_kit_enderchest_team_enderchest")]
        public int deaths_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("longest_bow_shot_lab_kit_enderchest_team_enderchest")]
        public int longest_bow_shot_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("longest_bow_shot_lab_solo")]
        public int longest_bow_shot_lab_solo { get; set; }

        [JsonProperty("bow_kills_lab_kit_enderchest_team_enderchest")]
        public int bow_kills_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("arrows_shot_lab_kit_enderchest_team_enderchest")]
        public int arrows_shot_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("arrows_hit_lab_kit_enderchest_team_enderchest")]
        public int arrows_hit_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("assists_lab_kit_enderchest_team_enderchest")]
        public int assists_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("inGamePresentsCap_2018_30")]
        public int inGamePresentsCap_2018_30 { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_hunter")]
        public int longest_bow_kill_kit_attacking_team_hunter { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_hunter")]
        public int most_kills_game_kit_attacking_team_hunter { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_hunter")]
        public int longest_bow_shot_kit_attacking_team_hunter { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_hunter")]
        public int arrows_hit_kit_attacking_team_hunter { get; set; }

        [JsonProperty("challenge_attempts_archer_solo")]
        public int challenge_attempts_archer_solo { get; set; }

        [JsonProperty("challenge_attempts_archer")]
        public int challenge_attempts_archer { get; set; }

        [JsonProperty("losses_kit_attacking_team_hunter")]
        public int losses_kit_attacking_team_hunter { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_hunter")]
        public int bow_kills_kit_attacking_team_hunter { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_hunter")]
        public int arrows_shot_kit_attacking_team_hunter { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_hunter")]
        public int chests_opened_kit_attacking_team_hunter { get; set; }

        [JsonProperty("deaths_kit_attacking_team_hunter")]
        public int deaths_kit_attacking_team_hunter { get; set; }

        [JsonProperty("challenge_attempts_1_kit_attacking_team_hunter")]
        public int challenge_attempts_1_kit_attacking_team_hunter { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_hunter")]
        public int survived_players_kit_attacking_team_hunter { get; set; }

        [JsonProperty("challenge_attempts_archer_kit_attacking_team_hunter")]
        public int challenge_attempts_archer_kit_attacking_team_hunter { get; set; }

        [JsonProperty("time_played_kit_attacking_team_hunter")]
        public int time_played_kit_attacking_team_hunter { get; set; }

        [JsonProperty("challenge_attempts_kit_attacking_team_hunter")]
        public int challenge_attempts_kit_attacking_team_hunter { get; set; }

        [JsonProperty("games_kit_attacking_team_hunter")]
        public int games_kit_attacking_team_hunter { get; set; }

        [JsonProperty("kills_kit_attacking_team_hunter")]
        public int kills_kit_attacking_team_hunter { get; set; }

        [JsonProperty("challenge_attempts_paper")]
        public int challenge_attempts_paper { get; set; }

        [JsonProperty("challenge_attempts_kit_attacking_team_enderman")]
        public int challenge_attempts_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_attempts_paper_solo")]
        public int challenge_attempts_paper_solo { get; set; }

        [JsonProperty("challenge_attempts_paper_kit_attacking_team_enderman")]
        public int challenge_attempts_paper_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_attempts_1_kit_attacking_team_enderman")]
        public int challenge_attempts_1_kit_attacking_team_enderman { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_enderman")]
        public int longest_bow_kill_kit_attacking_team_enderman { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_enderman")]
        public int fastest_win_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_wins_1_kit_attacking_team_enderman")]
        public int challenge_wins_1_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_wins_kit_attacking_team_enderman")]
        public int challenge_wins_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_wins_paper_kit_attacking_team_enderman")]
        public int challenge_wins_paper_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_wins_paper_solo")]
        public int challenge_wins_paper_solo { get; set; }

        [JsonProperty("challenge_wins_paper")]
        public int challenge_wins_paper { get; set; }

        [JsonProperty("challenge_attempts_paper_kit_enderchest_solo_enderchest")]
        public int challenge_attempts_paper_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_wins_paper_kit_enderchest_solo_enderchest")]
        public int challenge_wins_paper_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_wins_1_kit_enderchest_solo_enderchest")]
        public int challenge_wins_1_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_attempts_1_kit_enderchest_solo_enderchest")]
        public int challenge_attempts_1_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_attempts_kit_enderchest_solo_enderchest")]
        public int challenge_attempts_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_wins_kit_enderchest_solo_enderchest")]
        public int challenge_wins_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_attempts_rookie_solo")]
        public int challenge_attempts_rookie_solo { get; set; }

        [JsonProperty("challenge_attempts_rookie_kit_enderchest_solo_enderchest")]
        public int challenge_attempts_rookie_kit_enderchest_solo_enderchest { get; set; }

        [JsonProperty("challenge_attempts_rookie")]
        public int challenge_attempts_rookie { get; set; }

        [JsonProperty("most_kills_game_kit_advanced_solo_jester")]
        public int most_kills_game_kit_advanced_solo_jester { get; set; }

        [JsonProperty("challenge_attempts_1_kit_advanced_solo_jester")]
        public int challenge_attempts_1_kit_advanced_solo_jester { get; set; }

        [JsonProperty("kills_kit_advanced_solo_jester")]
        public int kills_kit_advanced_solo_jester { get; set; }

        [JsonProperty("challenge_attempts_rookie_kit_advanced_solo_jester")]
        public int challenge_attempts_rookie_kit_advanced_solo_jester { get; set; }

        [JsonProperty("challenge_attempts_kit_advanced_solo_jester")]
        public int challenge_attempts_kit_advanced_solo_jester { get; set; }

        [JsonProperty("void_kills_kit_advanced_solo_jester")]
        public int void_kills_kit_advanced_solo_jester { get; set; }

        [JsonProperty("assists_kit_advanced_solo_jester")]
        public int assists_kit_advanced_solo_jester { get; set; }

        [JsonProperty("bow_kills_kit_enderchest_team_enderchest")]
        public int bow_kills_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("losses_lab_kit_attacking_team_enderman")]
        public int losses_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("games_lab_kit_attacking_team_enderman")]
        public int games_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("deaths_lab_kit_attacking_team_enderman")]
        public int deaths_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("time_played_lab_kit_attacking_team_enderman")]
        public int time_played_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("survived_players_lab_kit_attacking_team_enderman")]
        public int survived_players_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("chests_opened_lab_kit_attacking_team_enderman")]
        public int chests_opened_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("void_kills_lab_kit_attacking_team_enderman")]
        public int void_kills_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("kills_lab_kit_attacking_team_enderman")]
        public int kills_lab_kit_attacking_team_enderman { get; set; }

        [JsonProperty("assists_kit_attacking_team_enderman")]
        public int assists_kit_attacking_team_enderman { get; set; }

        [JsonProperty("lab_win_slime_lab_kit_enderchest_team_enderchest")]
        public int lab_win_slime_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_kit_enderchest_team_enderchest")]
        public int lab_win_tnt_madness_lab_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_snowman")]
        public int bow_kills_kit_attacking_team_snowman { get; set; }

        [JsonProperty("heads_kit_attacking_team_snowman")]
        public int heads_kit_attacking_team_snowman { get; set; }

        [JsonProperty("heads_eww")]
        public int heads_eww { get; set; }

        [JsonProperty("heads_eww_solo")]
        public int heads_eww_solo { get; set; }

        [JsonProperty("heads_eww_kit_attacking_team_snowman")]
        public int heads_eww_kit_attacking_team_snowman { get; set; }

        [JsonProperty("public HeadCollection head_collection")]
        public HeadCollection head_collection { get; set; }

        [JsonProperty("angel_of_death_level")]
        public int angel_of_death_level { get; set; }

        [JsonProperty("heads_decent")]
        public int heads_decent { get; set; }

        [JsonProperty("heads_decent_kit_enderchest_team_enderchest")]
        public int heads_decent_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("heads_team")]
        public int heads_team { get; set; }

        [JsonProperty("heads_kit_enderchest_team_enderchest")]
        public int heads_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("heads_decent_team")]
        public int heads_decent_team { get; set; }

        [JsonProperty("mob_kills_kit_enderchest_team_enderchest")]
        public int mob_kills_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("mob_kills_kit_attacking_team_enderman")]
        public int mob_kills_kit_attacking_team_enderman { get; set; }

        [JsonProperty("heads_divine")]
        public int heads_divine { get; set; }

        [JsonProperty("heads_divine_team")]
        public int heads_divine_team { get; set; }

        [JsonProperty("heads_decent_kit_attacking_team_enderman")]
        public int heads_decent_kit_attacking_team_enderman { get; set; }

        [JsonProperty("heads_divine_kit_attacking_team_enderman")]
        public int heads_divine_kit_attacking_team_enderman { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_enderman")]
        public int bow_kills_kit_attacking_team_enderman { get; set; }

        [JsonProperty("heads_kit_attacking_team_enderman")]
        public int heads_kit_attacking_team_enderman { get; set; }

        [JsonProperty("challenge_wins_1_kit_attacking_team_snowman")]
        public int challenge_wins_1_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_wins_archer")]
        public int challenge_wins_archer { get; set; }

        [JsonProperty("challenge_wins_archer_solo")]
        public int challenge_wins_archer_solo { get; set; }

        [JsonProperty("challenge_attempts_kit_attacking_team_snowman")]
        public int challenge_attempts_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_wins_archer_kit_attacking_team_snowman")]
        public int challenge_wins_archer_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_wins_kit_attacking_team_snowman")]
        public int challenge_wins_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_attempts_archer_kit_attacking_team_snowman")]
        public int challenge_attempts_archer_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_attempts_1_kit_attacking_team_snowman")]
        public int challenge_attempts_1_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_attempts_half_health_kit_attacking_team_snowman")]
        public int challenge_attempts_half_health_kit_attacking_team_snowman { get; set; }

        [JsonProperty("challenge_attempts_half_health")]
        public int challenge_attempts_half_health { get; set; }

        [JsonProperty("challenge_attempts_half_health_solo")]
        public int challenge_attempts_half_health_solo { get; set; }

        [JsonProperty("challenge_attempts_half_health_kit_enderchest_team_enderchest")]
        public int challenge_attempts_half_health_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_7_kit_enderchest_team_enderchest")]
        public int challenge_attempts_7_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_no_block_solo")]
        public int challenge_attempts_no_block_solo { get; set; }

        [JsonProperty("challenge_attempts_no_block")]
        public int challenge_attempts_no_block { get; set; }

        [JsonProperty("challenge_attempts_7_solo")]
        public int challenge_attempts_7_solo { get; set; }

        [JsonProperty("challenge_attempts_paper_kit_enderchest_team_enderchest")]
        public int challenge_attempts_paper_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_rookie_kit_enderchest_team_enderchest")]
        public int challenge_attempts_rookie_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_no_block_kit_enderchest_team_enderchest")]
        public int challenge_attempts_no_block_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_no_chest_kit_enderchest_team_enderchest")]
        public int challenge_attempts_no_chest_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_archer_kit_enderchest_team_enderchest")]
        public int challenge_attempts_archer_kit_enderchest_team_enderchest { get; set; }

        [JsonProperty("challenge_attempts_7")]
        public int challenge_attempts_7 { get; set; }

        [JsonProperty("challenge_attempts_kit_supporting_team_zookeeper")]
        public int challenge_attempts_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("challenge_attempts_half_health_kit_supporting_team_zookeeper")]
        public int challenge_attempts_half_health_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("challenge_attempts_1_kit_supporting_team_zookeeper")]
        public int challenge_attempts_1_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_decent_kit_supporting_team_zookeeper")]
        public int heads_decent_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_kit_supporting_team_zookeeper")]
        public int heads_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_tasty_solo")]
        public int heads_tasty_solo { get; set; }

        [JsonProperty("heads_tasty")]
        public int heads_tasty { get; set; }

        [JsonProperty("heads_tasty_kit_supporting_team_zookeeper")]
        public int heads_tasty_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_decent_solo")]
        public int heads_decent_solo { get; set; }

        [JsonProperty("assists_kit_supporting_team_zookeeper")]
        public int assists_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_salty")]
        public int heads_salty { get; set; }

        [JsonProperty("heads_meh")]
        public int heads_meh { get; set; }

        [JsonProperty("heads_meh_solo")]
        public int heads_meh_solo { get; set; }

        [JsonProperty("heads_meh_kit_attacking_team_enderman")]
        public int heads_meh_kit_attacking_team_enderman { get; set; }

        [JsonProperty("heads_salty_solo")]
        public int heads_salty_solo { get; set; }

        [JsonProperty("heads_salty_kit_attacking_team_enderman")]
        public int heads_salty_kit_attacking_team_enderman { get; set; }

        [JsonProperty("fastest_win_kit_supporting_team_rookie")]
        public int fastest_win_kit_supporting_team_rookie { get; set; }

        [JsonProperty("winstreak_kit_supporting_team_rookie")]
        public int winstreak_kit_supporting_team_rookie { get; set; }

        [JsonProperty("wins_kit_supporting_team_rookie")]
        public int wins_kit_supporting_team_rookie { get; set; }

        [JsonProperty("killstreak_kit_supporting_team_rookie")]
        public int killstreak_kit_supporting_team_rookie { get; set; }

        [JsonProperty("quickjoin_uses_Martian")]
        public int quickjoin_uses_Martian { get; set; }

        [JsonProperty("heads_divine_kit_supporting_team_zookeeper")]
        public int heads_divine_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_divine_solo")]
        public int heads_divine_solo { get; set; }

        [JsonProperty("heads_salty_kit_supporting_team_zookeeper")]
        public int heads_salty_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_tasty_team")]
        public int heads_tasty_team { get; set; }

        [JsonProperty("heads_meh_team")]
        public int heads_meh_team { get; set; }

        [JsonProperty("heads_meh_kit_supporting_team_zookeeper")]
        public int heads_meh_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("mob_kills_kit_supporting_team_zookeeper")]
        public int mob_kills_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("void_kills_lab_kit_supporting_team_zookeeper")]
        public int void_kills_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("arrows_hit_lab_kit_supporting_team_zookeeper")]
        public int arrows_hit_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("kills_lab_kit_supporting_team_zookeeper")]
        public int kills_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("arrows_shot_lab_kit_supporting_team_zookeeper")]
        public int arrows_shot_lab_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_eww_kit_supporting_team_zookeeper")]
        public int heads_eww_kit_supporting_team_zookeeper { get; set; }

        [JsonProperty("heads_yucky_solo")]
        public int heads_yucky_solo { get; set; }

        [JsonProperty("heads_yucky")]
        public int heads_yucky { get; set; }

        [JsonProperty("heads_yucky_kit_attacking_team_enderman")]
        public int heads_yucky_kit_attacking_team_enderman { get; set; }

        [JsonProperty("heads_tasty_kit_attacking_team_enderman")]
        public int heads_tasty_kit_attacking_team_enderman { get; set; }

        [JsonProperty("heads_salty_team")]
        public int heads_salty_team { get; set; }

    }
}