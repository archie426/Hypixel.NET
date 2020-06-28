using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class WardrobeContents
    {
        [JsonProperty("type")]
        public long Type { get; private set; }

        [JsonProperty("data")]
        public string Data { get; private set; }
    }
}
