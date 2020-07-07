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

        IFriendsListRequest GetPlayerFriendsByUuid(string uuid);
        IFriendsListRequest GetPlayerFriendsByPlayerName(string playerName);

        IGuildRequest GetGuildByGuildName(string guildName);
        IGuildRequest GetGuildByPlayerName(string playerName);
        IGuildRequest GetGuildByUuid(string uuid);

        BoostersRequest GetBoosters();

        IKeyRequest GetApiKeyInformation(string apiKey);

        WatchdogStatsRequest GetWatchdogStats();

        ILeaderboardsRequest GetLeaderboards();

        IGameCountsRequest GetGameCounts();

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