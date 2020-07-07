using Hypixel.NET.KeyApi.Record;

namespace Hypixel.NET.KeyApi
{
    public interface IKeyRequest : IRequest
    {
        public string Cause { get;  }
        
        public IRecord Record { get; }
    }
}