using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar.ProductInfo
{
    public class Summary
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("pricePerUnit")]
        public double PricePerUnit { get; set; }

        [JsonProperty("orders")]
        public long Orders { get; set; }
    }
}
