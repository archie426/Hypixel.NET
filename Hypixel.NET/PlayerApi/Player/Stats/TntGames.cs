using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class TntGames
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths_bowspleef")]
        public long DeathsBowspleef { get; set; }

        [JsonProperty("tags_bowspleef")]
        public long TagsBowspleef { get; set; }

        [JsonProperty("spleef_doublejump")]
        public long SpleefDoublejump { get; set; }

        [JsonProperty("spleef_triple")]
        public long SpleefTriple { get; set; }

        [JsonProperty("record_pvprun")]
        public long RecordPvprun { get; set; }

        [JsonProperty("record_tntrun")]
        public long RecordTntrun { get; set; }

        [JsonProperty("capture_class")]
        public string CaptureClass { get; set; }

        [JsonProperty("wins_tntrun")]
        public long WinsTntrun { get; set; }

        [JsonProperty("kills_tntag")]
        public long KillsTntag { get; set; }

        [JsonProperty("wins_tntag")]
        public long WinsTntag { get; set; }

        [JsonProperty("winstreak")]
        public long Winstreak { get; set; }

        [JsonProperty("new_kineticwizard_explode")]
        public long NewKineticwizardExplode { get; set; }

        [JsonProperty("new_kineticwizard_regen")]
        public long NewKineticwizardRegen { get; set; }

        [JsonProperty("new_pvprun_double_jumps")]
        public long NewPvprunDoubleJumps { get; set; }

        [JsonProperty("new_witherwizard_regen")]
        public long NewWitherwizardRegen { get; set; }

        [JsonProperty("new_spleef_tripleshot")]
        public long NewSpleefTripleshot { get; set; }

        [JsonProperty("new_tntrun_double_jumps")]
        public long NewTntrunDoubleJumps { get; set; }

        [JsonProperty("new_tntag_speedy")]
        public long NewTntagSpeedy { get; set; }

        [JsonProperty("new_spleef_repulsor")]
        public long NewSpleefRepulsor { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("new_witherwizard_explode")]
        public long NewWitherwizardExplode { get; set; }

        [JsonProperty("new_firewizard_regen")]
        public long NewFirewizardRegen { get; set; }

        [JsonProperty("new_bloodwizard_explode")]
        public long NewBloodwizardExplode { get; set; }

        [JsonProperty("new_icewizard_regen")]
        public long NewIcewizardRegen { get; set; }

        [JsonProperty("new_spleef_double_jumps")]
        public long NewSpleefDoubleJumps { get; set; }

        [JsonProperty("new_bloodwizard_regen")]
        public long NewBloodwizardRegen { get; set; }

        [JsonProperty("new_firewizard_explode")]
        public long NewFirewizardExplode { get; set; }

        [JsonProperty("new_icewizard_explode")]
        public long NewIcewizardExplode { get; set; }

        [JsonProperty("run_potions_splashed_on_players")]
        public long RunPotionsSplashedOnPlayers { get; set; }

        [JsonProperty("deaths_tntrun")]
        public long DeathsTntrun { get; set; }

        [JsonProperty("tag_speeditup")]
        public long TagSpeeditup { get; set; }

        [JsonProperty("tag_slowitdown")]
        public long TagSlowitdown { get; set; }

        [JsonProperty("deaths_pvprun")]
        public long DeathsPvprun { get; set; }

        [JsonProperty("kills_pvprun")]
        public long KillsPvprun { get; set; }

        [JsonProperty("tag_blastprotection")]
        public long TagBlastprotection { get; set; }

        [JsonProperty("wins_pvprun")]
        public long WinsPvprun { get; set; }

        [JsonProperty("wins_bowspleef")]
        public long WinsBowspleef { get; set; }

        [JsonProperty("votes_Forgotten Planet")]
        public long VotesForgottenPlanet { get; set; }

        [JsonProperty("new_toxicwizard_explode")]
        public long NewToxicwizardExplode { get; set; }

        [JsonProperty("new_firewizard_kills")]
        public long NewFirewizardKills { get; set; }

        [JsonProperty("kills_capture")]
        public long KillsCapture { get; set; }

        [JsonProperty("deaths_capture")]
        public long DeathsCapture { get; set; }

        [JsonProperty("assists_capture")]
        public long AssistsCapture { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("new_tntrun_slowness_potions")]
        public long NewTntrunSlownessPotions { get; set; }

        [JsonProperty("new_tntrun_speed_potions")]
        public long NewTntrunSpeedPotions { get; set; }

        [JsonProperty("new_pvprun_fortitude")]
        public long NewPvprunFortitude { get; set; }

        [JsonProperty("new_pvprun_notoriety")]
        public long NewPvprunNotoriety { get; set; }

        [JsonProperty("new_active_death_effect")]
        public string NewActiveDeathEffect { get; set; }

        [JsonProperty("new_selected_hat")]
        public string NewSelectedHat { get; set; }

        [JsonProperty("new_tntrun_double_jumps_legacy")]
        public long NewTntrunDoubleJumpsLegacy { get; set; }

        [JsonProperty("new_spleef_double_jumps_legacy")]
        public long NewSpleefDoubleJumpsLegacy { get; set; }

        [JsonProperty("new_spleef_repulsor_legacy")]
        public long NewSpleefRepulsorLegacy { get; set; }

        [JsonProperty("new_spleef_tripleshot_legacy")]
        public long NewSpleefTripleshotLegacy { get; set; }

        [JsonProperty("new_pvprun_double_jumps_legacy")]
        public long NewPvprunDoubleJumpsLegacy { get; set; }

        [JsonProperty("wizards_selected_class")]
        public string WizardsSelectedClass { get; set; }

        [JsonProperty("new_firewizard_assists")]
        public long NewFirewizardAssists { get; set; }

        [JsonProperty("points_capture")]
        public long PointsCapture { get; set; }

        [JsonProperty("new_firewizard_deaths")]
        public long NewFirewizardDeaths { get; set; }

        [JsonProperty("new_pvprun_regeneration")]
        public long NewPvprunRegeneration { get; set; }

        [JsonProperty("wins_capture")]
        public long WinsCapture { get; set; }

        [JsonProperty("new_toxicwizard_regen")]
        public long NewToxicwizardRegen { get; set; }

        [JsonProperty("new_toxicwizard_deaths")]
        public long NewToxicwizardDeaths { get; set; }

        [JsonProperty("new_toxicwizard_assists")]
        public long NewToxicwizardAssists { get; set; }

        [JsonProperty("new_toxicwizard_kills")]
        public long NewToxicwizardKills { get; set; }
    }
}
