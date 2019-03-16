using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi
{
    public class GetGuild
    {
        public bool FromCache;

        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("guild")]
        public Guild.Guild Guild { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }
    }
}