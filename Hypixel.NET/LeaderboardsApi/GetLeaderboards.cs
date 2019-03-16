using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi
{
    public class GetLeaderboards
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("leaderboards")]
        public Leaderboard.Leaderboard Leaderboards { get; set; }
    }
}