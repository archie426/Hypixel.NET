using System;
using Newtonsoft.Json;

namespace Hypixel.NET.KeyApi.Record
{
    public class Record
    {
        [JsonProperty("ownerUuid")]
        public string OwnerUuid { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("totalQueries")]
        public int TotalQueries { get; set; }
    }
}