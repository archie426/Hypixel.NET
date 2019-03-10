using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Legacy
    {
        [JsonProperty("next_tokens_seconds")]
        public long NextTokensSeconds { get; set; }

        [JsonProperty("total_tokens")]
        public long TotalTokens { get; set; }

        [JsonProperty("vampirez_tokens")]
        public long VampirezTokens { get; set; }

        [JsonProperty("tokens")]
        public long Tokens { get; set; }

        [JsonProperty("paintball_tokens")]
        public long PaintballTokens { get; set; }

        [JsonProperty("gingerbread_tokens")]
        public long GingerbreadTokens { get; set; }

        [JsonProperty("quakecraft_tokens")]
        public long QuakecraftTokens { get; set; }

        [JsonProperty("walls_tokens")]
        public long WallsTokens { get; set; }
    }
}