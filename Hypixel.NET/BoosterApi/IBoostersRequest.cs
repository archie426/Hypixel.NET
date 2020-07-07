using System.Collections.Generic;
using Hypixel.NET.Booster;

namespace Hypixel.NET.BoosterApi
{
    public interface IBoostersRequest
    {
        public bool WasSuccessful { get; }
        
        public string Cause { get; }
        
        public List<IBooster> Boosters { get; }
    }
}