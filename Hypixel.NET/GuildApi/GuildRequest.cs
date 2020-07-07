using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi
{
    public class GuildRequest : IGuildRequest
    {
        public bool FromCache;

        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("guild")]
        public Guild.Guild Guild { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }
    }
}