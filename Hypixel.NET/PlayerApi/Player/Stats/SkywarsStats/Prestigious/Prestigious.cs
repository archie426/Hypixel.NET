using System;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SkywarsStats.Prestigious
{
    public class Prestigious
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("sacrifice")]
        public string Sacrifice { get; set; }
    }
}