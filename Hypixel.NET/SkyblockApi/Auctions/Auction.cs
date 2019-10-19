using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Auctions
{
    public class Auction
    {
        [JsonProperty("_id")]
        public string Id { get; private set; }

        [JsonProperty("uuid")]
        public string Uuid { get; private set; }

        [JsonProperty("auctioneer")]
        public string Auctioneer { get; private set; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; private set; }

        [JsonProperty("coop")]
        public List<string> Coop { get; private set; }

        [JsonProperty("start")]
        public long Start { get; private set; }

        [JsonProperty("end")]
        public long End { get; private set; }

        [JsonProperty("item_name")]
        public string ItemName { get; private set; }

        [JsonProperty("item_lore")]
        public string ItemLore { get; private set; }

        [JsonProperty("extra")]
        public string Extra { get; private set; }

        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("tier")]
        public string Tier { get; private set; }

        [JsonProperty("starting_bid")]
        public long StartingBid { get; private set; }

        [JsonProperty("item_bytes")]
        public ItemBytes ItemBytes { get; private set; }

        [JsonProperty("claimed")]
        public bool Claimed { get; private set; }

        [JsonProperty("claimed_bidders")]
        public List<string> ClaimedBidders { get; private set; }

        [JsonProperty("highest_bid_amount")]
        public long HighestBidAmount { get; private set; }

        [JsonProperty("bids")]
        public List<Bid> Bids { get; private set; }
    }
}
