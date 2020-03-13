using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar.ProductInfo
{
    public class QuickStatus
    {
        [JsonProperty("productId")]
        public string ProductId { get; private set; }

        [JsonProperty("buyPrice")]
        public double BuyPrice { get; private set; }

        [JsonProperty("buyVolume")]
        public long BuyVolume { get; private set; }

        [JsonProperty("buyMovingWeek")]
        public long BuyMovingWeek { get; private set; }

        [JsonProperty("buyOrders")]
        public long BuyOrders { get; private set; }

        [JsonProperty("sellPrice")]
        public double SellPrice { get; private set; }

        [JsonProperty("sellVolume")]
        public long SellVolume { get; private set; }

        [JsonProperty("sellMovingWeek")]
        public long SellMovingWeek { get; private set; }

        [JsonProperty("sellOrders")]
        public long SellOrders { get; private set; }
    }
}
