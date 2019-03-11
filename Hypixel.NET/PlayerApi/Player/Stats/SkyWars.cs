using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SkyWars
    {
        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("activeKit_TEAM")]
        public string ActiveKitTeam { get; set; }

        [JsonProperty("soul_well")]
        public int SoulWellUses { get; set; }

        [JsonProperty("usedSoulWell")]
        public bool UsedSoulWell { get; set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; set; }

        [JsonProperty("survived_players")]
        public int SurvivedPlayers { get; set; }

        [JsonProperty("arrows_hit")]
        public int ArrowsHit { get; set; }

        [JsonProperty("blocks_broken")]
        public int BlocksBroken { get; set; }

        [JsonProperty("blocks_placed")]
        public int BlocksPlaced { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("survived_players_team")]
        public int SurvivedPlayersTeam { get; set; }

        [JsonProperty("losses_team_insane")]
        public int GameLossesTeamInsane { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("deaths_team")]
        public int DeathsTeam { get; set; }

        [JsonProperty("arrows_shot")]
        public int ArrowsShot { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("kills_team")]
        public int KillsTeam { get; set; }

        [JsonProperty("deaths_team_insane")]
        public int DeathsTeamInsane { get; set; }

        [JsonProperty("kills_team_insane")]
        public int KillsTeamInsane { get; set; }

        [JsonProperty("souls_gathered")]
        public int SoulsGathered { get; set; }

        [JsonProperty("items_enchanted")]
        public int ItemsEnchanted { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("quits")]
        public int Quits { get; set; }

        [JsonProperty("losses_team")]
        public int LossesTeam { get; set; }

        [JsonProperty("souls")]
        public int CurrentSouls { get; set; }

        [JsonProperty("egg_thrown")]
        public int EggsThrown { get; set; }

        [JsonProperty("losses_team_normal")]
        public int LossesTeamNormal { get; set; }

        [JsonProperty("deaths_team_normal")]
        public int DeathsTeamNormal { get; set; }

        [JsonProperty("kills_team_normal")]
        public int KillsTeamNormal { get; set; }

        [JsonProperty("games_team")]
        public int GamesTeam { get; set; }

        [JsonProperty("assists_team")]
        public int AssistsTeam { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("activeKit_MEGA")]
        public string MegaActiveKit { get; set; }

        [JsonProperty("games_mega")]
        public int GamesMega { get; set; }

        [JsonProperty("enderpearls_thrown")]
        public int EnderpearlsThrown { get; set; }

        [JsonProperty("kills_mega")]
        public int KillsMega { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("survived_players_mega")]
        public int SurvivedPlayersMega { get; set; }

        [JsonProperty("wins_mega_normal")]
        public int WinsMegaNormal { get; set; }

        [JsonProperty("wins_mega")]
        public int WinsMega { get; set; }

        [JsonProperty("kills_mega_normal")]
        public int KillsMegaNormal { get; set; }

        [JsonProperty("assists_mega")]
        public int AssistsMega { get; set; }

        [JsonProperty("paid_souls")]
        public int BoughtSouls { get; set; }

        [JsonProperty("losses_mega_normal")]
        public int LossesMegaNormal { get; set; }

        [JsonProperty("deaths_mega_normal")]
        public int DeathsMegaNormal { get; set; }

        [JsonProperty("losses_mega")]
        public int LossesMega { get; set; }

        [JsonProperty("deaths_mega")]
        public int DeathsMega { get; set; }

        [JsonProperty("refill_chest_destroy")]
        public int TotalDestroyedChests { get; set; }

        [JsonProperty("public string activeKit_SOLO")]
        public string SoloActiveKit { get; set; }

        [JsonProperty("survived_players_solo")]
        public int SurvivedPlayersSolo { get; set; }

        [JsonProperty("losses_solo_normal")]
        public int LossesSoloNormal { get; set; }

        [JsonProperty("deaths_solo")]
        public int DeathsSolo { get; set; }

        [JsonProperty("deaths_solo_normal")]
        public int DeathsSoloNormal { get; set; }

        [JsonProperty("losses_solo")]
        public int LossesSolo { get; set; }

        [JsonProperty("wins_team_normal")]
        public int WinsTeamNormal { get; set; }

        [JsonProperty("wins_team")]
        public int WinsTeam { get; set; }

        [JsonProperty("soul_well_rares")]
        public int SoulWellRaresWon { get; set; }

        [JsonProperty("public string activeCage")]
        public string ActiveCage { get; set; }

        [JsonProperty("games_solo")]
        public int GamesSolo { get; set; }

        [JsonProperty("kills_solo_normal")]
        public int KillsSoloNormal { get; set; }

        [JsonProperty("wins_solo_normal")]
        public int WinsSoloNormal { get; set; }

        [JsonProperty("wins_solo")]
        public int WinsSolo { get; set; }

        [JsonProperty("kills_solo")]
        public int KillsSolo { get; set; }

        [JsonProperty("soul_well_legendaries")]
        public int SoulWellLegendaryWon { get; set; }

        [JsonProperty("losses_solo_insane")]
        public int LossesSoloInsane { get; set; }

        [JsonProperty("deaths_solo_insane")]
        public int DeathsSoloInsane { get; set; }

        [JsonProperty("assists_solo")]
        public int SoloAssists { get; set; }

        [JsonProperty("wins_team_insane")]
        public int WinsTeamInsane { get; set; }

        [JsonProperty("wins_solo_insane")]
        public int WinsSoloInsane { get; set; }

        [JsonProperty("kills_solo_insane")]
        public int KillsSoloInsane { get; set; }

        [JsonProperty("winstreak_ranked")]
        public int WinstreakRanked { get; set; }

        [JsonProperty("killstreak")]
        public int KillStreak { get; set; }

        [JsonProperty("games_ranked")]
        public int GamesRanked { get; set; }

        [JsonProperty("wins_ranked_normal")]
        public int WinsRankedNormal { get; set; }

        [JsonProperty("killstreak_ranked")]
        public int KillstreakRanked { get; set; }

        [JsonProperty("kills_ranked_normal")]
        public int KillsRankedNormal { get; set; }

        [JsonProperty("survived_players_ranked")]
        public int SurvivedPlayersRanked { get; set; }

        [JsonProperty("kills_ranked")]
        public int KillsRanked { get; set; }

        [JsonProperty("wins_ranked")]
        public int WinsRanked { get; set; }

        [JsonProperty("highestKillstreak")]
        public int HighestKillstreak { get; set; }

        [JsonProperty("highestWinstreak")]
        public int HighestWinStreak { get; set; }

        [JsonProperty("killstreak_team")]
        public int KillStreakTeam { get; set; }

        [JsonProperty("winstreak_team")]
        public int WinStreakTeam { get; set; }

        [JsonProperty("killstreak_solo")]
        public int KillStreakSolo { get; set; }

        [JsonProperty("winstreak_solo")]
        public int WinStreakSolo { get; set; }

        [JsonProperty("losses_ranked")]
        public int LossesRanked { get; set; }

        [JsonProperty("deaths_ranked_normal")]
        public int DeathsRankedNormal { get; set; }

        [JsonProperty("losses_ranked_normal")]
        public int LossesRankedNormal { get; set; }

        [JsonProperty("deaths_ranked")]
        public int DeathsRanked { get; set; }

        [JsonProperty("assists_ranked")]
        public int AssistsRanked { get; set; }

        [JsonProperty("fastest_win")]
        public int FastestWin { get; set; }

        [JsonProperty("fastest_win_team")]
        public int FastestWinTeam { get; set; }

        [JsonProperty("melee_kills_team")]
        public int MeleeKillsTeam { get; set; }

        [JsonProperty("void_kills")]
        public int VoidKills { get; set; }

        [JsonProperty("chests_opened_team")]
        public int ChestsOpenedTeam { get; set; }

        [JsonProperty("time_played")]
        public int TimePlayed { get; set; }

        [JsonProperty("most_kills_game")]
        public int MostKillsGame { get; set; }

        [JsonProperty("arrows_shot_team")]
        public int ArrowsShotTeam { get; set; }

        [JsonProperty("chests_opened")]
        public int ChestsOpened { get; set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; set; }

        [JsonProperty("arrows_hit_team")]
        public int ArrowsHitTeam { get; set; }

        [JsonProperty("most_kills_game_team")]
        public int MostKillsGameTeam { get; set; }

        [JsonProperty("time_played_team")]
        public int TimePlayedTeam { get; set; }

        [JsonProperty("void_kills_team")]
        public int VoidKillsTeam { get; set; }

        [JsonProperty("chests_opened_mega")]
        public int ChestsOpenedMega { get; set; }

        [JsonProperty("most_kills_game_mega")]
        public int MostKillsGameMega { get; set; }

        [JsonProperty("void_kills_mega")]
        public int VoidKillsMega { get; set; }

        [JsonProperty("time_played_mega")]
        public int TimePlayedMega { get; set; }

        [JsonProperty("melee_kills_mega")]
        public int MeleeKillsMega { get; set; }

        [JsonProperty("arrows_shot_mega")]
        public int ArrowsShotMega { get; set; }

        [JsonProperty("arrows_hit_mega")]
        public int ArrowsHitMega { get; set; }

        [JsonProperty("fastest_win_mega")]
        public int FastestWinMega { get; set; }

        [JsonProperty("fastest_win_solo")]
        public int FastestWinSolo { get; set; }

        [JsonProperty("melee_kills_solo")]
        public int MeleeKillsSolo { get; set; }

        [JsonProperty("arrows_hit_solo")]
        public int ArrowsHitSolo { get; set; }

        [JsonProperty("most_kills_game_solo")]
        public int MostKillsGameSolo { get; set; }

        [JsonProperty("chests_opened_solo")]
        public int ChestsOpenedSolo { get; set; }

        [JsonProperty("time_played_solo")]
        public int TimePlayedSolo { get; set; }

        [JsonProperty("arrows_shot_solo")]
        public int ArrowsShotSolo { get; set; }

        [JsonProperty("void_kills_solo")]
        public int VoidKillsSolo { get; set; }

        [JsonProperty("mob_kills")]
        public int MobKills { get; set; }

        [JsonProperty("mob_kills_solo")]
        public int MobKillsSolo { get; set; }

        [JsonProperty("mob_kills_team")]
        public int MobKillsTeam { get; set; }

        [JsonProperty("chests_opened_ranked")]
        public int ChestsOpenedRanked { get; set; }

        [JsonProperty("time_played_ranked")]
        public int TimePlayedRanked { get; set; }

        [JsonProperty("fastest_win_ranked")]
        public int FastestWinRanked { get; set; }

        [JsonProperty("void_kills_ranked")]
        public int VoidKillsRanked { get; set; }

        [JsonProperty("most_kills_game_ranked")]
        public int MostKillsGameRanked { get; set; }

        [JsonProperty("melee_kills_ranked")]
        public int MeleeKillsRanked { get; set; }

        [JsonProperty("arrows_hit_ranked")]
        public int ArrowsHitRanked { get; set; }

        [JsonProperty("arrows_shot_ranked")]
        public int ArrowsShotRanked { get; set; }

        [JsonProperty("mob_kills_mega")]
        public int MobKillsMega { get; set; }

        [JsonProperty("games_played_skywars")]
        public int TotalSkywarsGamesPlayed { get; set; }

        [JsonProperty("survived_players_lab_solo")]
        public int SurvivedPlayersLabSolo { get; set; }

        [JsonProperty("wins_lab")]
        public int WinsLab { get; set; }

        [JsonProperty("killstreak_lab")]
        public int KillStreakLab { get; set; }

        [JsonProperty("void_kills_lab")]
        public int VoidKillsLab { get; set; }

        [JsonProperty("souls_gathered_lab")]
        public int SoulsGatheredLab { get; set; }

        [JsonProperty("games_lab")]
        public int GamesLab { get; set; }

        [JsonProperty("survived_players_lab")]
        public int SurvivedPlayersLab { get; set; }

        [JsonProperty("coins_gained_lab")]
        public int CoinsGainedLab { get; set; }

        [JsonProperty("kills_lab")]
        public int KillsLab { get; set; }

        [JsonProperty("winstreak_lab")]
        public int WinstreakLab { get; set; }

        [JsonProperty("games_lab_solo")]
        public int GamesLabSolo { get; set; }

        [JsonProperty("egg_thrown_lab")]
        public int EggsThrownLab { get; set; }

        [JsonProperty("melee_kills_lab_solo")]
        public int MeleeKillsLabSolo { get; set; }

        [JsonProperty("blocks_placed_lab")]
        public int BlocksPlacedLab { get; set; }

        [JsonProperty("kills_lab_solo")]
        public int KillsLabSolo { get; set; }

        [JsonProperty("chests_opened_lab_solo")]
        public int ChestsOpenedLabSolo { get; set; }

        [JsonProperty("winstreak_lab_solo")]
        public int WinstreakLabSolo { get; set; }

        [JsonProperty("time_played_lab_solo")]
        public int TimePlayedLabSolo { get; set; }

        [JsonProperty("time_played_lab")]
        public int TimePlayedLab { get; set; }

        [JsonProperty("killstreak_lab_solo")]
        public int KillstreakLabSolo { get; set; }

        [JsonProperty("chests_opened_lab")]
        public int ChestsOpenedLab { get; set; }

        [JsonProperty("wins_lab_solo")]
        public int WinsLabSolo { get; set; }

        [JsonProperty("void_kills_lab_solo")]
        public int VoidKillsLabSolo { get; set; }

        [JsonProperty("melee_kills_lab")]
        public int MeleeKillsLab { get; set; }

        [JsonProperty("souls_lab")]
        public int SoulsLab { get; set; }

        [JsonProperty("win_streak_lab")]
        public int WinStreakLab { get; set; }

        [JsonProperty("deaths_lab")]
        public int DeathsLab { get; set; }

        [JsonProperty("deaths_lab_solo")]
        public int DeathsLabSolo { get; set; }

        [JsonProperty("losses_lab_solo")]
        public int LossesLabSolo { get; set; }

        [JsonProperty("losses_lab")]
        public int LossesLab { get; set; }

        [JsonProperty("quits_lab")]
        public int QuitsLab { get; set; }

        [JsonProperty("blocks_broken_lab")]
        public int BlocksBrokenLab { get; set; }

        [JsonProperty("arrows_shot_lab_solo")]
        public int ArrowsShotLabSolo { get; set; }

        [JsonProperty("arrows_shot_lab")]
        public int ArrowsShotLab { get; set; }

        [JsonProperty("survived_players_lab_team")]
        public int SurvivedPlayersLabTeam { get; set; }

        [JsonProperty("losses_lab_team")]
        public int LossesLabTeam { get; set; }

        [JsonProperty("melee_kills_lab_team")]
        public int MeleeKillsLabTeam { get; set; }

        [JsonProperty("kills_lab_team")]
        public int KillsLabTeam { get; set; }

        [JsonProperty("deaths_lab_team")]
        public int DeathsLabTeam { get; set; }

        [JsonProperty("chests_opened_lab_team")]
        public int ChestsOpenedLabTeam { get; set; }

        [JsonProperty("time_played_lab_team")]
        public int TimePlayedLabTeam { get; set; }

        [JsonProperty("enderpearls_thrown_lab")]
        public int EnderpearlsThrownLab { get; set; }

        [JsonProperty("void_kills_lab_team")]
        public int VoidKillsLabTeam { get; set; }

        [JsonProperty("games_lab_team")]
        public int GamesLabTeam { get; set; }

        [JsonProperty("fastest_win_lab_team")]
        public int FastestWinLabTeam { get; set; }

        [JsonProperty("fastest_win_lab")]
        public int FastestWinLab { get; set; }

        [JsonProperty("winstreak_lab_team")]
        public int WinstreakLabTeam { get; set; }

        [JsonProperty("killstreak_lab_team")]
        public int KillstreakLabTeam { get; set; }

        [JsonProperty("wins_lab_team")]
        public int WinsLabTeam { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab")]
        public int LabWinTntMadnessLab { get; set; }

        [JsonProperty("lab_win_slime_lab")]
        public int LabWinSlimeLab { get; set; }

        [JsonProperty("lab_win_slime_lab_solo")]
        public int LabWinSlimeLabSolo { get; set; }

        [JsonProperty("arrows_hit_lab")]
        public int ArrowsHitLab { get; set; }

        [JsonProperty("arrows_hit_lab_solo")]
        public int ArrowsHitLabSolo { get; set; }

        [JsonProperty("assists_lab")]
        public int AssistsLab { get; set; }

        [JsonProperty("assists_lab_solo")]
        public int AssistsLabSolo { get; set; }

        [JsonProperty("arrows_shot_lab_team")]
        public int ArrowsShotLabTeam { get; set; }

        [JsonProperty("lab_win_slime_lab_team")]
        public int LabWinSlimeLabTeam { get; set; }

        [JsonProperty("assists_lab_team")]
        public int AssistsLabTeam { get; set; }

        [JsonProperty("arrows_hit_lab_team")]
        public int ArrowsHitLabTeam { get; set; }

        [JsonProperty("mob_kills_lab_team")]
        public int MobKillsLabTeam { get; set; }

        [JsonProperty("mob_kills_lab")]
        public int MobKillsLab { get; set; }

        [JsonProperty("lab_win_tnt_madness_lab_solo")]
        public int LabWinTntMadnessLabSolo { get; set; }

        [JsonProperty("longest_bow_shot_lab")]
        public int LongestBowShotLab { get; set; }

        [JsonProperty("longest_bow_shot_lab_team")]
        public int LongestBowShotLabTeam { get; set; }

        [JsonProperty("lab_win_rush_lab_team")]
        public int LabWinRushLabTeam { get; set; }

        [JsonProperty("lab_win_rush_lab")]
        public int LabWinRushLab { get; set; }

        [JsonProperty("lab_win_rush_lab_solo")]
        public int LabWinRushLabSolo { get; set; }

        [JsonProperty("mob_kills_lab_solo")]
        public int MobKillsLabSolo { get; set; }

        [JsonProperty("longest_bow_kill")]
        public int LongestBowKill { get; set; }

        [JsonProperty("longest_bow_kill_solo")]
        public int LongestBowKillSolo { get; set; }

        [JsonProperty("longest_bow_kill_team")]
        public int LongestBowKillTeam { get; set; }

        [JsonProperty("longest_bow_kill_ranked")]
        public int LongestBowKillRanked { get; set; }

        [JsonProperty("longest_bow_kill_mega")]
        public int LongestBowKillMega { get; set; }

        [JsonProperty("skywars_chests")]
        public int SkywarsChests { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_team")]
        public int LabWinLuckyBlocksLabTeam { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab")]
        public int LabWinLuckyBlocksLab { get; set; }

        [JsonProperty("SkyWars_openedCommons")]
        public int SkywarsChestsOpenedCommons { get; set; }

        [JsonProperty("skywars_chest_history")]
        public List<string> SkywarsChestHistory { get; set; }

        [JsonProperty("SkyWars_openedChests")]
        public int SkyWarsOpenedChests { get; set; }

        [JsonProperty("SkyWars_openedRares")]
        public int SkywarsChestsOpenedRares { get; set; }

        [JsonProperty("lab_win_lucky_blocks_lab_solo")]
        public int LabWinLuckyBlocksLabSolo { get; set; }

        [JsonProperty("refill_chest_destroy_lab")]
        public int RefillChestsDestroyedLab { get; set; }

        [JsonProperty("cosmetic_tokens")]
        public int CosmeticTokens { get; set; }

        [JsonProperty("public string active_victorydance")]
        public string ActiveVictorydance { get; set; }

        [JsonProperty("bow_kills_team")]
        public int BowKillsTeam { get; set; }

        [JsonProperty("bow_kills")]
        public int BowKills { get; set; }

        [JsonProperty("bow_kills_solo")]
        public int BowKillsSolo { get; set; }

        [JsonProperty("skywars_easter_boxes")]
        public int SkywarsEasterBoxes { get; set; }

        [JsonProperty("longest_bow_kill_lab_solo")]
        public int LongestBowKillLabSolo { get; set; }

        [JsonProperty("longest_bow_kill_lab")]
        public int LongestBowKillLab { get; set; }

        [JsonProperty("bow_kills_lab")]
        public int BowKillsLab { get; set; }

        [JsonProperty("bow_kills_lab_solo")]
        public int BowKillsLabSolo { get; set; }

        [JsonProperty("bow_kills_lab_team")]
        public int BowKillsLabTeam { get; set; }

        [JsonProperty("beast_chance")]
        public int BeastChance { get; set; }

        [JsonProperty("fastest_win_lab_solo")]
        public int FastestWinLabSolo { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_solo")]
        public int LabWinHuntersVsBeastsLabSolo { get; set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab")]
        public int LabWinHuntersVsBeastsLab { get; set; }

        [JsonProperty("activeKit_MEGA_DOUBLES_random")]
        public bool ActiveKitMegaDoublesRandom { get; set; }

        [JsonProperty("public string activeKit_MEGA_DOUBLES")]
        public string ActiveKitMegaDoubles { get; set; }

        [JsonProperty("time_played_mega_doubles")]
        public int TimePlayedMegaDoubles { get; set; }

        [JsonProperty("losses_mega_doubles_normal")]
        public int LossesMegaDoublesNormal { get; set; }

        [JsonProperty("kills_mega_doubles_normal")]
        public int KillsMegaDoublesNormal { get; set; }

        [JsonProperty("deaths_mega_doubles_normal")]
        public int DeathsMegaDoublesNormal { get; set; }

        [JsonProperty("survived_players_mega_doubles")]
        public int SurvivedPlayersMegaDoubles { get; set; }

        [JsonProperty("losses_mega_doubles")]
        public int LossesMegaDoubles { get; set; }

        [JsonProperty("melee_kills_mega_doubles")]
        public int MeleeKillsMegaDoubles { get; set; }

        [JsonProperty("kills_mega_doubles")]
        public int KillsMegaDoubles { get; set; }

        [JsonProperty("deaths_mega_doubles")]
        public int DeathsMegaDoubles { get; set; }

        [JsonProperty("chests_opened_mega_doubles")]
        public int ChestsOpenedMegaDoubles { get; set; }

        [JsonProperty("games_mega_doubles")]
        public int GamesMegaDoubles { get; set; }

        [JsonProperty("public bool activeKit_SOLO_random")]
        public bool ActiveKitSoloRandom { get; set; }

        [JsonProperty("lab_hvb_hunter_wins_lab")]
        public int LabHvbHunterWinsLab { get; set; }

        [JsonProperty("public bool activeKit_TEAMS_random")]
        public bool ActiveKitTeamsRandom { get; set; }

        [JsonProperty("arrows_shot_mega_doubles")]
        public int ArrowsShotMegaDoubles { get; set; }

        [JsonProperty("arrows_hit_mega_doubles")]
        public int ArrowsHitMegaDoubles { get; set; }

        [JsonProperty("void_kills_mega_doubles")]
        public int VoidKillsMegaDoubles { get; set; }

        [JsonProperty("lab_hvb_beast_wins_lab")]
        public int LabHvbBeastWinsLab { get; set; }

        [JsonProperty("lab_hvb_beast_enraged_wins_lab")]
        public int LabHvbBeastEnragedWinsLab { get; set; }

        [JsonProperty("lab_hvb_beast_enrages_lab")]
        public int LabHvbBeastEnragesLab { get; set; }

        [JsonProperty("assists_mega_doubles")]
        public int AssistsMegaDoubles { get; set; }

        [JsonProperty("skywars_experience")]
        public int SkywarsExperience { get; set; }

        [JsonProperty("most_kills_game_lab_solo")]
        public int MostKillsGameLabSolo { get; set; }

        [JsonProperty("most_kills_game_lab")]
        public int MostKillsGameLab { get; set; }

        [JsonProperty("selected_prestige_icon")]
        public string SelectedPrestigeIcon { get; set; }

        [JsonProperty("challenge_wins_uhc")]
        public int ChallengeWinsUhc { get; set; }

        [JsonProperty("challenge_attempts_uhc_solo")]
        public int ChallengeAttemptsUhcSolo { get; set; }

        [JsonProperty("challenge_wins_uhc_solo")]
        public int ChallengeWinsUhcSolo { get; set; }

        [JsonProperty("challenge_attempts_uhc")]
        public int ChallengeAttemptsUhc { get; set; }

        [JsonProperty("challenge_wins")]
        public int ChallengeWins { get; set; }

        [JsonProperty("challenge_attempts_solo")]
        public int ChallengeAttemptsSolo { get; set; }

        [JsonProperty("challenge_wins_solo")]
        public int ChallengeWinsSolo { get; set; }

        [JsonProperty("challenge_attempts")]
        public int ChallengeAttempts { get; set; }

        [JsonProperty("challenge_attempts_no_chest")]
        public int ChallengeAttemptsNoChest { get; set; }

        [JsonProperty("challenge_attempts_no_chest_solo")]
        public int ChallengeAttemptsNoChestSolo { get; set; }

        [JsonProperty("heads")]
        public int TotalHeads { get; set; }

        [JsonProperty("heads_solo")]
        public int HeadsSolo { get; set; }

        [JsonProperty("heads_succulent_solo")]
        public int HeadsSucculentSolo { get; set; }

        [JsonProperty("heads_succulent")]
        public int HeadsSucculent { get; set; }

        [JsonProperty("longest_bow_shot_lab_solo")]
        public int LongestBowShotLabSolo { get; set; }

        [JsonProperty("challenge_attempts_archer_solo")]
        public int ChallengeAttemptsArcherSolo { get; set; }

        [JsonProperty("challenge_attempts_archer")]
        public int ChallengeAttemptsArcher { get; set; }

        [JsonProperty("challenge_attempts_paper")]
        public int ChallengeAttemptsPaper { get; set; }

        [JsonProperty("challenge_attempts_paper_solo")]
        public int ChallengeAttemptsPaperSolo { get; set; }

        [JsonProperty("challenge_wins_paper_solo")]
        public int ChallengeWinsPaperSolo { get; set; }

        [JsonProperty("challenge_wins_paper")]
        public int ChallengeWinsPaper { get; set; }

        [JsonProperty("challenge_attempts_rookie_solo")]
        public int ChallengeAttemptsRookieSolo { get; set; }

        [JsonProperty("challenge_attempts_rookie")]
        public int ChallengeAttemptsRookie { get; set; }

        [JsonProperty("heads_eww")]
        public int HeadsEww { get; set; }

        [JsonProperty("heads_eww_solo")]
        public int HeadsEwwSolo { get; set; }

        [JsonProperty("public HeadCollection head_collection")]
        public HeadCollection HeadCollection { get; set; }

        [JsonProperty("angel_of_death_level")]
        public int AngelOfDeathLevel { get; set; }

        [JsonProperty("heads_decent")]
        public int HeadsDecent { get; set; }

        [JsonProperty("heads_team")]
        public int HeadsTeam { get; set; }

        [JsonProperty("heads_decent_team")]
        public int HeadsDecentTeam { get; set; }

        [JsonProperty("heads_divine")]
        public int HeadsDivine { get; set; }

        [JsonProperty("heads_divine_team")]
        public int HeadsDivineTeam { get; set; }

        [JsonProperty("challenge_wins_archer")]
        public int ChallengeWinsArcher { get; set; }

        [JsonProperty("challenge_wins_archer_solo")]
        public int ChallengeWinsArcherSolo { get; set; }

        [JsonProperty("challenge_attempts_half_health")]
        public int ChallengeAttemptsHalfHealth { get; set; }

        [JsonProperty("challenge_attempts_half_health_solo")]
        public int ChallengeAttemptsHalfHealthSolo { get; set; }

        [JsonProperty("challenge_attempts_no_block_solo")]
        public int ChallengeAttemptsNoBlockSolo { get; set; }

        [JsonProperty("challenge_attempts_no_block")]
        public int ChallengeAttemptsNoBlock { get; set; }

        [JsonProperty("heads_tasty_solo")]
        public int HeadsTastySolo { get; set; }

        [JsonProperty("heads_tasty")]
        public int HeadsTasty { get; set; }

        [JsonProperty("heads_decent_solo")]
        public int HeadsDecentSolo { get; set; }

        [JsonProperty("heads_salty")]
        public int HeadsSalty { get; set; }

        [JsonProperty("heads_meh")]
        public int HeadsMeh { get; set; }

        [JsonProperty("heads_meh_solo")]
        public int HeadsMehSolo { get; set; }

        [JsonProperty("heads_salty_solo")]
        public int HeadsSaltySolo { get; set; }

        [JsonProperty("heads_divine_solo")]
        public int HeadsDivineSolo { get; set; }

        [JsonProperty("heads_tasty_team")]
        public int HeadsTastyTeam { get; set; }

        [JsonProperty("heads_meh_team")]
        public int HeadsMehTeam { get; set; }

        [JsonProperty("heads_yucky_solo")]
        public int HeadsYuckySolo { get; set; }

        [JsonProperty("heads_yucky")]
        public int HeadsYucky { get; set; }

        [JsonProperty("heads_salty_team")]
        public int HeadsSaltyTeam { get; set; }
    }
}