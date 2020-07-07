using System;
using Newtonsoft.Json;

namespace Hypixel.NET.Booster
{
    public interface IBooster
    {
        public string PurchaserUuid { get; }
        
        public double Amount { get; }
        
        public int OriginalLength { get; }
        
        public int Length { get;  }
        
        public string GameType { get; }

        public DateTime DateActivated { get; }
    }
}