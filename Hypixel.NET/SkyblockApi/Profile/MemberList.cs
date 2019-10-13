using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Hypixel.NET.SkyblockApi.Profile.Objectives;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class MemberList
    {
        [JsonProperty("last_save")]
        private readonly long _lastSave;
        public DateTime LastSave
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_lastSave).ToLocalTime();
                return convertToDateTime;
            }
        }


        [JsonProperty("inv_armor")]
        public InvArmour InvArmour { get; private set; }

        [JsonProperty("first_join")]
        private readonly long _firstLogin;
        public DateTime FirstLogin
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_firstLogin).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("first_join_hub")]
        private readonly long _firstLoginHub;
        public DateTime FirstLoginHub
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_firstLoginHub).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("stats")]
        public Stats PlayerStats { get; private set; }

        [JsonProperty("objectives")]
        public Objectives.Objectives Objectives { get; private set; }

        [JsonProperty("tutorial")]
        public List<string> Tutorial { get; private set; }

        [JsonProperty("quests")]
        public Quests Quests { get; private set; }

        [JsonProperty("coin_purse")]
        public long CoinPurse { get; private set; }

        [JsonProperty("last_death")]
        public long LastDeath { get; private set; }

        [JsonProperty("visited_zones")]
        public List<string> VisitedZones { get; private set; }

        [JsonProperty("fairy_souls_collected")]
        public long FairySoulsCollected { get; private set; }

        [JsonProperty("fairy_souls")]
        public long FairySouls { get; private set; }

        [JsonProperty("fairy_exchanges")]
        public long FairyExchanges { get; private set; }

        [JsonProperty("fishing_treasure_caught")]
        public long FishingTreasureCaught { get; private set; }

        [JsonProperty("death_count")]
        public long DeathCount { get; private set; }

        [JsonProperty("achievement_spawned_island_types")]
        public List<string> AchivementSpawnedIslandTypes { get; private set; }
    }
}
