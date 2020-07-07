using System.Collections.Generic;
using Hypixel.NET.Booster;
using Newtonsoft.Json;

namespace Hypixel.NET.BoosterApi
{
    public class BoostersRequest : IBoostersRequest
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("boosters")]
        public List<IBooster> Boosters { get; private set; }
    }
}