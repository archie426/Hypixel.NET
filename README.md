Hypixel.NET C# Wrapper
======
This is my C# implmentation of the Hypixel API

### NuGet Package
The NuGet package can be found at https://www.nuget.org/packages/Hypixel.NET/

### Examples

Here are some examples from the Example project

```C#
using System;
using Hypixel.NET;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var hypixel = new HypixelApi("YOUR API KEY", 300);

            var playerRequest = hypixel.GetUserByPlayerName("barrows");
            Console.WriteLine(playerRequest.Player.Stats.SkyWars.Kills);

            var playerUuidRequest = hypixel.GetUserByUuid("4c38f0a6-a36f-4f06-985c-7851b3853ccb");
            Console.WriteLine(playerUuidRequest.Player.Stats.SkyWars.ArrowsShot);

            var guildByGuildName = hypixel.GetGuildByGuildName("Develop");
            Console.WriteLine(guildByGuildName.Guild.Coins);

            var guildByPlayerName = hypixel.GetGuildByPlayerName("barrows");
            Console.WriteLine(guildByPlayerName.Guild.Exp);

            var guildByUuid = hypixel.GetGuildByUuid("4c38f0a6-a36f-4f06-985c-7851b3853ccb");
            Console.WriteLine(guildByUuid.Guild.Name);

            var getFriendsByUuid = hypixel.GetPlayerFriendsByUuid("4c38f0a6-a36f-4f06-985c-7851b3853ccb");
            Console.WriteLine(getFriendsByUuid.Records.Count);

            var getFriendsByPlayerName = hypixel.GetPlayerFriendsByPlayerName("barrows");
            Console.WriteLine(getFriendsByPlayerName.Records.Count);

            var getBoosters = hypixel.GetBoosters();
            Console.WriteLine(getBoosters.Boosters.Count);

            var watchdogStats = hypixel.GetWatchdogStats();
            Console.WriteLine(watchdogStats.WatchdogTotal);

            var getApiKey = hypixel.GetApiKeyInformation("YOUR API KEY");
            Console.WriteLine(getApiKey.Record.TotalQueries);

            var getLeaderboards = hypixel.GetLeaderboards();
            Console.WriteLine(getLeaderboards.Leaderboards.SkyWars.Count);

            var getGameCounts = hypixel.GetGameCounts();
            Console.WriteLine(getGameCounts.Games.Limbo.Players);

            var getSkyblockProfile = hypixel.GetSkyblockProfileByProfileId("4c38f0a6a36f4f06985c7851b3853ccb");
            foreach (var member in getSkyblockProfile.Profile.Members)
            {
                Console.WriteLine(member.Value.PlayerStats.AuctionsBids);
            }

            var getProfilesByName = hypixel.GetSkyblockProfilesByName("barrows");
            foreach (var profile in getProfilesByName)
            {
                Console.WriteLine(profile.Profile.ProfileId);
            }
        }
    }
}
```
