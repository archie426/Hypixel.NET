using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SkywarsStats
{
    public class HeadCollection
    {
        [JsonProperty("recent")]
        public List<Prestigious.Prestigious> Recent { get; set; }

        [JsonProperty("prestigious")]
        public List<Prestigious.Prestigious> Prestigious { get; set; }
    }
}