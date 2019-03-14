using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class GingerBread
    {
        [JsonProperty("engine_active")]
        public string EngineActive { get; set; }

        [JsonProperty("booster_active")]
        public string BoosterActive { get; set; }

        [JsonProperty("frame_active")]
        public string FrameActive { get; set; }

        [JsonProperty("shoes_active")]
        public string ShoesActive { get; set; }

        [JsonProperty("helmet_active")]
        public string HelmetActive { get; set; }

        [JsonProperty("skin_active")]
        public string SkinActive { get; set; }

        [JsonProperty("pants_active")]
        public string PantsActive { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("jacket_active")]
        public string JacketActive { get; set; }

        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("horn")]
        public string Horn { get; set; }

        [JsonProperty("olympus_plays")]
        public int OlympusPlays { get; set; }

        [JsonProperty("banana_hits_received")]
        public int BananaHitsReceived { get; set; }

        [JsonProperty("box_pickups")]
        public int BoxPickups { get; set; }

        [JsonProperty("coins_picked_up")]
        public int CoinsPickedUp { get; set; }

        [JsonProperty("laps_completed")]
        public int LapsCompleted { get; set; }

        [JsonProperty("box_pickups_olympus")]
        public int BoxPickupsOlympus { get; set; }

        [JsonProperty("banana_hits_sent")]
        public int BananaHitsSent { get; set; }

        [JsonProperty("box_pickups_hypixelgp")]
        public int BoxPickupsHypixelgp { get; set; }

        [JsonProperty("hypixelgp_plays")]
        public int HypixelgpPlays { get; set; }

        [JsonProperty("silver_trophy")]
        public int TotalSilverTrophy { get; set; }

        [JsonProperty("silver_trophy_hypixelgp")]
        public int SilverTrophyHypixelgp { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("parts")]
        public string Parts { get; set; }

        [JsonProperty("particle_trail")]
        public string ParticleTrail { get; set; }

        [JsonProperty("bronze_trophy_olympus")]
        public int BronzeTrophyOlympus { get; set; }

        [JsonProperty("bronze_trophy")]
        public int TotalBronzeTrophy { get; set; }

        [JsonProperty("bronze_trophy_monthly_b")]
        public int BronzeTrophyMonthlyB { get; set; }

        [JsonProperty("silver_trophy_olympus")]
        public int SilverTrophyOlympus { get; set; }

        [JsonProperty("retro_plays")]
        public int RetroPlays { get; set; }

        [JsonProperty("box_pickups_retro")]
        public int BoxPickupsRetro { get; set; }

        [JsonProperty("box_pickups_canyon")]
        public int BoxPickupsCanyon { get; set; }

        [JsonProperty("canyon_plays")]
        public int CanyonPlays { get; set; }

        [JsonProperty("bronze_trophy_canyon")]
        public int BronzeTrophyCanyon { get; set; }

        [JsonProperty("gold_trophy")]
        public int TotalGoldTrophy { get; set; }

        [JsonProperty("gold_trophy_olympus")]
        public long GoldTrophyOlympus { get; set; }

        [JsonProperty("silver_trophy_canyon")]
        public long SilverTrophyCanyon { get; set; }

        [JsonProperty("box_pickups_junglerush")]
        public long BoxPickupsJunglerush { get; set; }

        [JsonProperty("junglerush_plays")]
        public long JunglerushPlays { get; set; }

        [JsonProperty("bronze_trophy_junglerush")]
        public long BronzeTrophyJunglerush { get; set; }

        [JsonProperty("gold_trophy_canyon")]
        public long GoldTrophyCanyon { get; set; }

        [JsonProperty("silver_trophy_retro")]
        public long SilverTrophyRetro { get; set; }

        [JsonProperty("gold_trophy_hypixelgp")]
        public long GoldTrophyHypixelgp { get; set; }

        [JsonProperty("blue_torpedo_hit")]
        public long BlueTorpedoHit { get; set; }

        [JsonProperty("silver_trophy_junglerush")]
        public long SilverTrophyJunglerush { get; set; }
    }
}