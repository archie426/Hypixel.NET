using System;
using System.Collections.Generic;
using Hypixel.NET.GuildApi.Guild.Achievements;
using Hypixel.NET.GuildApi.Guild.Member;
using Hypixel.NET.GuildApi.Guild.XpByGameType;
using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi.Guild
{
    public interface IGuild
    {
        public string Id { get;  }


        public string Name { get;  }


        public long Coins { get; }


        public long CoinsEver { get;  }

        
        public DateTime GuildCreatedDate { get; }
        
        public List<IMember> Members { get; }
        
        public string Tag { get;  }
        
        public string TagColor { get;  }
        
        public IAchievements Achievements { get;  }
        
        public long LegacyRanking { get;  }
        
        public long Exp { get; }
        
        public string NameLower { get; }
        
        public IGuildGameExp GuildGameExp { get; }
    }
}