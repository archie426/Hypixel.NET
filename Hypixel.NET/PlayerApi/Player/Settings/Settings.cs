using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Settings
{
    public class Settings
    {
        [JsonProperty("bloodVisibility")]
        public bool BloodVisibility { get; set; }

        [JsonProperty("partyInvitePrivacy")]
        public string PartyInvitePrivacy { get; set; }

        [JsonProperty("profanityLevel_PM")]
        public string ProfanityLevelPm { get; set; }

        [JsonProperty("profanityLevel_GUILD")]
        public string ProfanityLevelGuild { get; set; }

        [JsonProperty("profanityLevel_PARTY")]
        public string ProfanityLevelParty { get; set; }

        [JsonProperty("profanityLevel")]
        public string ProfanityLevel { get; set; }

        [JsonProperty("duelInvitePrivacy")]
        public string DuelInvitePrivacy { get; set; }

        [JsonProperty("guildOnlineList")]
        public bool GuildOnlineList { get; set; }
    }
}
