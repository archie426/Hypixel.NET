using System;

namespace Hypixel.NET.FriendsApi.Record
{
    public interface IRecords
    {
        public string UuidSender { get; }
        
        public string UuidReceiver { get; }
        
        public DateTime Started { get; }
    }
}