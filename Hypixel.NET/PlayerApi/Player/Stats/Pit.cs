using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Pit
    {
        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        [JsonProperty("pit_stats_ptl")]
        public PitStats PitStatsPtl { get; set; }

    }

    public class Profile
    {
        #region Prestige
        [JsonProperty("prestiges")]
        public List<Prestige> Prestiges { get; set; }

        [JsonProperty("unlocks")]
        public List<PrestigeUnlocks> Unlocks { get; set; }

        [JsonProperty("unlocks_26")]
        public List<PrestigeUnlocks> Unlocks26 { get; set; }

        [JsonProperty("cash_during_prestige_28")]
        public double CashDuringPrestige28 { get; set; }

        [JsonProperty("unlocks_27")]
        public List<PrestigeUnlocks> Unlocks27 { get; set; }

        [JsonProperty("cash_during_prestige_29")]
        public double CashDuringPrestige29 { get; set; }

        [JsonProperty("unlocks_28")]
        public List<PrestigeUnlocks> Unlocks28 { get; set; }

        [JsonProperty("unlocks_29")]
        public List<PrestigeUnlocks> Unlocks29 { get; set; }

        [JsonProperty("unlocks_22")]
        public List<PrestigeUnlocks> Unlocks22 { get; set; }

        [JsonProperty("unlocks_23")]
        public List<PrestigeUnlocks> Unlocks23 { get; set; }

        [JsonProperty("unlocks_24")]
        public List<PrestigeUnlocks> Unlocks24 { get; set; }

        [JsonProperty("unlocks_25")]
        public List<PrestigeUnlocks> Unlocks25 { get; set; }

        [JsonProperty("cash_during_prestige_20")]
        public double CashDuringPrestige20 { get; set; }

        [JsonProperty("cash_during_prestige_21")]
        public double CashDuringPrestige21 { get; set; }

        [JsonProperty("unlocks_20")]
        public List<PrestigeUnlocks> Unlocks20 { get; set; }

        [JsonProperty("cash_during_prestige_22")]
        public double CashDuringPrestige22 { get; set; }

        [JsonProperty("unlocks_21")]
        public List<PrestigeUnlocks> Unlocks21 { get; set; }

        [JsonProperty("cash_during_prestige_23")]
        public double CashDuringPrestige23 { get; set; }

        [JsonProperty("cash_during_prestige_24")]
        public double CashDuringPrestige24 { get; set; }

        [JsonProperty("cash_during_prestige_25")]
        public double CashDuringPrestige25 { get; set; }

        [JsonProperty("cash_during_prestige_26")]
        public double CashDuringPrestige26 { get; set; }

        [JsonProperty("cash_during_prestige_27")]
        public double CashDuringPrestige27 { get; set; }

        [JsonProperty("cash_during_prestige_7")]
        public double CashDuringPrestige7 { get; set; }

        [JsonProperty("cash_during_prestige_6")]
        public double CashDuringPrestige6 { get; set; }

        [JsonProperty("cash_during_prestige_9")]
        public double CashDuringPrestige9 { get; set; }

        [JsonProperty("cash_during_prestige_8")]
        public double CashDuringPrestige8 { get; set; }

        [JsonProperty("cash_during_prestige_30")]
        public double CashDuringPrestige30 { get; set; }

        [JsonProperty("unlocks_30")]
        public List<PrestigeUnlocks> Unlocks30 { get; set; }

        [JsonProperty("renown_unlocks")]
        public List<PrestigeUnlocks> RenownUnlocks { get; set; }

        [JsonProperty("unlocks_15")]
        public List<PrestigeUnlocks> Unlocks15 { get; set; }

        [JsonProperty("cash_during_prestige_17")]
        public double CashDuringPrestige17 { get; set; }

        [JsonProperty("unlocks_16")]
        public List<PrestigeUnlocks> Unlocks16 { get; set; }

        [JsonProperty("cash_during_prestige_18")]
        public double CashDuringPrestige18 { get; set; }

        [JsonProperty("unlocks_17")]
        public List<PrestigeUnlocks> Unlocks17 { get; set; }

        [JsonProperty("cash_during_prestige_19")]
        public double CashDuringPrestige19 { get; set; }

        [JsonProperty("unlocks_18")]
        public List<PrestigeUnlocks> Unlocks18 { get; set; }

        [JsonProperty("unlocks_11")]
        public List<PrestigeUnlocks> Unlocks11 { get; set; }

        [JsonProperty("unlocks_12")]
        public List<PrestigeUnlocks> Unlocks12 { get; set; }

        [JsonProperty("unlocks_13")]
        public List<PrestigeUnlocks> Unlocks13 { get; set; }

        [JsonProperty("unlocks_14")]
        public List<PrestigeUnlocks> Unlocks14 { get; set; }

        [JsonProperty("unlocks_19")]
        public List<PrestigeUnlocks> Unlocks19 { get; set; }

        [JsonProperty("unlocks_10")]
        public List<PrestigeUnlocks> Unlocks10 { get; set; }

        [JsonProperty("cash_during_prestige_12")]
        public double CashDuringPrestige12 { get; set; }

        [JsonProperty("cash_during_prestige_13")]
        public double CashDuringPrestige13 { get; set; }

        [JsonProperty("cash_during_prestige_14")]
        public double CashDuringPrestige14 { get; set; }

        [JsonProperty("cash_during_prestige_15")]
        public double CashDuringPrestige15 { get; set; }

        [JsonProperty("cash_during_prestige_16")]
        public double CashDuringPrestige16 { get; set; }

        [JsonProperty("cash_during_prestige_10")]
        public double CashDuringPrestige10 { get; set; }

        [JsonProperty("cash_during_prestige_11")]
        public double CashDuringPrestige11 { get; set; }

        [JsonProperty("cash_during_prestige_0")]
        public double CashDuringPrestige0 { get; set; }

        [JsonProperty("cash_during_prestige_1")]
        public double CashDuringPrestige1 { get; set; }

        [JsonProperty("cash_during_prestige_2")]
        public double CashDuringPrestige2 { get; set; }

        [JsonProperty("cash_during_prestige_3")]
        public double CashDuringPrestige3 { get; set; }

        [JsonProperty("cash_during_prestige_4")]
        public double CashDuringPrestige4 { get; set; }

        [JsonProperty("cash_during_prestige_5")]
        public double CashDuringPrestige5 { get; set; }

        [JsonProperty("unlocks_8")]
        public List<PrestigeUnlocks> Unlocks8 { get; set; }

        [JsonProperty("unlocks_9")]
        public List<PrestigeUnlocks> Unlocks9 { get; set; }

        [JsonProperty("unlocks_1")]
        public List<PrestigeUnlocks> Unlocks1 { get; set; }

        [JsonProperty("unlocks_2")]
        public List<PrestigeUnlocks> Unlocks2 { get; set; }

        [JsonProperty("unlocks_3")]
        public List<PrestigeUnlocks> Unlocks3 { get; set; }

        [JsonProperty("unlocks_4")]
        public List<PrestigeUnlocks> Unlocks4 { get; set; }

        [JsonProperty("unlocks_5")]
        public List<PrestigeUnlocks> Unlocks5 { get; set; }

        [JsonProperty("unlocks_6")]
        public List<PrestigeUnlocks> Unlocks6 { get; set; }

        [JsonProperty("unlocks_7")]
        public List<PrestigeUnlocks> Unlocks7 { get; set; }

        #endregion

        #region General stats

        [JsonProperty("cash")]
        public double Cash { get; set; }

        [JsonProperty("selected_perk_3")]
        public string SelectedPerk3 { get; set; }

        [JsonProperty("selected_perk_2")]
        public string SelectedPerk2 { get; set; }

        [JsonProperty("selected_perk_1")]
        public string SelectedPerk1 { get; set; }

        [JsonProperty("selected_perk_0")]
        public string SelectedPerk0 { get; set; }

        [JsonProperty("impatient_enabled")]
        public bool ImpatientEnabled { get; set; }

        [JsonProperty("renown")]
        public long Renown { get; set; }

        [JsonProperty("drop_confirm_disabled")]
        public bool DropConfirmDisabled { get; set; }

        [JsonProperty("xp")]
        public long Xp { get; set; }
        #endregion

        [JsonProperty("contract_choices")]
        public List<ContractChoice> ContractChoices { get; set; }

        [JsonProperty("trade_timestamps")]
        public List<long> TradeTimestamps { get; set; }

        [JsonProperty("inv_enderchest")]
        public EnderchestInventory InvEnderchest { get; set; }

        [JsonProperty("death_recaps")]
        public DeathRecaps DeathRecaps { get; set; }

        [JsonProperty("gold_transactions")]
        public List<GoldTransaction> GoldTransactions { get; set; }

        [JsonProperty("chat_option_player_chat")]
        public bool ChatOptionPlayerChat { get; set; }

        [JsonProperty("inv_contents")]
        public InventoryContent InvContents { get; set; }

        [JsonProperty("last_midfight_disconnect")]
        public long LastMidfightDisconnect { get; set; }

        [JsonProperty("ended_contracts")]
        public List<EndedContract> EndedContracts { get; set; }

        [JsonProperty("last_save")]
        public long LastSave { get; set; }

        [JsonProperty("chat_option_bounties")]
        public bool ChatOptionBounties { get; set; }

        [JsonProperty("king_quest")]
        public KingQuest KingQuest { get; set; }

        [JsonProperty("hat_color")]
        public long HatColor { get; set; }

        [JsonProperty("chat_option_misc")]
        public bool ChatOptionMisc { get; set; }

        [JsonProperty("leaderboard_stats")]
        public Dictionary<string, long> LeaderboardStats { get; set; }

        [JsonProperty("last_contract")]
        public long LastContract { get; set; }

        [JsonProperty("chat_option_prestige_announcements")]
        public bool ChatOptionPrestigeAnnouncements { get; set; }

        [JsonProperty("hat_enabled")]
        public bool HatEnabled { get; set; }

        [JsonProperty("chat_option_minor_events")]
        public bool ChatOptionMinorEvents { get; set; }

        [JsonProperty("chat_option_streaks")]
        public bool ChatOptionStreaks { get; set; }

        [JsonProperty("zero_point_three_gold_transfer")]
        public bool ZeroPointThreeGoldTransfer { get; set; }

        [JsonProperty("selected_launch_trail")]
        public string SelectedLaunchTrail { get; set; }

        [JsonProperty("inv_armor")]
        public DeathRecaps InvArmor { get; set; }

        [JsonProperty("chat_option_kill_feed")]
        public bool ChatOptionKillFeed { get; set; }

        [JsonProperty("hotbar_favorites")]
        public List<long> HotbarFavorites { get; set; }

        [JsonProperty("recent_kills")]
        public List<RecentKill> RecentKills { get; set; }

        [JsonProperty("apollo_enabled")]
        public bool ApolloEnabled { get; set; }
    }

    public class ContractChoice
    {
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("gold_reward")]
        public long GoldReward { get; set; }

        [JsonProperty("progress")]
        public KingQuest Progress { get; set; }

        [JsonProperty("completion_date")]
        public long CompletionDate { get; set; }

        [JsonProperty("remaining_ticks")]
        public long RemainingTicks { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public partial class KingQuest
    {
        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; set; }
    }

    public class DeathRecaps
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("data")]
        public List<long> Data { get; set; }
    }

    public class EnderchestInventory
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("data")]
        public List<long> Data { get; set; }
    }

    public class InventoryContent
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("data")]
        public List<long> Data { get; set; }
    }
    public class EndedContract
    {
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("gold_reward")]
        public long GoldReward { get; set; }

        [JsonProperty("progress")]
        public Progress Progress { get; set; }

        [JsonProperty("completion_date")]
        public long CompletionDate { get; set; }

        [JsonProperty("remaining_ticks")]
        public long RemainingTicks { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public  class Progress
    {
        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; set; }

        [JsonProperty("shots", NullValueHandling = NullValueHandling.Ignore)]
        public long? Shots { get; set; }

        [JsonProperty("streak", NullValueHandling = NullValueHandling.Ignore)]
        public long? Streak { get; set; }
    }

    public class GoldTransaction
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    public class Prestige
    {
        [JsonProperty("index")]
        public long Index { get; set; }

        [JsonProperty("xp_on_prestige")]
        public long XpOnPrestige { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    public class RecentKill
    {
        [JsonProperty("victim")]
        public string Victim { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    public class PrestigeUnlocks
    {
        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("acquireDate")]
        public long AcquireDate { get; set; }

        [JsonProperty("key")]
        public string Unlock { get; set; }
    }
    public class PitLeaderboardStats
    {
        [JsonProperty("Pit_rage_pit_damage_2019_summer")]
        public long PitRagePitDamage2019Summer { get; set; }

        [JsonProperty("Pit_raffle_jackpot_2019_summer")]
        public long PitRaffle_Jackpot2019Summer { get; set; }

        [JsonProperty("Pit_auction_bid_2019_summer")]
        public long PitAuctionBid2019Summer { get; set; }

        [JsonProperty("Pit_raffle_tickets_2019_summer")]
        public long PitRaffleTickets2019Summer { get; set; }

        [JsonProperty("Pit_blockhead_blocks_2019_summer")]
        public long PitBlockheadBlocks2019Summer { get; set; }

        [JsonProperty("Pit_cake_eaten_2019_summer")]
        public long PitCakeEaten2019Summer { get; set; }

        [JsonProperty("Pit_tdm_blue_kills_2019_summer")]
        public long PitTdmBlueKills2019Summer { get; set; }

        [JsonProperty("Pit_kotl_gold_2019_summer")]
        public long PitKotlGold2019Summer { get; set; }

        [JsonProperty("Pit_kills_as_beast_2019_summer")]
        public long PitKillsAsBeast2019Summer { get; set; }

        [JsonProperty("Pit_kotl_time_2019_summer")]
        public long PitKotlTime2019Summer { get; set; }

        [JsonProperty("Pit_tdm_red_kills_2019_summer")]
        public long PitTdmRed_Kills2019Summer { get; set; }
    }
    public class PitStats
    {
        [JsonProperty("playtime_minutes")]
        public long PlaytimeMinutes { get; set; }

        [JsonProperty("chat_messages")]
        public long ChatMessages { get; set; }

        [JsonProperty("enderchest_opened")]
        public long EnderchestOpened { get; set; }

        [JsonProperty("joins")]
        public long Joins { get; set; }

        [JsonProperty("left_clicks")]
        public long LeftClicks { get; set; }

        [JsonProperty("gapple_eaten")]
        public long GapplesEaten { get; set; }

        [JsonProperty("fishing_rod_launched")]
        public long FishingRodLaunched { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("melee_damage_dealt")]
        public long MeleeDamageDealt { get; set; }

        [JsonProperty("cash_earned")]
        public long CashEarned { get; set; }

        [JsonProperty("launched_by_launchers")]
        public long LaunchedByLaunchers { get; set; }

        [JsonProperty("arrows_fired")]
        public long ArrowsFired { get; set; }

        [JsonProperty("enchanted_tier2")]
        public long EnchantedTier2 { get; set; }

        [JsonProperty("enchanted_tier1")]
        public long EnchantedTier1 { get; set; }

        [JsonProperty("bow_damage_received")]
        public long BowDamageReceived { get; set; }

        [JsonProperty("enchanted_tier3")]
        public long EnchantedTier3 { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("diamond_items_purchased")]
        public long DiamondItemsPurchased { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("soups_drank")]
        public long SoupsDrank { get; set; }

        [JsonProperty("blocks_broken")]
        public long BlocksBroken { get; set; }

        [JsonProperty("ghead_eaten")]
        public long GheadEaten { get; set; }

        [JsonProperty("sword_hits")]
        public long SwordHits { get; set; }

        [JsonProperty("contracts_completed")]
        public long ContractsCompleted { get; set; }

        [JsonProperty("bow_damage_dealt")]
        public long BowDamageDealt { get; set; }

        [JsonProperty("contracts_started")]
        public long ContractsStarted { get; set; }

        [JsonProperty("damage_received")]
        public long DamageReceived { get; set; }

        [JsonProperty("jumped_longo_pit")]
        public long JumpedlongoPit { get; set; }

        [JsonProperty("melee_damage_received")]
        public long MeleeDamageReceived { get; set; }

        [JsonProperty("arrow_hits")]
        public long ArrowHits { get; set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("lava_bucket_emptied")]
        public long LavaBucketEmptied { get; set; }

        [JsonProperty("max_streak")]
        public long MaxStreak { get; set; }

        [JsonProperty("wheat_farmed")]
        public long WheatFarmed { get; set; }

        [JsonProperty("night_quests_completed")]
        public long NightQuestsCompleted { get; set; }
    }
}