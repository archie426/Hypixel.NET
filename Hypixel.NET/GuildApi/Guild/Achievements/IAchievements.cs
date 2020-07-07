namespace Hypixel.NET.GuildApi.Guild.Achievements
{
    public interface IAchievements
    {
        public int Winners { get; }
        
        public int ExperienceKings { get; }
        
        public int OnlinePlayers { get; }
    }
}