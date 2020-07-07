using System.Collections.Generic;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public interface ILeaderboardData
    {

        public string Prefix { get;  }
        
        public long Count { get; }
        
        public List<string> Leaders { get; }
        
        public string Title { get; }
    }
}