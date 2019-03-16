using Newtonsoft.Json;

namespace Hypixel.NET.WatchdogStatsApi
{
    public class GetWatchdogStats
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("watchdog_lastMinute")]
        public int WatchdogLastMinute { get; set; }

        [JsonProperty("staff_rollingDaily")]
        public int StaffRollingDaily { get; set; }

        [JsonProperty("watchdog_total")]
        public int WatchdogTotal { get; set; }

        [JsonProperty("watchdog_rollingDaily")]
        public int WatchdogRollingDaily { get; set; }

        [JsonProperty("staff_total")]
        public int StaffTotal { get; set; }
    }
}