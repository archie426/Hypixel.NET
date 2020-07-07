namespace Hypixel.NET.PlayerApi.Player.GameCounts
{
    public interface IGameCountsRequest : IRequest
    {
        public Games.Games Games { get; set; }
        
        public string Cause { get; }
        
        public long HypixelPlayerCount { get; }
    }
}