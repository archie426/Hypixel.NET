using Hypixel.NET.KeyApi.Record;

namespace Hypixel.NET.KeyApi
{
    public interface IKeyRequest
    {
        public bool WasSuccessful { get;  }
        
        public string Cause { get;  }
        
        public IRecord Record { get; }
    }
}