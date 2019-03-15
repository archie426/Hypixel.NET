using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class MurderMystery
    {
        #region general
        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("knife_kills")]
        public int KnifeKills { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("coins_pickedup")]
        public int CoinsPickedup { get; set; }

        [JsonProperty("detective_chance")]
        public int DetectiveChance { get; set; }

        [JsonProperty("murderer_chance")]
        public int MurdererChance { get; set; }

        [JsonProperty("bow_kills")]
        public int BowKills { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("wasSpecialRoleLastGame")]
        public bool WasSpecialRoleLastGame { get; set; }

        [JsonProperty("kills_as_murderer")]
        public int KillsAsMurderer { get; set; }

        [JsonProperty("detective_wins")]
        public int DetectiveWins { get; set; }

        [JsonProperty("murderer_wins")]
        public int MurdererWins { get; set; }

        [JsonProperty("active_knife_skin")]
        public string ActiveKnifeSkin { get; set; }

        [JsonProperty("suicides")]
        public int Suicides { get; set; }
        #endregion

        #region chests
        [JsonProperty("granted_chests")]
        public int GrantedChests { get; set; }

        [JsonProperty("mm_chests")]
        public int MmChests { get; set; }

        [JsonProperty("mm_christmas_chests")]
        public int MmChristmasChests { get; set; }

        [JsonProperty("MurderMystery_openedCommons")]
        public int MurderMysteryOpenedCommons { get; set; }

        [JsonProperty("chest_history_new")]
        public List<string> ChestHistoryNew { get; set; }

        [JsonProperty("MurderMystery_openedChests")]
        public int MurderMysteryOpenedChests { get; set; }

        [JsonProperty("MurderMystery_openedRares")]
        public int MurderMysteryOpenedRares { get; set; }

        [JsonProperty("MurderMystery_openedEpics")]
        public int MurderMysteryOpenedEpics { get; set; }
        #endregion

        #region classic
        [JsonProperty("coins_pickedup_MURDER_CLASSIC")]
        public int CoinsPickedupMurderClassic { get; set; }

        [JsonProperty("games_MURDER_CLASSIC")]
        public int GamesMurderClassic { get; set; }

        [JsonProperty("wins_MURDER_CLASSIC")]
        public int WinsMurderClassic { get; set; }

        [JsonProperty("deaths_MURDER_CLASSIC")]
        public int DeathsMurderClassic { get; set; }

        [JsonProperty("detective_wins_MURDER_CLASSIC")]
        public int DetectiveWinsMurderClassic { get; set; }

        [JsonProperty("murderer_wins_MURDER_CLASSIC")]
        public int MurdererWinsMurderClassic { get; set; }

        [JsonProperty("knife_kills_MURDER_CLASSIC")]
        public int KnifeKillsMurderClassic { get; set; }

        [JsonProperty("suicides_MURDER_CLASSIC")]
        public int SuicidesMurderClassic { get; set; }
        #endregion

        #region assassins
        [JsonProperty("games_MURDER_ASSASSINS")]
        public int GamesMurderAssassins { get; set; }

        [JsonProperty("deaths_MURDER_ASSASSINS")]
        public int DeathsMurderAssassins { get; set; }

        [JsonProperty("coins_pickedup_MURDER_ASSASSINS")]
        public int CoinsPickedupMurderAssassins { get; set; }

        [JsonProperty("knife_kills_MURDER_ASSASSINS")]
        public int KnifeKillsMurderAssassins { get; set; }

        [JsonProperty("kills_MURDER_ASSASSINS")]
        public int KillsMurderAssassins { get; set; }

        #endregion

        #region infection
        [JsonProperty("games_MURDER_INFECTION")]
        public int GamesMurderInfection { get; set; }

        [JsonProperty("kills_as_survivor")]
        public int KillsAsSurvivor { get; set; }

        [JsonProperty("kills_as_infected")]
        public int KillsAsInfected { get; set; }

        [JsonProperty("survivor_wins")]
        public int SurvivorWins { get; set; }
        #endregion
    }
}