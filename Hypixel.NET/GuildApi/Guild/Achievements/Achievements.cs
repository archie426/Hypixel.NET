using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi.Guild.Achievements
{
    public class Achievements
    {
        [JsonProperty("WINNERS")]
        public int Winners { get; set; }

        [JsonProperty("EXPERIENCE_KINGS")]
        public int ExperienceKings { get; set; }

        [JsonProperty("ONLINE_PLAYERS")]
        public int OnlinePlayers { get; set; }
    }
}