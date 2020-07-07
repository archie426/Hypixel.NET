using System;

namespace Hypixel.NET.GuildApi.Guild.Member
{
    public interface IMember
    {
        public string Uuid { get; }
        
        public string Rank { get; }
        
        public DateTime Joined { get; }
    }
}