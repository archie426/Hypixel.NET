using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Walls
    {
        [JsonProperty("adrenaline")]
        public int Adrenaline { get; set; }

        [JsonProperty("bacon")]
        public int Bacon { get; set; }

        [JsonProperty("berserk")]
        public int Berserk { get; set; }

        [JsonProperty("blacksmith")]
        public int Blacksmith { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("fortune")]
        public int Fortune { get; set; }

        [JsonProperty("gold_rush")]
        public int GoldRush { get; set; }

        [JsonProperty("guitarist")]
        public int Guitarist { get; set; }

        [JsonProperty("haste")]
        public int Haste { get; set; }

        [JsonProperty("hunter")]
        public int Hunter { get; set; }

        [JsonProperty("insane_farmer")]
        public int InsaneFarmer { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("lazyman")]
        public int Lazyman { get; set; }

        [JsonProperty("leather_worker")]
        public int LeatherWorker { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("master_troll")]
        public int MasterTroll { get; set; }

        [JsonProperty("opportunity")]
        public int Opportunity { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("pyromaniac")]
        public int Pyromaniac { get; set; }

        [JsonProperty("ready")]
        public int Ready { get; set; }

        [JsonProperty("redstone_expert")]
        public int RedstoneExpert { get; set; }

        [JsonProperty("sage")]
        public int Sage { get; set; }

        [JsonProperty("scotsman")]
        public int Scotsman { get; set; }

        [JsonProperty("skybase_king")]
        public int SkybaseKing { get; set; }

        [JsonProperty("smart_boy")]
        public int SmartBoy { get; set; }

        [JsonProperty("snack_lover")]
        public int SnackLover { get; set; }

        [JsonProperty("soup_drinker")]
        public int SoupDrinker { get; set; }

        [JsonProperty("swift")]
        public int Swift { get; set; }

        [JsonProperty("tenacity")]
        public int Tenacity { get; set; }

        [JsonProperty("trap_engineer")]
        public int TrapEngineer { get; set; }

        [JsonProperty("vampirism")]
        public int Vampirism { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("expert_miner")]
        public int ExpertMiner { get; set; }

        [JsonProperty("chainkiller")]
        public int Chainkiller { get; set; }

        [JsonProperty("fireproof")]
        public int Fireproof { get; set; }

        [JsonProperty("burn_baby_burn")]
        public int BurnBabyBurn { get; set; }

        [JsonProperty("final_form")]
        public int FinalForm { get; set; }

        [JsonProperty("cats_eye")]
        public int CatsEye { get; set; }

        [JsonProperty("artisan")]
        public int Artisan { get; set; }

        [JsonProperty("fisherman")]
        public int Fisherman { get; set; }

        [JsonProperty("vitality")]
        public int Vitality { get; set; }

        [JsonProperty("thats_hot")]
        public int ThatsHot { get; set; }

        [JsonProperty("really_shiny")]
        public int ReallyShiny { get; set; }

        [JsonProperty("very_fortunate")]
        public int VeryFortunate { get; set; }
    }
}