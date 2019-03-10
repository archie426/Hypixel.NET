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
        public long Coins { get; set; }

        [JsonProperty("horn")]
        public string Horn { get; set; }

        [JsonProperty("box_pickups_monthly_b")]
        public long BoxPickupsMonthlyB { get; set; }

        [JsonProperty("olympus_plays")]
        public long OlympusPlays { get; set; }

        [JsonProperty("banana_hits_received")]
        public long BananaHitsReceived { get; set; }

        [JsonProperty("box_pickups")]
        public long BoxPickups { get; set; }

        [JsonProperty("coins_picked_up")]
        public long CoinsPickedUp { get; set; }

        [JsonProperty("box_pickups_weekly_a")]
        public long BoxPickupsWeeklyA { get; set; }

        [JsonProperty("laps_completed")]
        public long LapsCompleted { get; set; }

        [JsonProperty("box_pickups_olympus")]
        public long BoxPickupsOlympus { get; set; }

        [JsonProperty("banana_hits_sent")]
        public long BananaHitsSent { get; set; }

        [JsonProperty("box_pickups_hypixelgp")]
        public long BoxPickupsHypixelgp { get; set; }

        [JsonProperty("silver_trophy_weekly_a")]
        public long SilverTrophyWeeklyA { get; set; }

        [JsonProperty("hypixelgp_plays")]
        public long HypixelgpPlays { get; set; }

        [JsonProperty("silver_trophy")]
        public long SilverTrophy { get; set; }

        [JsonProperty("silver_trophy_monthly_b")]
        public long SilverTrophyMonthlyB { get; set; }

        [JsonProperty("silver_trophy_hypixelgp")]
        public long SilverTrophyHypixelgp { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("parts")]
        public string Parts { get; set; }

        [JsonProperty("particle_trail")]
        public string ParticleTrail { get; set; }

        [JsonProperty("bronze_trophy_olympus")]
        public long BronzeTrophyOlympus { get; set; }

        [JsonProperty("bronze_trophy_weekly_a")]
        public long BronzeTrophyWeeklyA { get; set; }

        [JsonProperty("bronze_trophy")]
        public long BronzeTrophy { get; set; }

        [JsonProperty("bronze_trophy_monthly_b")]
        public long BronzeTrophyMonthlyB { get; set; }

        [JsonProperty("silver_trophy_olympus")]
        public long SilverTrophyOlympus { get; set; }

        [JsonProperty("retro_plays")]
        public long RetroPlays { get; set; }

        [JsonProperty("box_pickups_retro")]
        public long BoxPickupsRetro { get; set; }

        [JsonProperty("box_pickups_canyon")]
        public long BoxPickupsCanyon { get; set; }

        [JsonProperty("canyon_plays")]
        public long CanyonPlays { get; set; }

        [JsonProperty("bronze_trophy_canyon")]
        public long BronzeTrophyCanyon { get; set; }

        [JsonProperty("gold_trophy")]
        public long GoldTrophy { get; set; }

        [JsonProperty("gold_trophy_olympus")]
        public long GoldTrophyOlympus { get; set; }

        [JsonProperty("gold_trophy_monthly_b")]
        public long GoldTrophyMonthlyB { get; set; }

        [JsonProperty("gold_trophy_weekly_a")]
        public long GoldTrophyWeeklyA { get; set; }

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

        [JsonProperty("box_pickups_weekly_b")]
        public long BoxPickupsWeeklyB { get; set; }

        [JsonProperty("silver_trophy_weekly_b")]
        public long SilverTrophyWeeklyB { get; set; }

        [JsonProperty("bronze_trophy_weekly_b")]
        public long BronzeTrophyWeeklyB { get; set; }

        [JsonProperty("gold_trophy_weekly_b")]
        public long GoldTrophyWeeklyB { get; set; }

        [JsonProperty("box_pickups_monthly_a")]
        public long BoxPickupsMonthlyA { get; set; }

        [JsonProperty("gold_trophy_monthly_a")]
        public long GoldTrophyMonthlyA { get; set; }

        [JsonProperty("silver_trophy_monthly_a")]
        public long SilverTrophyMonthlyA { get; set; }

        [JsonProperty("silver_trophy_junglerush")]
        public long SilverTrophyJunglerush { get; set; }
    }
}