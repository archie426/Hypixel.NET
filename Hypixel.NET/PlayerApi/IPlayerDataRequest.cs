namespace Hypixel.NET.PlayerApi
{
    public interface IPlayerDataRequest
    {
        public IPlayer Player { get; }
        
        public bool WasSuccessful { get; }


        public string Cause { get; }

        public bool FromCache { get; set; }
    }
}