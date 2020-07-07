namespace Hypixel.NET.KeyApi.Record
{
    public interface IRecord
    {
        public string OwnerUuid { get; }
        
        public string Key { get;  }
        
        public int TotalQueries { get; }
        
        public int TotalQueriesInPastMin { get; }
    }
}