using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar
{
    public class GetBazaarProductPrice
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("product_info")]
        public ProductInfo.ProductInfo ProductInfo { get; private set; }
    }
}
