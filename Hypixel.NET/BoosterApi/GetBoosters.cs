using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.BoosterApi
{
    public class GetBoosters
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("boosters")]
        public List<Booster.Booster> Boosters { get; set; }
    }
}