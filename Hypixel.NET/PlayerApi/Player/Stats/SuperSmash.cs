using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.Stats.SmashHeros;
using Hypixel.NET.PlayerApi.Player.Stats.SmashHeros.Heros;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SuperSmash
    {
        [JsonProperty("lastLevel_THE_BULK")]
        public int LastLevelTheBulk { get; set; }

        [JsonProperty("active_class")]
        public string ActiveClass { get; set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; set; }

        [JsonProperty("class_stats")]
        public ClassStats ClassStats { get; set; }

        [JsonProperty("smasher")]
        public int Smasher { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("smasher_normal")]
        public int SmasherNormal { get; set; }

        [JsonProperty("losses_normal")]
        public int LossesNormal { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("damage_dealt")]
        public int DamageDealt { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("smashed_normal")]
        public int SmashedNormal { get; set; }

        [JsonProperty("deaths_normal")]
        public int DeathsNormal { get; set; }

        [JsonProperty("games_normal")]
        public int GamesNormal { get; set; }

        [JsonProperty("smashed")]
        public int Smashed { get; set; }

        [JsonProperty("kills_normal")]
        public int KillsNormal { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("damage_dealt_normal")]
        public int DamageDealtNormal { get; set; }

        [JsonProperty("xp_THE_BULK")]
        public int XpTheBulk { get; set; }

        [JsonProperty("smash_level_total")]
        public int SmashLevelTotal { get; set; }

        [JsonProperty("smashLevel")]
        public int SmashLevel { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("wins_normal")]
        public int WinsNormal { get; set; }

        [JsonProperty("FRIENDS_gamesDay")]
        public int FriendsGamesDay { get; set; }

        [JsonProperty("friend_losses")]
        public int FriendLosses { get; set; }

        [JsonProperty("friend_wins")]
        public int FriendWins { get; set; }

        [JsonProperty("friend_wins_normal")]
        public int FriendWinsNormal { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("assists_normal")]
        public int AssistsNormal { get; set; }

        [JsonProperty("quits")]
        public int Quits { get; set; }

        [JsonProperty("friend_losses_normal")]
        public int FriendLossesNormal { get; set; }

        [JsonProperty("xp_CAKE_MONSTER")]
        public int XpCakeMonster { get; set; }

        [JsonProperty("lastLevel_CAKE_MONSTER")]
        public int LastLevelCakeMonster { get; set; }

        [JsonProperty("deaths_2v2")]
        public int Deaths2V2 { get; set; }

        [JsonProperty("wins_2v2")]
        public int Wins2V2 { get; set; }

        [JsonProperty("kills_2v2")]
        public int Kills2V2 { get; set; }

        [JsonProperty("games_2v2")]
        public int Games2V2 { get; set; }

        [JsonProperty("damage_dealt_2v2")]
        public int DamageDealt2V2 { get; set; }

        [JsonProperty("xp_GENERAL_CLUCK")]
        public int XpGeneralCluck { get; set; }

        [JsonProperty("lastLevel_GENERAL_CLUCK")]
        public int LastLevelGeneralCluck { get; set; }

        [JsonProperty("smashed_2v2")]
        public int Smashed2V2 { get; set; }

        [JsonProperty("smasher_2v2")]
        public int Smasher2V2 { get; set; }

        [JsonProperty("losses_2v2")]
        public int Losses2V2 { get; set; }

        [JsonProperty("xp_BOTMUN")]
        public int XpBotmun { get; set; }

        [JsonProperty("lastLevel_BOTMUN")]
        public int LastLevelBotmun { get; set; }

        [JsonProperty("damage_dealt_teams")]
        public int DamageDealtTeams { get; set; }

        [JsonProperty("wins_teams")]
        public int WinsTeams { get; set; }

        [JsonProperty("smashed_teams")]
        public int SmashedTeams { get; set; }

        [JsonProperty("kills_teams")]
        public int KillsTeams { get; set; }

        [JsonProperty("smasher_teams")]
        public int SmasherTeams { get; set; }

        [JsonProperty("deaths_teams")]
        public int DeathsTeams { get; set; }

        [JsonProperty("games_teams")]
        public int GamesTeams { get; set; }

        [JsonProperty("losses_teams")]
        public int LossesTeams { get; set; }

        [JsonProperty("xp_FROSTY")]
        public int XpFrosty { get; set; }

        [JsonProperty("lastLevel_FROSTY")]
        public int LastLevelFrosty { get; set; }

        [JsonProperty("xp_TINMAN")]
        public int XpTinman { get; set; }

        [JsonProperty("lastLevel_TINMAN")]
        public int LastLevelTinman { get; set; }

        [JsonProperty("lastLevel_MARAUDER")]
        public int LastLevelMarauder { get; set; }

        [JsonProperty("xp_MARAUDER")]
        public int XpMarauder { get; set; }

        [JsonProperty("xp_GOKU")]
        public int XpGoku { get; set; }

        [JsonProperty("lastLevel_GOKU")]
        public int LastLevelGoku { get; set; }

        [JsonProperty("xp_SPODERMAN")]
        public int XpSpoderman { get; set; }

        [JsonProperty("lastLevel_SPODERMAN")]
        public int LastLevelSpoderman { get; set; }

        [JsonProperty("xp_PUG")]
        public int XpPug { get; set; }

        [JsonProperty("lastLevel_PUG")]
        public int LastLevelPug { get; set; }

        [JsonProperty("pg_FROSTY")]
        public int PgFrosty { get; set; }

        [JsonProperty("votes_Gunmetal")]
        public int VotesGunmetal { get; set; }

        [JsonProperty("xp_SKULLFIRE")]
        public int XpSkullfire { get; set; }

        [JsonProperty("lastLevel_SKULLFIRE")]
        public int LastLevelSkullfire { get; set; }

        [JsonProperty("votes_Equinox")]
        public int VotesEquinox { get; set; }

        [JsonProperty("pg_THE_BULK")]
        public int PgTheBulk { get; set; }

        [JsonProperty("masterArmor_FROSTY")]
        public bool MasterArmorFrosty { get; set; }

        [JsonProperty("xp_SHOOP_DA_WHOOP")]
        public int XpShoopDaWhoop { get; set; }

        [JsonProperty("lastLevel_SHOOP_DA_WHOOP")]
        public int LastLevelShoopDaWhoop { get; set; }

        [JsonProperty("pg_TINMAN")]
        public int PgTinman { get; set; }

        [JsonProperty("pg_SHOOP_DA_WHOOP")]
        public int PgShoopDaWhoop { get; set; }

        [JsonProperty("pg_BOTMUN")]
        public int PgBotmun { get; set; }

        [JsonProperty("masterArmor_THE_BULK")]
        public bool MasterArmorTheBulk { get; set; }

        [JsonProperty("xp_DUSK_CRAWLER")]
        public int XpDuskCrawler { get; set; }

        [JsonProperty("lastLevel_DUSK_CRAWLER")]
        public int LastLevelDuskCrawler { get; set; }

        [JsonProperty("pg_DUSK_CRAWLER")]
        public int PgDuskCrawler { get; set; }

        [JsonProperty("pg_PUG")]
        public int PgPug { get; set; }

        [JsonProperty("votes_Dojo")]
        public int VotesDojo { get; set; }

        [JsonProperty("pg_CAKE_MONSTER")]
        public int PgCakeMonster { get; set; }

        [JsonProperty("masterArmor_TINMAN")]
        public bool MasterArmorTinman { get; set; }

        [JsonProperty("pg_SKULLFIRE")]
        public int PgSkullfire { get; set; }

        [JsonProperty("masterArmor_BOTMUN")]
        public bool MasterArmorBotmun { get; set; }

        [JsonProperty("pg_GENERAL_CLUCK")]
        public int PgGeneralCluck { get; set; }

        [JsonProperty("pg_SPODERMAN")]
        public int PgSpoderman { get; set; }

        [JsonProperty("lastLevel_SERGEANT_SHIELD")]
        public int LastLevelSergeantShield { get; set; }

        [JsonProperty("xp_SERGEANT_SHIELD")]
        public int XpSergeantShield { get; set; }

        [JsonProperty("xp_SANIC")]
        public int XpSanic { get; set; }

        [JsonProperty("lastLevel_SANIC")]
        public int LastLevelSanic { get; set; }

        [JsonProperty("xp_GREEN_HOOD")]
        public int XpGreenHood { get; set; }

        [JsonProperty("lastLevel_GREEN_HOOD")]
        public int LastLevelGreenHood { get; set; }

        [JsonProperty("pg_SERGEANT_SHIELD")]
        public int PgSergeantShield { get; set; }

        [JsonProperty("packages")]
        public List<object> Packages { get; set; }

        [JsonProperty("masterArmor_SERGEANT_SHIELD")]
        public bool MasterArmorSergeantShield { get; set; }

        [JsonProperty("pg_GOKU")]
        public int PgGoku { get; set; }

        [JsonProperty("masterArmor_GENERAL_CLUCK")]
        public bool MasterArmorGeneralCluck { get; set; }

        [JsonProperty("pg_MARAUDER")]
        public int PgMarauder { get; set; }

        [JsonProperty("pg_SANIC")]
        public int PgSanic { get; set; }

        [JsonProperty("pg_GREEN_HOOD")]
        public int PgGreenHood { get; set; }

        [JsonProperty("masterArmor_PUG")]
        public bool MasterArmorPug { get; set; }

        [JsonProperty("masterArmor_CAKE_MONSTER")]
        public bool MasterArmorCakeMonster { get; set; }

        [JsonProperty("masterArmor_GOKU")]
        public bool MasterArmorGoku { get; set; }

        [JsonProperty("masterArmor_SHOOP_DA_WHOOP")]
        public bool MasterArmorShoopDaWhoop { get; set; }

        [JsonProperty("masterArmor_SANIC")]
        public bool MasterArmorSanic { get; set; }

        [JsonProperty("masterArmor_SKULLFIRE")]
        public bool MasterArmorSkullfire { get; set; }

        [JsonProperty("masterArmor_GREEN_HOOD")]
        public bool MasterArmorGreenHood { get; set; }

        [JsonProperty("masterArmor_DUSK_CRAWLER")]
        public bool MasterArmorDuskCrawler { get; set; }

        [JsonProperty("masterArmor_MARAUDER")]
        public bool MasterArmorMarauder { get; set; }

        [JsonProperty("masterArmor_SPODERMAN")]
        public bool MasterArmorSpoderman { get; set; }

        [JsonProperty("ONE_V_JUAN_gamesDay")]
        public int OneVJuanGamesDay { get; set; }

        [JsonProperty("one_v_one_losses_normal")]
        public int OneVOneLossesNormal { get; set; }

        [JsonProperty("one_v_one_losses")]
        public int OneVOneLosses { get; set; }

        [JsonProperty("one_v_one_wins_normal")]
        public int OneVOneWinsNormal { get; set; }

        [JsonProperty("one_v_one_wins")]
        public int OneVOneWins { get; set; }
    }
}