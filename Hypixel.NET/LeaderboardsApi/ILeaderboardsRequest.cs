namespace Hypixel.NET.LeaderboardsApi
{
    public interface ILeaderboardsRequest : IRequest
    {
        public string Cause { get; }
        
        public Leaderboard.Leaderboard Leaderboards { get; }
    }
}