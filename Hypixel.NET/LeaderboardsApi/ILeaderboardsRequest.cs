namespace Hypixel.NET.LeaderboardsApi
{
    public interface ILeaderboardsRequest
    {
        public bool WasSuccessful { get;}
        public string Cause { get; }
        
        public Leaderboard.Leaderboard Leaderboards { get; }
    }
}