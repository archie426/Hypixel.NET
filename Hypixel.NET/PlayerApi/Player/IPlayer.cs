using System;
using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.GiftingMeta;
using Hypixel.NET.PlayerApi.Player.Settings;
using Hypixel.NET.PlayerApi.Player.Stats;
using Hypixel.NET.PlayerApi.Player.VanityMeta;
using Hypixel.NET.PlayerApi.Player.Voting;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi
{
    public interface IPlayer
    {
        public List<object> AchievementsOneTime { get; set; }
        public string DisplayName { get; set; }


        public DateTime FirstLogin { get; }

        
        public DateTime LastLogin { get; }
            

        public List<string> KnownAliases { get; }


        public long NetworkExp { get; }


        public Settings Settings { get; }


        public Stats Stats { get; }
        
        public long TimePlaying { get; }
        
        public string Uuid { get; }


        public long Karma { get; }


        public long VanityTokens { get; }
        
        public VanityMeta VanityMeta { get; }


        public int TotalRewards { get; }


        public int TotalDailyRewards { get; }


        public int RewardStreak { get; }


        public int RewardScore { get; }


        public int RewardHighScore { get; }


        public string CurrentPet { get; }


        public GiftingMeta GiftingMeta { get; }
        
        public DateTime LastLogout { get; }


        public string RankPlusColor { get; }


        public Voting Voting { get;}


        public string NewPackageRank { get; }


        public string MonthlyPackageRank { get; }
        
        public string MostRecentMonthlyPackageRank { get; }
    }
}