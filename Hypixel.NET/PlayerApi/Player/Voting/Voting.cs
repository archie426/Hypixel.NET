using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Voting
{
    public class Voting
    {
        [JsonProperty("total")]
        public int TotalVotes { get; set; }

        [JsonProperty("total_mcsorg")]
        public int TotalMcsorg { get; set; }

        [JsonProperty("secondary_mcsorg")]
        public int SecondaryMcsorg { get; set; }

        [JsonProperty("votesToday")]
        public int VotesToday { get; set; }

        [JsonProperty("secondary_mcsl")]
        public int SecondaryMcsl { get; set; }

        [JsonProperty("total_mcsl")]
        public int TotalMcsl { get; set; }

        [JsonProperty("total_mcf")]
        public int TotalMcf { get; set; }

        [JsonProperty("secondary_mcf")]
        public int SecondaryMcf { get; set; }

        [JsonProperty("total_mcmp")]
        public int TotalMcmp { get; set; }

        [JsonProperty("secondary_mcmp")]
        public int SecondaryMcmp { get; set; }

        [JsonProperty("total_topg")]
        public int TotalTopg { get; set; }

        [JsonProperty("secondary_topg")]
        public int SecondaryTopg { get; set; }

    }
}