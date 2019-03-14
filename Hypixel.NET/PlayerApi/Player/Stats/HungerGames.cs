using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class HungerGames
    {
        [JsonProperty("arachnologist")]
        public int ArachnologistLevel { get; set; }

        [JsonProperty("archer")]
        public int ArcherLevel { get; set; }

        [JsonProperty("armorer")]
        public int ArmorerLevel { get; set; }

        [JsonProperty("astronaut")]
        public int AstronautLevel { get; set; }

        [JsonProperty("aura")]
        public string AuraLevel { get; set; }

        [JsonProperty("baker")]
        public int BakerLevel { get; set; }

        [JsonProperty("blaze")]
        public int BlazeLevel { get; set; }

        [JsonProperty("blood")]
        public bool BloodLevel { get; set; }

        [JsonProperty("chosen_taunt")]
        public string ChosenTaunt { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("creepertamer")]
        public int CreeperTamerLevel { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("fisherman")]
        public int FishermanLevel { get; set; }

        [JsonProperty("horsetamer")]
        public int HorseTamerLevel { get; set; }

        [JsonProperty("hunter")]
        public int HunterLevel { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("knight")]
        public int KnightLevel { get; set; }

        [JsonProperty("meatmaster")]
        public int MeatmasterLevel { get; set; }

        [JsonProperty("necromancer")]
        public int NecromancerLevel { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("pigman")]
        public int PigmanLevel { get; set; }

        [JsonProperty("reddragon")]
        public int RedDragonLevel { get; set; }

        [JsonProperty("rogue")]
        public int RogueLevel { get; set; }

        [JsonProperty("scout")]
        public int ScoutLevel { get; set; }

        [JsonProperty("slimeyslime")]
        public int SlimeySlimeLevel { get; set; }

        [JsonProperty("snowman")]
        public int SnowmanLevel { get; set; }

        [JsonProperty("speleologist")]
        public int SpeleologistLevel { get; set; }

        [JsonProperty("tim")]
        public int TimLevel { get; set; }

        [JsonProperty("toxicologist")]
        public int ToxicologistLevel { get; set; }

        [JsonProperty("troll")]
        public int TrollLevel { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("wolftamer")]
        public int WolfTamerLevel { get; set; }

        [JsonProperty("wins_teams")]
        public int WinsTeams { get; set; }

        [JsonProperty("votes_Aelin's Tower")]
        public int VotesAelinSTower { get; set; }

        [JsonProperty("votes_Egypt")]
        public int VotesEgypt { get; set; }

        [JsonProperty("votes_Winter")]
        public int VotesWinter { get; set; }

        [JsonProperty("votes_Caelum v2")]
        public int VotesCaelumV2 { get; set; }

        [JsonProperty("votes_Valley")]
        public int VotesValley { get; set; }

        [JsonProperty("paladin")]
        public int PaladinLevel { get; set; }

        [JsonProperty("shadow knight")]
        public int ShadowKnightLevel { get; set; }

        [JsonProperty("rambo_wins")]
        public int RamboWins { get; set; }

        [JsonProperty("chosen_victorydance")]
        public string ChosenVictorydance { get; set; }

        [JsonProperty("hype train")]
        public int HypeTrainLevel { get; set; }

        [JsonProperty("jockey")]
        public int JockeyLevel { get; set; }

        [JsonProperty("auratoggle")]
        public bool AuraToggle { get; set; }

        [JsonProperty("chosen_finisher")]
        public string ChosenFinisher { get; set; }

        [JsonProperty("votes_Mirador Basin")]
        public int VotesMiradorBasin { get; set; }

        [JsonProperty("combatTracker")]
        public bool CombatTracker { get; set; }

        [JsonProperty("reaper")]
        public int ReaperLevel { get; set; }

        [JsonProperty("golem")]
        public int GolemLevel { get; set; }

        [JsonProperty("florist")]
        public int FloristLevel { get; set; }

        [JsonProperty("farmer")]
        public int FarmerLevel { get; set; }

        [JsonProperty("autoarmor")]
        public bool AutoArmour { get; set; }
    }
}
