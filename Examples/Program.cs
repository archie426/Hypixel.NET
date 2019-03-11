using System;
using Hypixel.NET;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var hypixel = new HypixelApi("YOUR API KEY");
            var req = hypixel.GetUserByUuid("YOUR UUID");
            Console.WriteLine(req.Player.Stats.SkyWars.KillStreak);
        }

    }
}
