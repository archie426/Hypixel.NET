namespace Hypixel.NET.WatchdogStatsApi
{
    public interface IWatchdogStatsRequest : IRequest
    {
        
        public string Cause { get; }
        
        public int WatchdogLastMinute { get; }
        
        public int StaffRollingDaily { get; }
        
        public int WatchdogTotal { get; }
        
        public int WatchdogRollingDaily { get; }
        
        public int StaffTotal { get; }
    }
}