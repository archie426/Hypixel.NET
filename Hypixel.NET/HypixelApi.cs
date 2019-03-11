using System;
using System.Timers;
using Hypixel.NET.PlayerApi;
using Newtonsoft.Json;
using RestSharp;

namespace Hypixel.NET
{
    public class HypixelApi
    {
        private readonly string _apiKey;
        private static int _apiRequests;

        public HypixelApi(string apiKey)
        {
            _apiKey = apiKey;
            var apiResetTimer = new Timer(60000);
            apiResetTimer.Elapsed += ResetApiLimit;
        }

        private void ResetApiLimit(object sender, ElapsedEventArgs e)
        {
            _apiRequests = 0;
        }

        public PlayerByUuid GetUserByUuid(string uuid)
        {
            ApplicationException hypixelException;
            //TODO: add caching
            //Check if cached

            //Rate limit check
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"player?key={_apiKey}&uuid={uuid}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<PlayerByUuid>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful && responseDeserialized.Player != null)
            {
                _apiRequests = _apiRequests + 1;
                return responseDeserialized;
            }

            //Hypixel API returns success at true though the player is null
            if (responseDeserialized.Player == null && responseDeserialized.WasSuccessful)
            {
                const string playerNotFound = "Invalid UUID! Please double check your UUID";
                hypixelException = new ApplicationException(playerNotFound, response.ErrorException);
                throw hypixelException;
            }

            var message = $"{responseDeserialized.Cause} Please double check your request information";
            hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public PlayerByPlayerName GetUserByPlayerName(string name)
        {
            //TODO: add caching

            //Check rate limit
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"player?key={_apiKey}&name={name}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<PlayerByPlayerName>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful && responseDeserialized.Player != null)
            {
                _apiRequests = _apiRequests + 1;
                return responseDeserialized;
            }

            ApplicationException hypixelException;

            //Hypixel API returns success at true though the player is null
            if (responseDeserialized.Player == null && responseDeserialized.WasSuccessful)
            {
                const string playerNotFound = "Invalid player name! Please double check your player name";
                hypixelException = new ApplicationException(playerNotFound, response.ErrorException);
                throw hypixelException;
            }

            var message = $"{responseDeserialized.Cause} Please double check your request information";
            hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public void RateLimitCheck()
        {
            if (_apiRequests != 120)
            {
                return;
            }
            const string rateLimitHit = "Rate limit hit!";
            var hypixelRateLimitException = new ApplicationException(rateLimitHit);
            throw hypixelRateLimitException;
        }
    }
}
