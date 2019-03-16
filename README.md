Hypixel.NET C# Wrapper
======
This is my C# implmentation of the Hypixel API

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
            var hypixel = new HypixelApi("YOUR API KEY");

            var playerRequest = hypixel.GetUserByPlayerName("barrows");
            Console.WriteLine(playerRequest.Player.Stats.SkyWars.Kills);

            var playerUuidRequest = hypixel.GetUserByUuid("4c38f0a6-a36f-4f06-985c-7851b3853ccb");
            Console.WriteLine(playerUuidRequest.Player.Stats.SkyWars.ArrowsShot);

            var guildByGuildName = hypixel.GetGuildByGuildName("The Scrobobboplers");
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
        }
    }
}
```
