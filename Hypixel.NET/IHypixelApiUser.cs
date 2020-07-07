using System.Collections.Generic;
using Hypixel.NET.BoosterApi;
using Hypixel.NET.FriendsApi;
using Hypixel.NET.GuildApi;
using Hypixel.NET.KeyApi;
using Hypixel.NET.LeaderboardsApi;
using Hypixel.NET.PlayerApi;
using Hypixel.NET.PlayerApi.Player.GameCounts;
using Hypixel.NET.SkyblockApi;
using Hypixel.NET.SkyblockApi.Bazaar;
using Hypixel.NET.SkyblockApi.News;
using Hypixel.NET.WatchdogStatsApi;

namespace Hypixel.NET
{
    public interface IHypixelApiUser
    {
        bool IsApiKeyValid(string apiKey);

        IPlayerDataRequest GetUserByUuid(string uuid);
        IPlayerDataRequest GetUserByPlayerName(string name);

        GetFriends GetPlayerFriendsByUuid(string uuid);
        GetFriends GetPlayerFriendsByPlayerName(string playerName);

        GuildRequest GetGuildByGuildName(string guildName);
        GuildRequest GetGuildByPlayerName(string playerName);
        GuildRequest GetGuildByUuid(string uuid);

        GetBoosters GetBoosters();

        IKeyRequest GetApiKeyInformation(string apiKey);

        GetWatchdogStats GetWatchdogStats();

        LeaderboardsRequest GetLeaderboards();

        GetGameCounts GetGameCounts();

        GetSkyBlockProfile GetSkyblockProfileByProfileId(string skyblockProfileId);
        List<GetSkyBlockProfile> GetSkyblockProfilesByName(string username);
        GetAuctionPage GetAuctionPage(int auctionPage);
        AuctionsByPlayer GetAuctionsByPlayerUuid(string uuid);
        AuctionsByPlayer GetAuctionsByPlayerName(string name);
        AuctionsByProfile GetAuctionsByProfileId(string id);
        AuctionByAuctionId GetAuctionByAuctionId(string id);

        GetNews GetNews();

        GetBazaarProducts GetBazaarProducts();
        
    }
}