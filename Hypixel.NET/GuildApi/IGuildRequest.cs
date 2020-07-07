using Hypixel.NET.GuildApi.Guild;

namespace Hypixel.NET.GuildApi
{
    public interface IGuildRequest : IRequest
    {
        public IGuild Guild { get; }
        
        public string Cause { get; }
    }
}