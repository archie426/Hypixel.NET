using System.Collections.Generic;
using Hypixel.NET.Booster;

namespace Hypixel.NET.BoosterApi
{
    public interface IBoostersRequest : IRequest
    {
        public string Cause { get; }
        
        public List<IBooster> Boosters { get; }
    }
}