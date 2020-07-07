namespace Hypixel.NET.GuildApi
{
    public interface IGuildRequest
    {
        public bool WasSuccessful { get; }
        
        public Guild.Guild Guild { get; }
        
        public string Cause { get; }
    }
}