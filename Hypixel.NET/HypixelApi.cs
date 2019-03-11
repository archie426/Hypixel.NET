using System;
using System.Runtime.Caching;
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
        private readonly MemoryCache _apiMemoryCache = MemoryCache.Default;

        public HypixelApi(string apiKey)
        {
            _apiKey = apiKey;
            var apiResetTimer = new Timer(60000); //Hypixel API only allows 120 requests per 60s
            apiResetTimer.Elapsed += ResetApiLimit;
        }

        private void AddItemToCache(string itemType, string apiResponse)
        {
            var cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(10),
            };

            _apiMemoryCache.Add(itemType, apiResponse, cacheItemPolicy);
        }

        private void ResetApiLimit(object sender, ElapsedEventArgs e)
        {
            _apiRequests = 0;
        }

        public PlayerByUuid GetUserByUuid(string uuid)
        {
            ApplicationException hypixelException;

            //Check if cached. If so deserialize and return
            if (_apiMemoryCache.Contains(uuid))
            {
                var getCacheItem = _apiMemoryCache.GetCacheItem(uuid);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<PlayerByUuid>(getCacheItem.Value.ToString());
                    deserializedResponseCache.FromCache = true;
                    return deserializedResponseCache;
                }
            }

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
                AddItemToCache(uuid, response.Content);
                responseDeserialized.FromCache = false;
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
            //Check cache
            if (_apiMemoryCache.Contains(name))
            {
                var getCacheItem = _apiMemoryCache.GetCacheItem(name);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<PlayerByPlayerName>(getCacheItem.Value.ToString());
                    deserializedResponseCache.FromCache = true;
                    return deserializedResponseCache;
                }
            }

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
                AddItemToCache(name, response.Content);
                responseDeserialized.FromCache = false;
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
