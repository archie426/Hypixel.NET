using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar.ProductInfo
{
    public class ProductInfo
    {
        [JsonProperty("product_id")]
        public string ProductId { get; private set; }

        [JsonProperty("buy_summary")]
        public List<Summary> BuySummary { get; private set; }

        [JsonProperty("sell_summary")]
        public List<Summary> SellSummary { get; private set; }

        [JsonProperty("quick_status")]
        public QuickStatus QuickStatus { get; private set; }

        [JsonProperty("week_historic")]
        public List<WeekHistoric> WeekHistoric { get; private set; }
    }
}
