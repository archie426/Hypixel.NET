using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar.ProductInfo
{
    public class WeekHistoric
    {
        [JsonProperty("productId")]
        public string ProductId { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }

        [JsonProperty("nowBuyVolume")]
        public long NowBuyVolume { get; private set; }

        [JsonProperty("nowSellVolume")]
        public long NowSellVolume { get; private set; }

        [JsonProperty("buyCoins")]
        public double BuyCoins { get; private set; }

        [JsonProperty("buyVolume")]
        public long BuyVolume { get; private set; }

        [JsonProperty("buys")]
        public long Buys { get; private set; }

        [JsonProperty("sellCoins")]
        public double SellCoins { get; private set; }

        [JsonProperty("sellVolume")]
        public long SellVolume { get; private set; }

        [JsonProperty("sells")]
        public long Sells { get; private set; }
    }
}
