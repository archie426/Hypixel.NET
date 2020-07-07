using System.Collections.Generic;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public interface ILeaderboard
    {
        public List<ILeaderboardData> TntGames { get; set; }
        
        public List<ILeaderboardData> Walls { get; set; }
        
        public List<ILeaderboardData> Quake { get; set; }
        
        public List<ILeaderboardData> SkyWars { get; set; }
        
        public List<ILeaderboardData> VampireZ { get; set; }
        
        public List<ILeaderboardData> Walls3 { get; set; }
        
        public List<ILeaderboardData> SkyClash { get; set; }

        public List<ILeaderboardData> BedWars { get; set; }
        
        public List<ILeaderboardData> BuildBattle { get; set; }
        
        public List<ILeaderboardData> Uhc { get; set; }
        
        public List<ILeaderboardData> PaintBall { get; set; }
        
        public List<ILeaderboardData> Smash { get; set; }
        
        public List<ILeaderboardData> TrueCombat { get; set; }
        
        public List<ILeaderboardData> CopsAndCrims { get; set; }
        
        public List<ILeaderboardData> BlitzSg { get; set; }
        
        public List<ILeaderboardData> Warlords { get; set; }
        
        public List<ILeaderboardData> MurderMystery { get; set; }
        
        public List<ILeaderboardData> Arena { get; set; }
        
        public List<ILeaderboardData> SpeedUhc { get; set; }
        
        public List<ILeaderboardData> Arcade { get; set; }
        
        public List<ILeaderboardData> Duels { get; set; }
        
        public List<ILeaderboardData> TurboKartRacers { get; set; }
    }
}