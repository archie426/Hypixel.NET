using System.Collections.Generic;
using Hypixel.NET.FriendsApi.Record;
using Newtonsoft.Json;

namespace Hypixel.NET.FriendsApi
{
    public class GetFriendsUuid
    {
        public bool FromCache { get; set; }

        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("records")]
        public List<Records> Records { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }
    }
}