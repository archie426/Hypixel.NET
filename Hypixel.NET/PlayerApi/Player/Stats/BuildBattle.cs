using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class BuildBattle
    {
        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("wins_solo_normal")]
        public long WinsSoloNormal { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("total_votes")]
        public long TotalVotes { get; set; }

        [JsonProperty("correct_guesses")]
        public long CorrectGuesses { get; set; }

        [JsonProperty("wins_guess_the_build")]
        public long WinsGuessTheBuild { get; set; }

        [JsonProperty("wins_teams_normal")]
        public long WinsTeamsNormal { get; set; }

        [JsonProperty("new_suit")]
        public string NewSuit { get; set; }

        [JsonProperty("wins_halloween")]
        public long WinsHalloween { get; set; }

        [JsonProperty("wins_solo_pro")]
        public long WinsSoloPro { get; set; }

        [JsonProperty("super_votes")]
        public long SuperVotes { get; set; }

        [JsonProperty("last_purchased_song")]
        public string LastPurchasedSong { get; set; }

        [JsonProperty("music")]
        public bool Music { get; set; }

        [JsonProperty("teams_most_points")]
        public long TeamsMostPoints { get; set; }
    }
}