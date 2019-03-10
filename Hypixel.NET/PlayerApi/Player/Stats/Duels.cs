using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Duels
    {
        [JsonProperty("show_lb_option")]
        public string ShowLbOption { get; set; }

        [JsonProperty("games_played_duels")]
        public long GamesPlayedDuels { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_four")]
        public long DuelsWinstreakBestUhcFour { get; set; }

        [JsonProperty("duels_recently_played")]
        public string DuelsRecentlyPlayed { get; set; }

        [JsonProperty("sw_duels_kit")]
        public string SwDuelsKit { get; set; }

        [JsonProperty("kit_menu_option")]
        public string KitMenuOption { get; set; }

        [JsonProperty("rematch_option_1")]
        public string RematchOption1 { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_duel")]
        public long DuelsWinstreakBestUhcDuel { get; set; }

        [JsonProperty("duels_winstreak_best_sw_duel")]
        public long DuelsWinstreakBestSwDuel { get; set; }

        [JsonProperty("duels_winstreak_sw_duel")]
        public long DuelsWinstreakSwDuel { get; set; }

        [JsonProperty("duels_winstreak_best_classic_duel")]
        public long DuelsWinstreakBestClassicDuel { get; set; }

        [JsonProperty("mw_duels_class")]
        public string MwDuelsClass { get; set; }

        [JsonProperty("duels_winstreak_mw_duel")]
        public long DuelsWinstreakMwDuel { get; set; }

        [JsonProperty("duels_winstreak_best_mw_duel")]
        public long DuelsWinstreakBestMwDuel { get; set; }

        [JsonProperty("duels_winstreak_classic_duel")]
        public long DuelsWinstreakClassicDuel { get; set; }

        [JsonProperty("duels_winstreak_uhc_four")]
        public long DuelsWinstreakUhcFour { get; set; }

        [JsonProperty("duels_winstreak_bow_duel")]
        public long DuelsWinstreakBowDuel { get; set; }

        [JsonProperty("duels_winstreak_best_bow_duel")]
        public long DuelsWinstreakBestBowDuel { get; set; }

        [JsonProperty("duels_winstreak_best_op_duel")]
        public long DuelsWinstreakBestOpDuel { get; set; }

        [JsonProperty("duels_winstreak_op_duel")]
        public long DuelsWinstreakOpDuel { get; set; }

        [JsonProperty("duels_winstreak_best_combo_duel")]
        public long DuelsWinstreakBestComboDuel { get; set; }

        [JsonProperty("duels_winstreak_combo_duel")]
        public long DuelsWinstreakComboDuel { get; set; }

        [JsonProperty("melee_swings")]
        public long MeleeSwings { get; set; }

        [JsonProperty("uhc_duel_health_regenerated")]
        public long UhcDuelHealthRegenerated { get; set; }

        [JsonProperty("melee_hits")]
        public long MeleeHits { get; set; }

        [JsonProperty("uhc_duel_bow_shots")]
        public long UhcDuelBowShots { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("rounds_played")]
        public long RoundsPlayed { get; set; }

        [JsonProperty("uhc_duel_melee_swings")]
        public long UhcDuelMeleeSwings { get; set; }

        [JsonProperty("uhc_duel_kills")]
        public long UhcDuelKills { get; set; }

        [JsonProperty("bow_shots")]
        public long BowShots { get; set; }

        [JsonProperty("uhc_duel_bow_hits")]
        public long UhcDuelBowHits { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("uhc_duel_rounds_played")]
        public long UhcDuelRoundsPlayed { get; set; }

        [JsonProperty("bow_hits")]
        public long BowHits { get; set; }

        [JsonProperty("uhc_duel_damage_dealt")]
        public long UhcDuelDamageDealt { get; set; }

        [JsonProperty("health_regenerated")]
        public long HealthRegenerated { get; set; }

        [JsonProperty("uhc_duel_wins")]
        public long UhcDuelWins { get; set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }

        [JsonProperty("uhc_duel_melee_hits")]
        public long UhcDuelMeleeHits { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("uhc_duel_losses")]
        public long UhcDuelLosses { get; set; }

        [JsonProperty("uhc_duel_deaths")]
        public long UhcDuelDeaths { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("selected_2")]
        public string Selected2 { get; set; }

        [JsonProperty("selected_1")]
        public string Selected1 { get; set; }

        [JsonProperty("uhc_tournament_melee_hits")]
        public long UhcTournamentMeleeHits { get; set; }

        [JsonProperty("uhc_tournament_health_regenerated")]
        public long UhcTournamentHealthRegenerated { get; set; }

        [JsonProperty("uhc_tournament_damage_dealt")]
        public long UhcTournamentDamageDealt { get; set; }

        [JsonProperty("uhc_tournament_melee_swings")]
        public long UhcTournamentMeleeSwings { get; set; }

        [JsonProperty("uhc_tournament_rounds_played")]
        public long UhcTournamentRoundsPlayed { get; set; }

        [JsonProperty("uhc_tournament_bow_hits")]
        public long UhcTournamentBowHits { get; set; }

        [JsonProperty("uhc_tournament_bow_shots")]
        public long UhcTournamentBowShots { get; set; }

        [JsonProperty("sw_tournament_rounds_played")]
        public long SwTournamentRoundsPlayed { get; set; }

        [JsonProperty("sw_tournament_melee_hits")]
        public long SwTournamentMeleeHits { get; set; }

        [JsonProperty("sw_tournament_melee_swings")]
        public long SwTournamentMeleeSwings { get; set; }

        [JsonProperty("sw_duel_damage_dealt")]
        public long SwDuelDamageDealt { get; set; }

        [JsonProperty("sw_duel_rounds_played")]
        public long SwDuelRoundsPlayed { get; set; }

        [JsonProperty("sw_duel_melee_hits")]
        public long SwDuelMeleeHits { get; set; }

        [JsonProperty("sw_duel_melee_swings")]
        public long SwDuelMeleeSwings { get; set; }

        [JsonProperty("uhc_tournament_deaths")]
        public long UhcTournamentDeaths { get; set; }

        [JsonProperty("uhc_tournament_kills")]
        public long UhcTournamentKills { get; set; }

        [JsonProperty("chat_enabled")]
        public string ChatEnabled { get; set; }

        [JsonProperty("current_winstreak")]
        public long CurrentWinstreak { get; set; }

        [JsonProperty("best_skywars_winstreak")]
        public long BestSkywarsWinstreak { get; set; }

        [JsonProperty("best_overall_winstreak")]
        public long BestOverallWinstreak { get; set; }

        [JsonProperty("current_skywars_winstreak")]
        public long CurrentSkywarsWinstreak { get; set; }

        [JsonProperty("sw_duel_champion_kit_wins")]
        public long SwDuelChampionKitWins { get; set; }

        [JsonProperty("kit_wins")]
        public long KitWins { get; set; }

        [JsonProperty("sw_duel_kit_wins")]
        public long SwDuelKitWins { get; set; }

        [JsonProperty("champion_kit_wins")]
        public long ChampionKitWins { get; set; }

        [JsonProperty("sw_duel_wins")]
        public long SwDuelWins { get; set; }

        [JsonProperty("bowspleef_duel_rounds_played")]
        public long BowspleefDuelRoundsPlayed { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("sumo_tournament_deaths")]
        public long SumoTournamentDeaths { get; set; }

        [JsonProperty("sumo_tournament_rounds_played")]
        public long SumoTournamentRoundsPlayed { get; set; }

        [JsonProperty("sumo_tournament_losses")]
        public long SumoTournamentLosses { get; set; }

        [JsonProperty("sumo_tournament_melee_hits")]
        public long SumoTournamentMeleeHits { get; set; }

        [JsonProperty("sumo_tournament_melee_swings")]
        public long SumoTournamentMeleeSwings { get; set; }

        [JsonProperty("classic_duel_rounds_played")]
        public long ClassicDuelRoundsPlayed { get; set; }

        [JsonProperty("classic_duel_melee_hits")]
        public long ClassicDuelMeleeHits { get; set; }

        [JsonProperty("classic_duel_health_regenerated")]
        public long ClassicDuelHealthRegenerated { get; set; }

        [JsonProperty("classic_duel_damage_dealt")]
        public long ClassicDuelDamageDealt { get; set; }

        [JsonProperty("classic_duel_bow_hits")]
        public long ClassicDuelBowHits { get; set; }

        [JsonProperty("classic_duel_bow_shots")]
        public long ClassicDuelBowShots { get; set; }

        [JsonProperty("classic_duel_melee_swings")]
        public long ClassicDuelMeleeSwings { get; set; }

        [JsonProperty("current_uhc_winstreak")]
        public long CurrentUhcWinstreak { get; set; }

        [JsonProperty("best_uhc_winstreak")]
        public long BestUhcWinstreak { get; set; }

        [JsonProperty("uhc_four_health_regenerated")]
        public long UhcFourHealthRegenerated { get; set; }

        [JsonProperty("uhc_four_melee_swings")]
        public long UhcFourMeleeSwings { get; set; }

        [JsonProperty("uhc_four_bow_hits")]
        public long UhcFourBowHits { get; set; }

        [JsonProperty("uhc_four_melee_hits")]
        public long UhcFourMeleeHits { get; set; }

        [JsonProperty("uhc_four_rounds_played")]
        public long UhcFourRoundsPlayed { get; set; }

        [JsonProperty("uhc_four_damage_dealt")]
        public long UhcFourDamageDealt { get; set; }

        [JsonProperty("uhc_four_bow_shots")]
        public long UhcFourBowShots { get; set; }

        [JsonProperty("selected_1_new")]
        public string Selected1_New { get; set; }

        [JsonProperty("selected_2_new")]
        public string Selected2_New { get; set; }

        [JsonProperty("uhc_tournament_losses")]
        public long UhcTournamentLosses { get; set; }

        [JsonProperty("all_modes_rookie_title_prestige")]
        public long AllModesRookieTitlePrestige { get; set; }

        [JsonProperty("blitz_rookie_title_prestige")]
        public long BlitzRookieTitlePrestige { get; set; }

        [JsonProperty("sumo_rookie_title_prestige")]
        public long SumoRookieTitlePrestige { get; set; }

        [JsonProperty("uhc_rookie_title_prestige")]
        public long UhcRookieTitlePrestige { get; set; }

        [JsonProperty("tournament_rookie_title_prestige")]
        public long TournamentRookieTitlePrestige { get; set; }

        [JsonProperty("op_rookie_title_prestige")]
        public long OpRookieTitlePrestige { get; set; }

        [JsonProperty("classic_rookie_title_prestige")]
        public long ClassicRookieTitlePrestige { get; set; }

        [JsonProperty("bow_rookie_title_prestige")]
        public long BowRookieTitlePrestige { get; set; }

        [JsonProperty("skywars_rookie_title_prestige")]
        public long SkywarsRookieTitlePrestige { get; set; }

        [JsonProperty("mega_walls_rookie_title_prestige")]
        public long MegaWallsRookieTitlePrestige { get; set; }

        [JsonProperty("combo_rookie_title_prestige")]
        public long ComboRookieTitlePrestige { get; set; }

        [JsonProperty("tnt_games_rookie_title_prestige")]
        public long TntGamesRookieTitlePrestige { get; set; }

        [JsonProperty("no_debuff_rookie_title_prestige")]
        public long NoDebuffRookieTitlePrestige { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("uhc_doubles_blocks_placed")]
        public long UhcDoublesBlocksPlaced { get; set; }

        [JsonProperty("uhc_doubles_bow_shots")]
        public long UhcDoublesBowShots { get; set; }

        [JsonProperty("golden_apples_eaten")]
        public long GoldenApplesEaten { get; set; }

        [JsonProperty("uhc_doubles_rounds_played")]
        public long UhcDoublesRoundsPlayed { get; set; }

        [JsonProperty("uhc_doubles_golden_apples_eaten")]
        public long UhcDoublesGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_doubles_melee_swings")]
        public long UhcDoublesMeleeSwings { get; set; }

        [JsonProperty("uhc_doubles_health_regenerated")]
        public long UhcDoublesHealthRegenerated { get; set; }

        [JsonProperty("uhc_doubles_melee_hits")]
        public long UhcDoublesMeleeHits { get; set; }

        [JsonProperty("uhc_doubles_damage_dealt")]
        public long UhcDoublesDamageDealt { get; set; }

        [JsonProperty("uhc_doubles_bow_hits")]
        public long UhcDoublesBowHits { get; set; }

        [JsonProperty("uhc_four_golden_apples_eaten")]
        public long UhcFourGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_four_blocks_placed")]
        public long UhcFourBlocksPlaced { get; set; }

        [JsonProperty("uhc_duel_blocks_placed")]
        public long UhcDuelBlocksPlaced { get; set; }

        [JsonProperty("uhc_duel_golden_apples_eaten")]
        public long UhcDuelGoldenApplesEaten { get; set; }

        [JsonProperty("maps_won_on")]
        public List<string> MapsWonOn { get; set; }

        [JsonProperty("uhc_doubles_wins")]
        public long UhcDoublesWins { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_doubles")]
        public long DuelsWinstreakBestUhcDoubles { get; set; }

        [JsonProperty("uhc_doubles_kills")]
        public long UhcDoublesKills { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_duel")]
        public long CurrentWinstreakModeUhcDuel { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_duel")]
        public long BestWinstreakModeUhcDuel { get; set; }

        [JsonProperty("bridge_rookie_title_prestige")]
        public long BridgeRookieTitlePrestige { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_doubles")]
        public long BestWinstreakModeUhcDoubles { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_doubles")]
        public long CurrentWinstreakModeUhcDoubles { get; set; }

        [JsonProperty("uhc_doubles_deaths")]
        public long UhcDoublesDeaths { get; set; }

        [JsonProperty("uhc_doubles_losses")]
        public long UhcDoublesLosses { get; set; }

        [JsonProperty("uhc_duel")]
        public bool UhcDuel { get; set; }

        [JsonProperty("uhc_doubles")]
        public bool UhcDoubles { get; set; }

        [JsonProperty("combo_duel_melee_hits")]
        public long ComboDuelMeleeHits { get; set; }

        [JsonProperty("combo_duel_melee_swings")]
        public long ComboDuelMeleeSwings { get; set; }

        [JsonProperty("combo_duel_rounds_played")]
        public long ComboDuelRoundsPlayed { get; set; }

        [JsonProperty("combo_duel_health_regenerated")]
        public long ComboDuelHealthRegenerated { get; set; }

        [JsonProperty("combo_duel_golden_apples_eaten")]
        public long ComboDuelGoldenApplesEaten { get; set; }

        [JsonProperty("bridge_four_rounds_played")]
        public long BridgeFourRoundsPlayed { get; set; }

        [JsonProperty("bridge_four_damage_dealt")]
        public long BridgeFourDamageDealt { get; set; }

        [JsonProperty("bridge_four_bow_hits")]
        public long BridgeFourBowHits { get; set; }

        [JsonProperty("bridge_four_blocks_placed")]
        public long BridgeFourBlocksPlaced { get; set; }

        [JsonProperty("bridge_four_bow_shots")]
        public long BridgeFourBowShots { get; set; }

        [JsonProperty("bridge_four_melee_swings")]
        public long BridgeFourMeleeSwings { get; set; }

        [JsonProperty("bridge_four_health_regenerated")]
        public long BridgeFourHealthRegenerated { get; set; }

        [JsonProperty("bridge_four_melee_hits")]
        public long BridgeFourMeleeHits { get; set; }

        [JsonProperty("sw_duels_kit_new2")]
        public string SwDuelsKitNew2 { get; set; }

        [JsonProperty("sw_duel_health_regenerated")]
        public long SwDuelHealthRegenerated { get; set; }

        [JsonProperty("bow_duel_bow_hits")]
        public long BowDuelBowHits { get; set; }

        [JsonProperty("bow_duel_bow_shots")]
        public long BowDuelBowShots { get; set; }

        [JsonProperty("bow_duel_health_regenerated")]
        public long BowDuelHealthRegenerated { get; set; }

        [JsonProperty("bow_duel_damage_dealt")]
        public long BowDuelDamageDealt { get; set; }

        [JsonProperty("bow_duel_rounds_played")]
        public long BowDuelRoundsPlayed { get; set; }

        [JsonProperty("sw_duel_blocks_placed")]
        public long SwDuelBlocksPlaced { get; set; }

        [JsonProperty("uhc_meetup_health_regenerated")]
        public long UhcMeetupHealthRegenerated { get; set; }

        [JsonProperty("uhc_meetup_bow_shots")]
        public long UhcMeetupBowShots { get; set; }

        [JsonProperty("uhc_meetup_melee_hits")]
        public long UhcMeetupMeleeHits { get; set; }

        [JsonProperty("uhc_meetup_bow_hits")]
        public long UhcMeetupBowHits { get; set; }

        [JsonProperty("uhc_meetup_damage_dealt")]
        public long UhcMeetupDamageDealt { get; set; }

        [JsonProperty("uhc_meetup_blocks_placed")]
        public long UhcMeetupBlocksPlaced { get; set; }

        [JsonProperty("uhc_meetup_rounds_played")]
        public long UhcMeetupRoundsPlayed { get; set; }

        [JsonProperty("uhc_meetup_melee_swings")]
        public long UhcMeetupMeleeSwings { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_meetup")]
        public long CurrentWinstreakModeUhcMeetup { get; set; }

        [JsonProperty("uhc_meetup_losses")]
        public long UhcMeetupLosses { get; set; }

        [JsonProperty("uhc_meetup_deaths")]
        public long UhcMeetupDeaths { get; set; }

        [JsonProperty("uhc_meetup_kills")]
        public long UhcMeetupKills { get; set; }
    }
}