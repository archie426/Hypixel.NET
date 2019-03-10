using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.GiftingMeta
{
    public class GiftingMeta
    {
        [JsonProperty("giftsGiven")]
        public long GiftsGiven { get; set; }

        [JsonProperty("bundlesGiven")]
        public long BundlesGiven { get; set; }

        [JsonProperty("realBundlesGiven")]
        public long RealBundlesGiven { get; set; }

        [JsonProperty("milestones")]
        public List<string> Milestones { get; set; }

        [JsonProperty("realBundlesReceived")]
        public long RealBundlesReceived { get; set; }

        [JsonProperty("bundlesReceived")]
        public long BundlesReceived { get; set; }
    }
}
