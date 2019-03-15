using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Duels
    {
        #region general
        [JsonProperty("games_played_duels")]
        public int GamesPlayedDuels { get; set; }

        [JsonProperty("duels_recently_played")]
        public string DuelsRecentlyPlayed { get; set; }

        [JsonProperty("melee_swings")]
        public int MeleeSwings { get; set; }

        [JsonProperty("melee_hits")]
        public int MeleeHits { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("rounds_played")]
        public int RoundsPlayed { get; set; }

        [JsonProperty("bow_shots")]
        public int BowShots { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("bow_hits")]
        public int BowHits { get; set; }

        [JsonProperty("health_regenerated")]
        public int HealthRegenerated { get; set; }

        [JsonProperty("damage_dealt")]
        public int DamageDealt { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("current_winstreak")]
        public int CurrentWinstreak { get; set; }

        [JsonProperty("best_overall_winstreak")]
        public int BestOverallWinstreak { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("blocks_placed")]
        public int BlocksPlaced { get; set; }

        [JsonProperty("maps_won_on")]
        public List<string> MapsWonOn { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("meters_travelled")]
        public int MetersTravelled { get; set; }

        [JsonProperty("duels_chests")]
        public int DuelsChests { get; set; }

        [JsonProperty("Duels_openedRares")]
        public int DuelsOpenedRares { get; set; }

        [JsonProperty("Duels_openedChests")]
        public int DuelsOpenedChests { get; set; }

        [JsonProperty("Duels_openedCommons")]
        public int DuelsOpenedCommons { get; set; }

        [JsonProperty("equipped_custom_titles")]
        public string EquippedCustomTitles { get; set; }
        #endregion

        #region Uhc
        [JsonProperty("duels_winstreak_best_uhc_four")]
        public int DuelsWinstreakBestUhcFour { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_duel")]
        public int DuelsWinstreakBestUhcDuel { get; set; }

        [JsonProperty("duels_winstreak_uhc_four")]
        public int DuelsWinstreakUhcFour { get; set; }

        [JsonProperty("uhc_duel_health_regenerated")]
        public int UhcDuelHealthRegenerated { get; set; }

        [JsonProperty("uhc_duel_bow_shots")]
        public int UhcDuelBowShots { get; set; }

        [JsonProperty("uhc_duel_melee_swings")]
        public int UhcDuelMeleeSwings { get; set; }

        [JsonProperty("uhc_duel_kills")]
        public int UhcDuelKills { get; set; }

        [JsonProperty("uhc_duel_bow_hits")]
        public int UhcDuelBowHits { get; set; }

        [JsonProperty("uhc_duel_rounds_played")]
        public int UhcDuelRoundsPlayed { get; set; }

        [JsonProperty("uhc_duel_damage_dealt")]
        public int UhcDuelDamageDealt { get; set; }

        [JsonProperty("uhc_duel_wins")]
        public int UhcDuelWins { get; set; }

        [JsonProperty("uhc_duel_melee_hits")]
        public int UhcDuelMeleeHits { get; set; }

        [JsonProperty("uhc_duel_losses")]
        public int UhcDuelLosses { get; set; }

        [JsonProperty("uhc_duel_deaths")]
        public int UhcDuelDeaths { get; set; }

        [JsonProperty("uhc_tournament_melee_hits")]
        public int UhcTournamentMeleeHits { get; set; }

        [JsonProperty("uhc_tournament_health_regenerated")]
        public int UhcTournamentHealthRegenerated { get; set; }

        [JsonProperty("uhc_tournament_damage_dealt")]
        public int UhcTournamentDamageDealt { get; set; }

        [JsonProperty("uhc_tournament_melee_swings")]
        public int UhcTournamentMeleeSwings { get; set; }

        [JsonProperty("uhc_tournament_rounds_played")]
        public int UhcTournamentRoundsPlayed { get; set; }

        [JsonProperty("uhc_tournament_bow_hits")]
        public int UhcTournamentBowHits { get; set; }

        [JsonProperty("uhc_tournament_bow_shots")]
        public int UhcTournamentBowShots { get; set; }

        [JsonProperty("uhc_tournament_deaths")]
        public int UhcTournamentDeaths { get; set; }

        [JsonProperty("uhc_tournament_kills")]
        public int UhcTournamentKills { get; set; }

        [JsonProperty("current_uhc_winstreak")]
        public int CurrentUhcWinstreak { get; set; }

        [JsonProperty("best_uhc_winstreak")]
        public int BestUhcWinstreak { get; set; }

        [JsonProperty("uhc_four_health_regenerated")]
        public int UhcFourHealthRegenerated { get; set; }

        [JsonProperty("uhc_four_melee_swings")]
        public int UhcFourMeleeSwings { get; set; }

        [JsonProperty("uhc_four_bow_hits")]
        public int UhcFourBowHits { get; set; }

        [JsonProperty("uhc_four_melee_hits")]
        public int UhcFourMeleeHits { get; set; }

        [JsonProperty("uhc_four_rounds_played")]
        public int UhcFourRoundsPlayed { get; set; }

        [JsonProperty("uhc_four_damage_dealt")]
        public int UhcFourDamageDealt { get; set; }

        [JsonProperty("uhc_four_bow_shots")]
        public int UhcFourBowShots { get; set; }

        [JsonProperty("uhc_tournament_losses")]
        public int UhcTournamentLosses { get; set; }

        [JsonProperty("uhc_doubles_blocks_placed")]
        public int UhcDoublesBlocksPlaced { get; set; }

        [JsonProperty("uhc_doubles_bow_shots")]
        public int UhcDoublesBowShots { get; set; }

        [JsonProperty("golden_apples_eaten")]
        public int GoldenApplesEaten { get; set; }

        [JsonProperty("uhc_doubles_rounds_played")]
        public int UhcDoublesRoundsPlayed { get; set; }

        [JsonProperty("uhc_doubles_golden_apples_eaten")]
        public int UhcDoublesGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_doubles_melee_swings")]
        public int UhcDoublesMeleeSwings { get; set; }

        [JsonProperty("uhc_doubles_health_regenerated")]
        public int UhcDoublesHealthRegenerated { get; set; }

        [JsonProperty("uhc_doubles_melee_hits")]
        public int UhcDoublesMeleeHits { get; set; }

        [JsonProperty("uhc_doubles_damage_dealt")]
        public int UhcDoublesDamageDealt { get; set; }

        [JsonProperty("uhc_doubles_bow_hits")]
        public int UhcDoublesBowHits { get; set; }

        [JsonProperty("uhc_four_golden_apples_eaten")]
        public int UhcFourGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_four_blocks_placed")]
        public int UhcFourBlocksPlaced { get; set; }

        [JsonProperty("uhc_duel_blocks_placed")]
        public int UhcDuelBlocksPlaced { get; set; }

        [JsonProperty("uhc_duel_golden_apples_eaten")]
        public int UhcDuelGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_doubles_wins")]
        public int UhcDoublesWins { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_doubles")]
        public int DuelsWinstreakBestUhcDoubles { get; set; }

        [JsonProperty("uhc_doubles_kills")]
        public int UhcDoublesKills { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_duel")]
        public int CurrentWinstreakModeUhcDuel { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_duel")]
        public int BestWinstreakModeUhcDuel { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_doubles")]
        public int BestWinstreakModeUhcDoubles { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_doubles")]
        public int CurrentWinstreakModeUhcDoubles { get; set; }

        [JsonProperty("uhc_doubles_deaths")]
        public int UhcDoublesDeaths { get; set; }

        [JsonProperty("uhc_doubles_losses")]
        public int UhcDoublesLosses { get; set; }

        [JsonProperty("uhc_duel")]
        public bool UhcDuel { get; set; }

        [JsonProperty("uhc_doubles")]
        public bool UhcDoubles { get; set; }

        [JsonProperty("uhc_meetup_health_regenerated")]
        public int UhcMeetupHealthRegenerated { get; set; }

        [JsonProperty("uhc_meetup_bow_shots")]
        public int UhcMeetupBowShots { get; set; }

        [JsonProperty("uhc_meetup_melee_hits")]
        public int UhcMeetupMeleeHits { get; set; }

        [JsonProperty("uhc_meetup_bow_hits")]
        public int UhcMeetupBowHits { get; set; }

        [JsonProperty("uhc_meetup_damage_dealt")]
        public int UhcMeetupDamageDealt { get; set; }

        [JsonProperty("uhc_meetup_blocks_placed")]
        public int UhcMeetupBlocksPlaced { get; set; }

        [JsonProperty("uhc_meetup_rounds_played")]
        public int UhcMeetupRoundsPlayed { get; set; }

        [JsonProperty("uhc_meetup_melee_swings")]
        public int UhcMeetupMeleeSwings { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_meetup")]
        public int CurrentWinstreakModeUhcMeetup { get; set; }

        [JsonProperty("uhc_meetup_losses")]
        public int UhcMeetupLosses { get; set; }

        [JsonProperty("uhc_meetup_deaths")]
        public int UhcMeetupDeaths { get; set; }

        [JsonProperty("uhc_meetup_kills")]
        public int UhcMeetupKills { get; set; }

        [JsonProperty("duels_winstreak_uhc_duel")]
        public int DuelsWinstreakUhcDuel { get; set; }

        [JsonProperty("uhc_four_wins")]
        public int UhcFourWins { get; set; }

        [JsonProperty("uhc_four_kills")]
        public int UhcFourKills { get; set; }

        [JsonProperty("uhc_four_deaths")]
        public int UhcFourDeaths { get; set; }

        [JsonProperty("uhc_four_losses")]
        public int UhcFourLosses { get; set; }
        #endregion

        #region skywars duels
        [JsonProperty("sw_duels_kit")]
        public string SwDuelsKit { get; set; }

        [JsonProperty("duels_winstreak_best_sw_duel")]
        public int DuelsWinstreakBestSwDuel { get; set; }

        [JsonProperty("duels_winstreak_sw_duel")]
        public int DuelsWinstreakSwDuel { get; set; }

        [JsonProperty("sw_tournament_rounds_played")]
        public int SwTournamentRoundsPlayed { get; set; }

        [JsonProperty("sw_tournament_melee_hits")]
        public int SwTournamentMeleeHits { get; set; }

        [JsonProperty("sw_tournament_melee_swings")]
        public int SwTournamentMeleeSwings { get; set; }

        [JsonProperty("sw_duel_damage_dealt")]
        public int SwDuelDamageDealt { get; set; }

        [JsonProperty("sw_duel_rounds_played")]
        public int SwDuelRoundsPlayed { get; set; }

        [JsonProperty("sw_duel_melee_hits")]
        public int SwDuelMeleeHits { get; set; }

        [JsonProperty("sw_duel_melee_swings")]
        public int SwDuelMeleeSwings { get; set; }

        [JsonProperty("best_skywars_winstreak")]
        public int BestSkywarsWinstreak { get; set; }

        [JsonProperty("current_skywars_winstreak")]
        public int CurrentSkywarsWinstreak { get; set; }

        [JsonProperty("sw_duel_champion_kit_wins")]
        public int SwDuelChampionKitWins { get; set; }

        [JsonProperty("kit_wins")]
        public int KitWins { get; set; }

        [JsonProperty("sw_duel_kit_wins")]
        public int SwDuelKitWins { get; set; }

        [JsonProperty("champion_kit_wins")]
        public int ChampionKitWins { get; set; }

        [JsonProperty("sw_duel_wins")]
        public int SwDuelWins { get; set; }

        [JsonProperty("sw_duels_kit_new2")]
        public string SwDuelsKitNew2 { get; set; }

        [JsonProperty("sw_duel_health_regenerated")]
        public int SwDuelHealthRegenerated { get; set; }

        [JsonProperty("sw_duel_blocks_placed")]
        public int SwDuelBlocksPlaced { get; set; }

        [JsonProperty("sw_duel_armorer_kit_wins")]
        public int SwDuelArmorerKitWins { get; set; }

        [JsonProperty("sw_duel_kills")]
        public int SwDuelKills { get; set; }

        [JsonProperty("armorer_kit_wins")]
        public int ArmorerKitWins { get; set; }

        [JsonProperty("sw_tournament_health_regenerated")]
        public int SwTournamentHealthRegenerated { get; set; }

        [JsonProperty("sw_tournament_damage_dealt")]
        public int SwTournamentDamageDealt { get; set; }

        [JsonProperty("sw_duel_losses")]
        public int SwDuelLosses { get; set; }

        [JsonProperty("sw_duel_deaths")]
        public int SwDuelDeaths { get; set; }

        [JsonProperty("sw_duel_bow_hits")]
        public int SwDuelBowHits { get; set; }

        [JsonProperty("scout_kit_wins")]
        public int ScoutKitWins { get; set; }

        [JsonProperty("sw_duel_scout_kit_wins")]
        public int SwDuelScoutKitWins { get; set; }

        [JsonProperty("sw_duel_bow_shots")]
        public int SwDuelBowShots { get; set; }

        [JsonProperty("sw_tournament_bow_hits")]
        public int SwTournamentBowHits { get; set; }

        [JsonProperty("sw_tournament_bow_shots")]
        public int SwTournamentBowShots { get; set; }

        [JsonProperty("sw_duels_kit_new")]
        public string SwDuelsKitNew { get; set; }

        [JsonProperty("skywars_rookie_title_prestige")]
        public int SkywarsRookieTitlePrestige { get; set; }

        [JsonProperty("sw_tournament_kills")]
        public int SwTournamentKills { get; set; }

        [JsonProperty("sw_tournament_deaths")]
        public int SwTournamentDeaths { get; set; }

        #endregion

        #region classic duels
        [JsonProperty("duels_winstreak_best_classic_duel")]
        public int DuelsWinstreakBestClassicDuel { get; set; }

        [JsonProperty("duels_winstreak_classic_duel")]
        public int DuelsWinstreakClassicDuel { get; set; }

        [JsonProperty("classic_duel_rounds_played")]
        public int ClassicDuelRoundsPlayed { get; set; }

        [JsonProperty("classic_duel_melee_hits")]
        public int ClassicDuelMeleeHits { get; set; }

        [JsonProperty("classic_duel_health_regenerated")]
        public int ClassicDuelHealthRegenerated { get; set; }

        [JsonProperty("classic_duel_damage_dealt")]
        public int ClassicDuelDamageDealt { get; set; }

        [JsonProperty("classic_duel_bow_hits")]
        public int ClassicDuelBowHits { get; set; }

        [JsonProperty("classic_duel_bow_shots")]
        public int ClassicDuelBowShots { get; set; }

        [JsonProperty("classic_duel_melee_swings")]
        public int ClassicDuelMeleeSwings { get; set; }

        [JsonProperty("current_classic_winstreak")]
        public int CurrentClassicWinstreak { get; set; }

        [JsonProperty("best_classic_winstreak")]
        public int BestClassicWinstreak { get; set; }

        [JsonProperty("classic_duel_kills")]
        public int ClassicDuelKills { get; set; }

        [JsonProperty("classic_duel_wins")]
        public int ClassicDuelWins { get; set; }

        [JsonProperty("classic_duel_losses")]
        public int ClassicDuelLosses { get; set; }

        [JsonProperty("classic_duel_deaths")]
        public int ClassicDuelDeaths { get; set; }

        [JsonProperty("best_winstreak_mode_classic_duel")]
        public int BestWinstreakModeClassicDuel { get; set; }

        [JsonProperty("current_winstreak_mode_classic_duel")]
        public int CurrentWinstreakModeClassicDuel { get; set; }
        #endregion

        #region mega walls duels
        [JsonProperty("mw_duels_class")]
        public string MwDuelsClass { get; set; }

        [JsonProperty("duels_winstreak_mw_duel")]
        public int DuelsWinstreakMwDuel { get; set; }

        [JsonProperty("duels_winstreak_best_mw_duel")]
        public int DuelsWinstreakBestMwDuel { get; set; }

        [JsonProperty("mw_duel_melee_swings")]
        public int MwDuelMeleeSwings { get; set; }

        [JsonProperty("mw_duel_melee_hits")]
        public int MwDuelMeleeHits { get; set; }

        [JsonProperty("mw_duel_health_regenerated")]
        public int MwDuelHealthRegenerated { get; set; }

        [JsonProperty("mw_duel_rounds_played")]
        public int MwDuelRoundsPlayed { get; set; }

        [JsonProperty("mw_duel_damage_dealt")]
        public int MwDuelDamageDealt { get; set; }

        [JsonProperty("mw_duel_bow_shots")]
        public int MwDuelBowShots { get; set; }

        [JsonProperty("mw_duel_bow_hits")]
        public int MwDuelBowHits { get; set; }

        [JsonProperty("current_mega_walls_winstreak")]
        public int CurrentMegaWallsWinstreak { get; set; }

        [JsonProperty("best_mega_walls_winstreak")]
        public int BestMegaWallsWinstreak { get; set; }

        [JsonProperty("mw_duel_herobrine_kit_wins")]
        public int MwDuelHerobrineKitWins { get; set; }

        [JsonProperty("herobrine_kit_wins")]
        public int HerobrineKitWins { get; set; }

        [JsonProperty("mw_duel_kit_wins")]
        public int MwDuelKitWins { get; set; }

        [JsonProperty("mw_duel_kills")]
        public int MwDuelKills { get; set; }

        [JsonProperty("mw_duel_wins")]
        public int MwDuelWins { get; set; }

        [JsonProperty("mw_duel_losses")]
        public int MwDuelLosses { get; set; }

        [JsonProperty("mw_duel_deaths")]
        public int MwDuelDeaths { get; set; }
        #endregion

        #region bow duels
        [JsonProperty("duels_winstreak_bow_duel")]
        public int DuelsWinstreakBowDuel { get; set; }

        [JsonProperty("duels_winstreak_best_bow_duel")]
        public int DuelsWinstreakBestBowDuel { get; set; }

        [JsonProperty("bow_duel_bow_hits")]
        public int BowDuelBowHits { get; set; }

        [JsonProperty("bow_duel_bow_shots")]
        public int BowDuelBowShots { get; set; }

        [JsonProperty("bow_duel_health_regenerated")]
        public int BowDuelHealthRegenerated { get; set; }

        [JsonProperty("bow_duel_damage_dealt")]
        public int BowDuelDamageDealt { get; set; }

        [JsonProperty("bow_duel_rounds_played")]
        public int BowDuelRoundsPlayed { get; set; }

        [JsonProperty("best_bow_winstreak")]
        public int BestBowWinstreak { get; set; }

        [JsonProperty("current_bow_winstreak")]
        public int CurrentBowWinstreak { get; set; }

        [JsonProperty("bow_duel_wins")]
        public int BowDuelWins { get; set; }

        [JsonProperty("bow_duel_deaths")]
        public int BowDuelDeaths { get; set; }

        [JsonProperty("bow_duel_losses")]
        public int BowDuelLosses { get; set; }

        [JsonProperty("bow_duel_kills")]
        public int BowDuelKills { get; set; }
        #endregion

        #region op duels
        [JsonProperty("duels_winstreak_best_op_duel")]
        public int DuelsWinstreakBestOpDuel { get; set; }

        [JsonProperty("duels_winstreak_op_duel")]
        public int DuelsWinstreakOpDuel { get; set; }
        #endregion

        #region combo duels
        [JsonProperty("duels_winstreak_best_combo_duel")]
        public int DuelsWinstreakBestComboDuel { get; set; }

        [JsonProperty("duels_winstreak_combo_duel")]
        public int DuelsWinstreakComboDuel { get; set; }

        [JsonProperty("combo_duel_melee_hits")]
        public int ComboDuelMeleeHits { get; set; }

        [JsonProperty("combo_duel_melee_swings")]
        public int ComboDuelMeleeSwings { get; set; }

        [JsonProperty("combo_duel_rounds_played")]
        public int ComboDuelRoundsPlayed { get; set; }

        [JsonProperty("combo_duel_health_regenerated")]
        public int ComboDuelHealthRegenerated { get; set; }

        [JsonProperty("combo_duel_golden_apples_eaten")]
        public int ComboDuelGoldenApplesEaten { get; set; }

        [JsonProperty("best_combo_winstreak")]
        public int BestComboWinstreak { get; set; }

        [JsonProperty("current_combo_winstreak")]
        public int CurrentComboWinstreak { get; set; }

        [JsonProperty("combo_duel_wins")]
        public int ComboDuelWins { get; set; }

        [JsonProperty("combo_duel_damage_dealt")]
        public int ComboDuelDamageDealt { get; set; }

        [JsonProperty("combo_duel_kills")]
        public int ComboDuelKills { get; set; }

        [JsonProperty("combo_duel_losses")]
        public int ComboDuelLosses { get; set; }

        [JsonProperty("combo_duel_deaths")]
        public int ComboDuelDeaths { get; set; }
        #endregion

        #region sumo
        [JsonProperty("sumo_tournament_deaths")]
        public int SumoTournamentDeaths { get; set; }

        [JsonProperty("sumo_tournament_rounds_played")]
        public int SumoTournamentRoundsPlayed { get; set; }

        [JsonProperty("sumo_tournament_losses")]
        public int SumoTournamentLosses { get; set; }

        [JsonProperty("sumo_tournament_melee_hits")]
        public int SumoTournamentMeleeHits { get; set; }

        [JsonProperty("sumo_tournament_melee_swings")]
        public int SumoTournamentMeleeSwings { get; set; }
        #endregion

        #region bowspleef

        [JsonProperty("bowspleef_duel_rounds_played")]
        public int BowspleefDuelRoundsPlayed { get; set; }

        #endregion

        #region bridge
        [JsonProperty("bridge_four_rounds_played")]
        public int BridgeFourRoundsPlayed { get; set; }

        [JsonProperty("bridge_four_damage_dealt")]
        public int BridgeFourDamageDealt { get; set; }

        [JsonProperty("bridge_four_bow_hits")]
        public int BridgeFourBowHits { get; set; }

        [JsonProperty("bridge_four_blocks_placed")]
        public int BridgeFourBlocksPlaced { get; set; }

        [JsonProperty("bridge_four_bow_shots")]
        public int BridgeFourBowShots { get; set; }

        [JsonProperty("bridge_four_melee_swings")]
        public int BridgeFourMeleeSwings { get; set; }

        [JsonProperty("bridge_four_health_regenerated")]
        public int BridgeFourHealthRegenerated { get; set; }

        [JsonProperty("bridge_four_melee_hits")]
        public int BridgeFourMeleeHits { get; set; }
        #endregion

        #region blitz
        [JsonProperty("blitz_duels_kit")]
        public string BlitzDuelsKit { get; set; }

        [JsonProperty("current_blitz_winstreak")]
        public int CurrentBlitzWinstreak { get; set; }

        [JsonProperty("best_blitz_winstreak")]
        public int BestBlitzWinstreak { get; set; }

        [JsonProperty("blitz_duel_melee_swings")]
        public int BlitzDuelMeleeSwings { get; set; }

        [JsonProperty("blitz_duel_damage_dealt")]
        public int BlitzDuelDamageDealt { get; set; }

        [JsonProperty("blitz_duel_melee_hits")]
        public int BlitzDuelMeleeHits { get; set; }

        [JsonProperty("blitz_duel_rounds_played")]
        public int BlitzDuelRoundsPlayed { get; set; }

        [JsonProperty("blitz_duel_wins")]
        public int BlitzDuelWins { get; set; }

        [JsonProperty("blitz_duel_health_regenerated")]
        public int BlitzDuelHealthRegenerated { get; set; }

        [JsonProperty("blitz_duel_kills")]
        public int BlitzDuelKills { get; set; }

        [JsonProperty("duels_winstreak_best_blitz_duel")]
        public int DuelsWinstreakBestBlitzDuel { get; set; }

        [JsonProperty("blitz_duel_losses")]
        public int BlitzDuelLosses { get; set; }

        [JsonProperty("blitz_duel_deaths")]
        public int BlitzDuelDeaths { get; set; }

        [JsonProperty("blitz_duel_bow_shots")]
        public int BlitzDuelBowShots { get; set; }

        [JsonProperty("blitz_duel_bow_hits")]
        public int BlitzDuelBowHits { get; set; }

        [JsonProperty("blitz_duel_kit_wins")]
        public int BlitzDuelKitWins { get; set; }

        [JsonProperty("blitz_duel_horsetamer_kit_wins")]
        public int BlitzDuelHorsetamerKitWins { get; set; }

        [JsonProperty("horsetamer_kit_wins")]
        public int HorsetamerKitWins { get; set; }

        [JsonProperty("blitz_duel_armorer_kit_wins")]
        public int BlitzDuelArmorerKitWins { get; set; }

        [JsonProperty("special_challenger")]
        public bool SpecialChallenger { get; set; }

        [JsonProperty("blitz_duel_blocks_placed")]
        public int BlitzDuelBlocksPlaced { get; set; }

        [JsonProperty("blitz_duel")]
        public bool BlitzDuel { get; set; }

        [JsonProperty("blitz_duel_baker_kit_wins")]
        public int BlitzDuelBakerKitWins { get; set; }

        [JsonProperty("baker_kit_wins")]
        public int BakerKitWins { get; set; }

        [JsonProperty("blitz_duel_necromancer_kit_wins")]
        public int BlitzDuelNecromancerKitWins { get; set; }

        [JsonProperty("necromancer_kit_wins")]
        public int NecromancerKitWins { get; set; }

        [JsonProperty("golem_kit_wins")]
        public int GolemKitWins { get; set; }

        [JsonProperty("blitz_duel_golem_kit_wins")]
        public int BlitzDuelGolemKitWins { get; set; }

        [JsonProperty("blitz_duel_fisherman_kit_wins")]
        public int BlitzDuelFishermanKitWins { get; set; }

        [JsonProperty("fisherman_kit_wins")]
        public int FishermanKitWins { get; set; }

        [JsonProperty("knight_kit_wins")]
        public int KnightKitWins { get; set; }

        [JsonProperty("blitz_duel_knight_kit_wins")]
        public int BlitzDuelKnightKitWins { get; set; }

        [JsonProperty("hunter_kit_wins")]
        public int HunterKitWins { get; set; }

        [JsonProperty("blitz_duel_hunter_kit_wins")]
        public int BlitzDuelHunterKitWins { get; set; }

        [JsonProperty("blitz_duel_astronaut_kit_wins")]
        public int BlitzDuelAstronautKitWins { get; set; }

        [JsonProperty("astronaut_kit_wins")]
        public int AstronautKitWins { get; set; }

        [JsonProperty("blitz_duel_jockey_kit_wins")]
        public int BlitzDuelJockeyKitWins { get; set; }

        [JsonProperty("jockey_kit_wins")]
        public int JockeyKitWins { get; set; }

        [JsonProperty("arachnologist_kit_wins")]
        public int ArachnologistKitWins { get; set; }

        [JsonProperty("blitz_duel_arachnologist_kit_wins")]
        public int BlitzDuelArachnologistKitWins { get; set; }

        [JsonProperty("archer_kit_wins")]
        public int ArcherKitWins { get; set; }

        [JsonProperty("blitz_duel_archer_kit_wins")]
        public int BlitzDuelArcherKitWins { get; set; }

        #endregion

        #region potion duel
        [JsonProperty("potion_duel_heal_pots_used")]
        public int PotionDuelHealPotsUsed { get; set; }

        [JsonProperty("potion_duel_melee_swings")]
        public int PotionDuelMeleeSwings { get; set; }

        [JsonProperty("potion_duel_rounds_played")]
        public int PotionDuelRoundsPlayed { get; set; }

        [JsonProperty("potion_duel_melee_hits")]
        public int PotionDuelMeleeHits { get; set; }

        [JsonProperty("potion_duel_health_regenerated")]
        public int PotionDuelHealthRegenerated { get; set; }

        [JsonProperty("potion_duel_damage_dealt")]
        public int PotionDuelDamageDealt { get; set; }

        [JsonProperty("heal_pots_used")]
        public int HealPotsUsed { get; set; }

        [JsonProperty("potion_duel_deaths")]
        public int PotionDuelDeaths { get; set; }

        [JsonProperty("potion_duel_losses")]
        public int PotionDuelLosses { get; set; }

        [JsonProperty("potion_duel_kills")]
        public int PotionDuelKills { get; set; }

        [JsonProperty("potion_duel_wins")]
        public int PotionDuelWins { get; set; }

        [JsonProperty("duels_winstreak_best_potion_duel")]
        public int DuelsWinstreakBestPotionDuel { get; set; }
        #endregion

        #region sumo duel
        [JsonProperty("sumo_duel_melee_swings")]
        public int SumoDuelMeleeSwings { get; set; }

        [JsonProperty("sumo_duel_rounds_played")]
        public int SumoDuelRoundsPlayed { get; set; }

        [JsonProperty("sumo_duel_melee_hits")]
        public int SumoDuelMeleeHits { get; set; }

        [JsonProperty("current_sumo_winstreak")]
        public int CurrentSumoWinstreak { get; set; }

        [JsonProperty("sumo_duel_losses")]
        public int SumoDuelLosses { get; set; }

        [JsonProperty("sumo_duel_deaths")]
        public int SumoDuelDeaths { get; set; }

        [JsonProperty("best_sumo_winstreak")]
        public int BestSumoWinstreak { get; set; }

        [JsonProperty("sumo_duel_kills")]
        public int SumoDuelKills { get; set; }

        [JsonProperty("sumo_duel_wins")]
        public int SumoDuelWins { get; set; }

        [JsonProperty("duels_winstreak_best_sumo_duel")]
        public int DuelsWinstreakBestSumoDuel { get; set; }

        [JsonProperty("current_winstreak_mode_sumo_duel")]
        public int CurrentWinstreakModeSumoDuel { get; set; }
        #endregion

        #region prestige
        [JsonProperty("all_modes_diamond_title_prestige")]
        public int AllModesDiamondTitlePrestige { get; set; }

        [JsonProperty("classic_rookie_title_prestige")]
        public int ClassicRookieTitlePrestige { get; set; }

        [JsonProperty("op_rookie_title_prestige")]
        public int OpRookieTitlePrestige { get; set; }

        [JsonProperty("tournament_rookie_title_prestige")]
        public int TournamentRookieTitlePrestige { get; set; }

        [JsonProperty("combo_rookie_title_prestige")]
        public int ComboRookieTitlePrestige { get; set; }

        [JsonProperty("sumo_rookie_title_prestige")]
        public int SumoRookieTitlePrestige { get; set; }

        [JsonProperty("tnt_games_rookie_title_prestige")]
        public int TntGamesRookieTitlePrestige { get; set; }

        [JsonProperty("bow_rookie_title_prestige")]
        public int BowRookieTitlePrestige { get; set; }

        [JsonProperty("mega_walls_rookie_title_prestige")]
        public int MegaWallsRookieTitlePrestige { get; set; }

        [JsonProperty("blitz_master_title_prestige")]
        public int BlitzMasterTitlePrestige { get; set; }

        [JsonProperty("no_debuff_rookie_title_prestige")]
        public int NoDebuffRookieTitlePrestige { get; set; }

        [JsonProperty("uhc_rookie_title_prestige")]
        public int UhcRookieTitlePrestige { get; set; }

        [JsonProperty("bridge_rookie_title_prestige")]
        public int BridgeRookieTitlePrestige { get; set; }

        [JsonProperty("all_modes_master_title_prestige")]
        public int AllModesMasterTitlePrestige { get; set; }

        [JsonProperty("blitz_legend_title_prestige")]
        public int BlitzLegendTitlePrestige { get; set; }

        [JsonProperty("bridge_diamond_title_prestige")]
        public int BridgeDiamondTitlePrestige { get; set; }
        #endregion

        #region no debuff duels
        [JsonProperty("current_no_debuff_winstreak")]
        public int CurrentNoDebuffWinstreak { get; set; }

        [JsonProperty("best_no_debuff_winstreak")]
        public int BestNoDebuffWinstreak { get; set; }

        #endregion

        #region the bridge
        [JsonProperty("bridge_duel_wins")]
        public int BridgeDuelWins { get; set; }

        [JsonProperty("bridge_duel_deaths")]
        public int BridgeDuelDeaths { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("bridge_duel_goals")]
        public int BridgeDuelGoals { get; set; }

        [JsonProperty("bridge_duel_kills")]
        public int BridgeDuelKills { get; set; }

        [JsonProperty("bridge_duel_rounds_played")]
        public int BridgeDuelRoundsPlayed { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_doubles")]
        public int CurrentWinstreakModeBridgeDoubles { get; set; }

        [JsonProperty("best_bridge_winstreak")]
        public int BestBridgeWinstreak { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_doubles")]
        public int BestWinstreakModeBridgeDoubles { get; set; }

        [JsonProperty("current_bridge_winstreak")]
        public int CurrentBridgeWinstreak { get; set; }

        [JsonProperty("bridgeMapWins")]
        public List<string> BridgeMapWins { get; set; }

        [JsonProperty("bridge_doubles_bridge_deaths")]
        public int BridgeDoublesBridgeDeaths { get; set; }

        [JsonProperty("bridge_doubles_goals")]
        public int BridgeDoublesGoals { get; set; }

        [JsonProperty("bridge_doubles_bridge_kills")]
        public int BridgeDoublesBridgeKills { get; set; }

        [JsonProperty("bridge_doubles_blocks_placed")]
        public int BridgeDoublesBlocksPlaced { get; set; }

        [JsonProperty("bridge_doubles_bow_shots")]
        public int BridgeDoublesBowShots { get; set; }

        [JsonProperty("bridge_doubles_melee_hits")]
        public int BridgeDoublesMeleeHits { get; set; }

        [JsonProperty("bridge_doubles_wins")]
        public int BridgeDoublesWins { get; set; }

        [JsonProperty("bridge_doubles_rounds_played")]
        public int BridgeDoublesRoundsPlayed { get; set; }

        [JsonProperty("bridge_doubles_damage_dealt")]
        public int BridgeDoublesDamageDealt { get; set; }

        [JsonProperty("bridge_doubles_health_regenerated")]
        public int BridgeDoublesHealthRegenerated { get; set; }

        [JsonProperty("bridge_doubles_melee_swings")]
        public int BridgeDoublesMeleeSwings { get; set; }

        [JsonProperty("bridge_doubles_bow_hits")]
        public int BridgeDoublesBowHits { get; set; }

        [JsonProperty("bridge_kills")]
        public int BridgeKills { get; set; }

        [JsonProperty("bridge_deaths")]
        public int BridgeDeaths { get; set; }

        [JsonProperty("duels_winstreak_best_bridge_doubles")]
        public int DuelsWinstreakBestBridgeDoubles { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_four")]
        public int BestWinstreakModeBridgeFour { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_four")]
        public int CurrentWinstreakModeBridgeFour { get; set; }

        [JsonProperty("bridge_four_bridge_deaths")]
        public int BridgeFourBridgeDeaths { get; set; }

        [JsonProperty("bridge_four_bridge_kills")]
        public int BridgeFourBridgeKills { get; set; }

        [JsonProperty("bridge_four_goals")]
        public int BridgeFourGoals { get; set; }

        [JsonProperty("bridge_four_wins")]
        public int BridgeFourWins { get; set; }

        [JsonProperty("duels_winstreak_best_bridge_four")]
        public int DuelsWinstreakBestBridgeFour { get; set; }

        [JsonProperty("leaderboardPage_goals")]
        public int LeaderboardPageGoals { get; set; }

        [JsonProperty("leaderboardPage_win_streak")]
        public int LeaderboardPageWinStreak { get; set; }

        [JsonProperty("leaderboardPage_wins")]
        public int LeaderboardPageWins { get; set; }

        [JsonProperty("bridge_four_losses")]
        public int BridgeFourLosses { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_duel")]
        public int CurrentWinstreakModeBridgeDuel { get; set; }

        [JsonProperty("bridge_duel_health_regenerated")]
        public int BridgeDuelHealthRegenerated { get; set; }

        [JsonProperty("bridge_duel_damage_dealt")]
        public int BridgeDuelDamageDealt { get; set; }

        [JsonProperty("bridge_duel_melee_swings")]
        public int BridgeDuelMeleeSwings { get; set; }

        [JsonProperty("bridge_duel_bow_hits")]
        public int BridgeDuelBowHits { get; set; }

        [JsonProperty("bridge_duel_losses")]
        public int BridgeDuelLosses { get; set; }

        [JsonProperty("bridge_duel_bridge_deaths")]
        public int BridgeDuelBridgeDeaths { get; set; }

        [JsonProperty("bridge_duel_bridge_kills")]
        public int BridgeDuelBridgeKills { get; set; }

        [JsonProperty("bridge_duel_melee_hits")]
        public int BridgeDuelMeleeHits { get; set; }

        [JsonProperty("bridge_duel_blocks_placed")]
        public int BridgeDuelBlocksPlaced { get; set; }

        [JsonProperty("bridge_duel_bow_shots")]
        public int BridgeDuelBowShots { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_duel")]
        public int BestWinstreakModeBridgeDuel { get; set; }

        [JsonProperty("duels_winstreak_best_bridge_duel")]
        public int DuelsWinstreakBestBridgeDuel { get; set; }

        [JsonProperty("bridge_iron_title_prestige")]
        public int BridgeIronTitlePrestige { get; set; }

        [JsonProperty("bridge_doubles_losses")]
        public int BridgeDoublesLosses { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_2v2v2v2")]
        public int BestWinstreakModeBridge2V2V2V2 { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_2v2v2v2")]
        public int CurrentWinstreakModeBridge2V2V2V2 { get; set; }

        [JsonProperty("bridge_2v2v2v2_goals")]
        public int Bridge2V2V2V2Goals { get; set; }

        [JsonProperty("bridge_2v2v2v2_health_regenerated")]
        public int Bridge2V2V2V2HealthRegenerated { get; set; }

        [JsonProperty("bridge_2v2v2v2_blocks_placed")]
        public int Bridge2V2V2V2BlocksPlaced { get; set; }

        [JsonProperty("bridge_2v2v2v2_rounds_played")]
        public int Bridge2V2V2V2RoundsPlayed { get; set; }

        [JsonProperty("bridge_2v2v2v2_melee_swings")]
        public int Bridge2V2V2V2MeleeSwings { get; set; }

        [JsonProperty("bridge_2v2v2v2_bridge_deaths")]
        public int Bridge2V2V2V2BridgeDeaths { get; set; }

        [JsonProperty("bridge_2v2v2v2_wins")]
        public int Bridge2V2V2V2Wins { get; set; }

        [JsonProperty("bridge_2v2v2v2_melee_hits")]
        public int Bridge2V2V2V2MeleeHits { get; set; }

        [JsonProperty("bridge_2v2v2v2_bridge_kills")]
        public int Bridge2V2V2V2BridgeKills { get; set; }

        [JsonProperty("bridge_2v2v2v2_damage_dealt")]
        public int Bridge2V2V2V2DamageDealt { get; set; }

        [JsonProperty("duels_winstreak_best_bridge_2v2v2v2")]
        public int DuelsWinstreakBestBridge2V2V2V2 { get; set; }

        [JsonProperty("bridge_2v2v2v2_losses")]
        public int Bridge2V2V2V2Losses { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_3v3v3v3")]
        public int CurrentWinstreakModeBridge3V3V3V3 { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_3v3v3v3")]
        public int BestWinstreakModeBridge3V3V3V3 { get; set; }

        [JsonProperty("bridge_3v3v3v3_blocks_placed")]
        public int Bridge3V3V3V3BlocksPlaced { get; set; }

        [JsonProperty("bridge_3v3v3v3_goals")]
        public int Bridge3V3V3V3Goals { get; set; }

        [JsonProperty("bridge_3v3v3v3_rounds_played")]
        public int Bridge3V3V3V3RoundsPlayed { get; set; }

        [JsonProperty("bridge_3v3v3v3_health_regenerated")]
        public int Bridge3V3V3V3HealthRegenerated { get; set; }

        [JsonProperty("bridge_3v3v3v3_wins")]
        public int Bridge3V3V3V3Wins { get; set; }

        [JsonProperty("duels_winstreak_best_bridge_3v3v3v3")]
        public int DuelsWinstreakBestBridge3V3V3V3 { get; set; }

        [JsonProperty("bridge_3v3v3v3_melee_hits")]
        public int Bridge3V3V3V3MeleeHits { get; set; }

        [JsonProperty("bridge_3v3v3v3_melee_swings")]
        public int Bridge3V3V3V3MeleeSwings { get; set; }

        [JsonProperty("bridge_3v3v3v3_bridge_deaths")]
        public int Bridge3V3V3V3BridgeDeaths { get; set; }

        [JsonProperty("bridge_3v3v3v3_bridge_kills")]
        public int Bridge3V3V3V3BridgeKills { get; set; }

        [JsonProperty("bridge_3v3v3v3_damage_dealt")]
        public int Bridge3V3V3V3DamageDealt { get; set; }

        [JsonProperty("bridge_3v3v3v3_losses")]
        public int Bridge3V3V3V3Losses { get; set; }

        [JsonProperty("bridge_3v3v3v3_bow_shots")]
        public int Bridge3V3V3V3BowShots { get; set; }

        [JsonProperty("bridge_gold_title_prestige")]
        public int BridgeGoldTitlePrestige { get; set; }

        [JsonProperty("bridge_2v2v2v2_bow_shots")]
        public int Bridge2V2V2V2BowShots { get; set; }

        [JsonProperty("bridge_2v2v2v2_bow_hits")]
        public int Bridge2V2V2V2BowHits { get; set; }

        [JsonProperty("bridge_3v3v3v3_bow_hits")]
        public int Bridge3V3V3V3BowHits { get; set; }
        #endregion

        #region op duels
        [JsonProperty("op_duel_health_regenerated")]
        public int OpDuelHealthRegenerated { get; set; }

        [JsonProperty("op_duel_damage_dealt")]
        public int OpDuelDamageDealt { get; set; }

        [JsonProperty("op_duel_rounds_played")]
        public int OpDuelRoundsPlayed { get; set; }

        [JsonProperty("op_duel_melee_swings")]
        public int OpDuelMeleeSwings { get; set; }

        [JsonProperty("op_duel_melee_hits")]
        public int OpDuelMeleeHits { get; set; }
        #endregion
    }
}