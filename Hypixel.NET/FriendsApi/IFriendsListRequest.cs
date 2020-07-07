using System.Collections.Generic;
using Hypixel.NET.FriendsApi.Record;

namespace Hypixel.NET.FriendsApi
{
    public interface IFriendsListRequest
    {
        public bool FromCache { get; }
        
        public bool WasSuccessful { get; }
        
        public List<Records> Records { get; }
        
        public string Cause { get; }
    }
}