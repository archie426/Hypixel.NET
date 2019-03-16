using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi.Guild.XpByGameType
{
    public class GuildExpByGameType
    {
        [JsonProperty("QUAKECRAFT")]
        public int Quake { get; set; }

        [JsonProperty("WALLS")]
        public int Walls { get; set; }

        [JsonProperty("PAINTBALL")]
        public int PaintBall { get; set; }

        [JsonProperty("SURVIVAL_GAMES")]
        public int SurvivalGames { get; set; }

        [JsonProperty("TNTGAMES")]
        public int TNTGames { get; set; }

        [JsonProperty("VAMPIREZ")]
        public int VampireZ { get; set; }

        [JsonProperty("ARCADE")]
        public int Arcade { get; set; }

        [JsonProperty("ARENA")]
        public int Arena { get; set; }

        [JsonProperty("MCGO")]
        public int McGo { get; set; }

        [JsonProperty("UHC")]
        public int Uhc { get; set; }

        [JsonProperty("BATTLEGROUND")]
        public int Warlords { get; set; }

        [JsonProperty("SUPER_SMASH")]
        public int Smash { get; set; }

        [JsonProperty("GINGERBREAD")]
        public int TurboKartRacers { get; set; }

        [JsonProperty("SKYWARS")]
        public int SkyWars { get; set; }

        [JsonProperty("TRUE_COMBAT")]
        public int CrazyWalls { get; set; }

        [JsonProperty("SPEED_UHC")]
        public int SpeedUhc { get; set; }

        [JsonProperty("SKYCLASH")]
        public int Skyclash { get; set; }

        [JsonProperty("PROTOTYPE")]
        public int Prototype { get; set; }

        [JsonProperty("BEDWARS")]
        public int Bedwars { get; set; }

        [JsonProperty("MURDER_MYSTERY")]
        public int MurderMystery { get; set; }

        [JsonProperty("BUILD_BATTLE")]
        public int BuildBattle { get; set; }

        [JsonProperty("DUELS")]
        public int Duels { get; set; }
    }
}