using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar
{
    public class GetBazaarProducts
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("productIds")]
        public List<string> ProductIds { get; private set; }
    }
}
