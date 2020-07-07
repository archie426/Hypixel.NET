namespace Hypixel.NET.PlayerApi.Player.GameCounts
{
    public interface IGameCountsRequest
    {
        public Games.Games Games { get; set; }
        
        public string Cause { get; }
        
        public bool WasSuccessful { get; }
        
        public long HypixelPlayerCount { get; }
    }
}