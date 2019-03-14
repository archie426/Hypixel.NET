using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Achievements
{
    public class Achievements
    {
        [JsonProperty("arena_bossed")]
        public int ArenaBossed { get; set; }

        [JsonProperty("arena_climb_the_ranks")]
        public int ArenaClimbTheRanks { get; set; }

        [JsonProperty("arena_gladiator")]
        public int ArenaGladiator { get; set; }

        [JsonProperty("arena_gotta_wear_em_all")]
        public int ArenaGottaWearEmAll { get; set; }

        [JsonProperty("blitz_coins")]
        public int BlitzCoins { get; set; }

        [JsonProperty("blitz_kills")]
        public int BlitzKills { get; set; }

        [JsonProperty("general_coins")]
        public int GeneralCoins { get; set; }

        [JsonProperty("general_wins")]
        public int GeneralWins { get; set; }

        [JsonProperty("quake_killing_sprees")]
        public int QuakeKillingSprees { get; set; }

        [JsonProperty("quake_kills")]
        public int QuakeKills { get; set; }

        [JsonProperty("quake_wins")]
        public int QuakeWins { get; set; }

        [JsonProperty("tntgames_bow_spleef_wins")]
        public int TntgamesBowSpleefWins { get; set; }

        [JsonProperty("tntgames_tnt_run_wins")]
        public int TntgamesTntRunWins { get; set; }

        [JsonProperty("tntgames_wizards_wins")]
        public int TntgamesWizardsWins { get; set; }

        [JsonProperty("vampirez_coins")]
        public int VampirezCoins { get; set; }

        [JsonProperty("vampirez_kill_survivors")]
        public int VampirezKillSurvivors { get; set; }

        [JsonProperty("vampirez_kill_vampires")]
        public int VampirezKillVampires { get; set; }

        [JsonProperty("vampirez_survivor_wins")]
        public int VampirezSurvivorWins { get; set; }

        [JsonProperty("walls3_coins")]
        public int Walls3Coins { get; set; }

        [JsonProperty("walls3_kills")]
        public int Walls3Kills { get; set; }

        [JsonProperty("walls3_wins")]
        public int Walls3Wins { get; set; }

        [JsonProperty("walls_coins")]
        public int WallsCoins { get; set; }

        [JsonProperty("walls_kills")]
        public int WallsKills { get; set; }

        [JsonProperty("walls_wins")]
        public int WallsWins { get; set; }

        [JsonProperty("uhc_champion")]
        public int UhcChampion { get; set; }

        [JsonProperty("uhc_hunter")]
        public int UhcHunter { get; set; }

        [JsonProperty("uhc_moving_up")]
        public int UhcMovingUp { get; set; }

        [JsonProperty("paintball_kills")]
        public int PaintballKills { get; set; }

        [JsonProperty("paintball_coins")]
        public int PaintballCoins { get; set; }

        [JsonProperty("skywars_kills_team")]
        public int SkywarsKillsTeam { get; set; }

        [JsonProperty("skywars_kills_solo")]
        public int SkywarsKillsSolo { get; set; }

        [JsonProperty("skywars_wins_solo")]
        public int SkywarsWinsSolo { get; set; }

        [JsonProperty("skywars_kits_solo")]
        public int SkywarsKitsSolo { get; set; }

        [JsonProperty("skywars_wins_team")]
        public int SkywarsWinsTeam { get; set; }

        [JsonProperty("skywars_cages")]
        public int SkywarsCages { get; set; }

        [JsonProperty("skywars_kits_team")]
        public int SkywarsKitsTeam { get; set; }

        [JsonProperty("truecombat_kit_hoarder_solo")]
        public int TruecombatKitHoarderSolo { get; set; }

        [JsonProperty("truecombat_kit_hoarder_team")]
        public int TruecombatKitHoarderTeam { get; set; }

        [JsonProperty("walls3_guardian")]
        public int Walls3Guardian { get; set; }

        [JsonProperty("skywars_kills_mega")]
        public int SkywarsKillsMega { get; set; }

        [JsonProperty("skywars_kits_mega")]
        public int SkywarsKitsMega { get; set; }

        [JsonProperty("skywars_wins_mega")]
        public int SkywarsWinsMega { get; set; }

        [JsonProperty("warlords_warrior_level")]
        public int WarlordsWarriorLevel { get; set; }

        [JsonProperty("warlords_shaman_level")]
        public int WarlordsShamanLevel { get; set; }

        [JsonProperty("warlords_mage_level")]
        public int WarlordsMageLevel { get; set; }

        [JsonProperty("warlords_paladin_level")]
        public int WarlordsPaladinLevel { get; set; }

        [JsonProperty("copsandcrims_bomb_specialist")]
        public int CopsandCrimsBombSpecialist { get; set; }

        [JsonProperty("general_challenger")]
        public int GeneralChallenger { get; set; }

        [JsonProperty("general_quest_master")]
        public int GeneralQuestMaster { get; set; }

        [JsonProperty("speeduhc_hunter")]
        public int SpeeduhcHunter { get; set; }

        [JsonProperty("skyclash_cards_unlocked")]
        public int SkyclashCardsUnlocked { get; set; }

        [JsonProperty("skyclash_kills")]
        public int SkyclashKills { get; set; }

        [JsonProperty("skyclash_packs_opened")]
        public int SkyclashPacksOpened { get; set; }

        [JsonProperty("truecombat_solo_killer")]
        public int TruecombatSoloKiller { get; set; }

        [JsonProperty("skyclash_wins")]
        public int SkyclashWins { get; set; }

        [JsonProperty("paintball_wins")]
        public int PaintballWins { get; set; }

        [JsonProperty("truecombat_team_killer")]
        public int TruecombatTeamKiller { get; set; }

        [JsonProperty("arcade_miniwalls_winner")]
        public int ArcadeMiniwallsWinner { get; set; }

        [JsonProperty("arcade_team_work")]
        public int ArcadeTeamWork { get; set; }

        [JsonProperty("arcade_arcade_winner")]
        public int ArcadeArcadeWinner { get; set; }

        [JsonProperty("arcade_arcade_banker")]
        public int ArcadeArcadeBanker { get; set; }

        [JsonProperty("skyclash_treasure_hunter")]
        public int SkyclashTreasureHunter { get; set; }

        [JsonProperty("skyclash_mob_beheading")]
        public int SkyclashMobBeheading { get; set; }

        [JsonProperty("tntgames_tnt_tag_wins")]
        public int TntgamesTntTagWins { get; set; }

        [JsonProperty("tntgames_pvp_run_killer")]
        public int TntgamesPvpRunKiller { get; set; }

        [JsonProperty("tntgames_pvp_run_wins")]
        public int TntgamesPvpRunWins { get; set; }

        [JsonProperty("tntgames_tnt_wizards_kills")]
        public int TntgamesTntWizardsKills { get; set; }

        [JsonProperty("tntgames_tnt_triathlon")]
        public int TntgamesTntTriathlon { get; set; }

        [JsonProperty("tntgames_tnt_banker")]
        public int TntgamesTntBanker { get; set; }

        [JsonProperty("uhc_bounty")]
        public int UhcBounty { get; set; }

        [JsonProperty("gingerbread_banker")]
        public int GingerbreadBanker { get; set; }

        [JsonProperty("vampirez_zombie_killer")]
        public int VampirezZombieKiller { get; set; }

        [JsonProperty("quake_coins")]
        public int QuakeCoins { get; set; }

        [JsonProperty("quake_headshots")]
        public int QuakeHeadshots { get; set; }

        [JsonProperty("tntgames_tnt_wizards_caps")]
        public int TntgamesTntWizardsCaps { get; set; }

        [JsonProperty("truecombat_team_winner")]
        public int TruecombatTeamWinner { get; set; }

        [JsonProperty("blitz_wins_teams")]
        public int BlitzWinsTeams { get; set; }

        [JsonProperty("blitz_war_veteran")]
        public int BlitzWarVeteran { get; set; }

        [JsonProperty("blitz_wins")]
        public int BlitzWins { get; set; }

        [JsonProperty("blitz_looter")]
        public int BlitzLooter { get; set; }

        [JsonProperty("blitz_treasure_seeker")]
        public int BlitzTreasureSeeker { get; set; }

        [JsonProperty("bedwars_wins")]
        public int BedwarsWins { get; set; }

        [JsonProperty("bedwars_beds")]
        public int BedwarsBeds { get; set; }

        [JsonProperty("bedwars_level")]
        public int BedwarsLevel { get; set; }

        [JsonProperty("bedwars_loot_box")]
        public int BedwarsLootBox { get; set; }

        [JsonProperty("gingerbread_racer")]
        public int GingerbreadRacer { get; set; }

        [JsonProperty("gingerbread_winner")]
        public int GingerbreadWinner { get; set; }

        [JsonProperty("murdermystery_wins_as_survivor")]
        public int MurdermysteryWinsAsSurvivor { get; set; }

        [JsonProperty("arcade_football_pro")]
        public int ArcadeFootballPro { get; set; }

        [JsonProperty("truecombat_king")]
        public int TruecombatKing { get; set; }

        [JsonProperty("murdermystery_kills_as_murderer")]
        public int MurdermysteryKillsAsMurderer { get; set; }

        [JsonProperty("arcade_bounty_hunter")]
        public int ArcadeBountyHunter { get; set; }

        [JsonProperty("copsandcrims_serial_killer")]
        public int CopsandCrimsSerialKiller { get; set; }

        [JsonProperty("copsandcrims_hero_terrorist")]
        public int CopsandcrimsHeroTerrorist { get; set; }

        [JsonProperty("buildbattle_build_battle_points")]
        public int BuildbattleBuildBattlePoints { get; set; }

        [JsonProperty("buildbattle_build_battle_voter")]
        public int BuildbattleBuildBattleVoter { get; set; }

        [JsonProperty("buildbattle_build_battle_score")]
        public int BuildbattleBuildBattleScore { get; set; }

        [JsonProperty("buildbattle_guess_the_build_guesses")]
        public int BuildbattleGuessTheBuildGuesses { get; set; }

        [JsonProperty("buildbattle_guess_the_build_winner")]
        public int BuildbattleGuessTheBuildWinner { get; set; }

        [JsonProperty("duels_duels_winner")]
        public int DuelsDuelsWinner { get; set; }

        [JsonProperty("duels_duels_win_streak")]
        public int DuelsDuelsWinStreak { get; set; }

        [JsonProperty("murdermystery_wins_as_murderer")]
        public int MurdermysteryWinsAsMurderer { get; set; }

        [JsonProperty("skywars_wins_lab")]
        public int SkywarsWinsLab { get; set; }

        [JsonProperty("arcade_farmhunt_dominator")]
        public int ArcadeFarmhuntDominator { get; set; }

        [JsonProperty("bedwars_bedwars_killer")]
        public int BedwarsBedwarsKiller { get; set; }

        [JsonProperty("bedwars_collectors_edition")]
        public int BedwarsCollectorsEdition { get; set; }

        [JsonProperty("truecombat_feels_lucky")]
        public int TruecombatFeelsLucky { get; set; }

        [JsonProperty("truecombat_solo_winner")]
        public int TruecombatSoloWinner { get; set; }

        [JsonProperty("tntgames_clinic")]
        public int TntgamesClinic { get; set; }

        [JsonProperty("murdermystery_hoarder")]
        public int MurdermysteryHoarder { get; set; }

        [JsonProperty("duels_duels_traveller")]
        public int DuelsDuelsTraveller { get; set; }

        [JsonProperty("paintball_kill_streaks")]
        public int PaintballKillStreaks { get; set; }

        [JsonProperty("gingerbread_mystery")]
        public int GingerbreadMystery { get; set; }

        [JsonProperty("skywars_heads")]
        public int SkywarsHeads { get; set; }

        [JsonProperty("copsandcrims_cac_banker")]
        public int CopsandcrimsCacBanker { get; set; }

        [JsonProperty("warlords_ctf_objective")]
        public int WarlordsCtfObjective { get; set; }

        [JsonProperty("warlords_assist")]
        public int WarlordsAssist { get; set; }

        [JsonProperty("warlords_coins")]
        public int WarlordsCoins { get; set; }

        [JsonProperty("warlords_kills")]
        public int WarlordsKills { get; set; }

        [JsonProperty("warlords_ctf_wins")]
        public int WarlordsCtfWins { get; set; }
    }
}