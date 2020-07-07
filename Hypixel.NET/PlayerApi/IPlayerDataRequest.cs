namespace Hypixel.NET.PlayerApi
{
    public interface IPlayerDataRequest : IRequest
    {
        public IPlayer Player { get; }
        
        public string Cause { get; }

        public bool FromCache { get; set; }
    }
}