using System.Collections.Generic;
using Hypixel.NET.FriendsApi.Record;

namespace Hypixel.NET.FriendsApi
{
    public interface IFriendsListRequest : IRequest
    {
        public bool FromCache { get; }

        public List<Records> Records { get; }
        
        public string Cause { get; }
    }
}