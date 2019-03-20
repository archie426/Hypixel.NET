using System;
using System.Runtime.Caching;
using System.Timers;
using Hypixel.NET.BoosterApi;
using Hypixel.NET.FriendsApi;
using Hypixel.NET.GuildApi;
using Hypixel.NET.KeyApi;
using Hypixel.NET.LeaderboardsApi;
using Hypixel.NET.PlayerApi;
using Hypixel.NET.WatchdogStatsApi;
using Newtonsoft.Json;
using RestSharp;


namespace Hypixel.NET
{
    public class HypixelApi
    {
        private readonly string _apiKey;
        private readonly int _cacheStoreTime;
        private static int _apiRequests;
        private static readonly MemoryCache ApiMemoryCache = MemoryCache.Default;

        public HypixelApi(string apiKey, int cacheTimeInSeconds)
        {
            _apiKey = apiKey;
            _cacheStoreTime = cacheTimeInSeconds;
            var apiResetTimer = new Timer(60000); //Hypixel API only allows 120 requests per 60s
            apiResetTimer.Elapsed += ResetApiLimit;
        }

        private void AddItemToCache(string itemType, string apiResponse)
        {
            var cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(_cacheStoreTime),
            };

            ApiMemoryCache.Add(itemType, apiResponse, cacheItemPolicy);
        }

        private void ResetApiLimit(object sender, ElapsedEventArgs e)
        {
            _apiRequests = 0;
        }

        public GetPlayerData GetUserByUuid(string uuid)
        {
            ApplicationException hypixelException;

            //Multiple requests use uuids so append the type to the uuid
            var cacheUuid = uuid + "Type:PlayerData";

            //Check if cached. If so deserialize and return
            if (ApiMemoryCache.Contains(cacheUuid))
            {
                var getCacheItem = ApiMemoryCache.GetCacheItem(cacheUuid);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<GetPlayerData>(getCacheItem.Value.ToString().Replace(".0", ""));
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
            var responseDeserialized = JsonConvert.DeserializeObject<GetPlayerData>(response.Content.Replace(".0", ""));
            
            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful && responseDeserialized.Player != null)
            {
                _apiRequests = _apiRequests + 1;
                AddItemToCache(cacheUuid, response.Content);
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

        public GetPlayerData GetUserByPlayerName(string name)
        {
            //Check cache
            if (ApiMemoryCache.Contains(name))
            {
                var getCacheItem = ApiMemoryCache.GetCacheItem(name);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<GetPlayerData>(getCacheItem.Value.ToString().Replace(".0", ""));
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
            var responseDeserialized = JsonConvert.DeserializeObject<GetPlayerData>(response.Content.Replace(".0", ""));

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

        public GetFriends GetPlayerFriendsByUuid(string uuid)
        {
            var cacheUuid = uuid + "Type:Friends";

            //Check if cached. If so deserialize and return
            if (ApiMemoryCache.Contains(cacheUuid))
            {
                var getCacheItem = ApiMemoryCache.GetCacheItem(cacheUuid);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<GetFriends>(getCacheItem.Value.ToString());
                    deserializedResponseCache.FromCache = true;
                    return deserializedResponseCache;
                }
            }

            //Rate limit check
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"friends?key={_apiKey}&uuid={uuid}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetFriends>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                AddItemToCache(cacheUuid, response.Content);
                responseDeserialized.FromCache = false;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public GetFriends GetPlayerFriendsByPlayerName(string playerName)
        {
            var playerUuid = GetUuidFromPlayerName(playerName);
            return GetPlayerFriendsByUuid(playerUuid);
        }

        public GetGuild GetGuildByGuildName(string guildName)
        {
            var cacheGuild = guildName + "Type:GuildName";

            //Check if cached. If so deserialize and return
            if (ApiMemoryCache.Contains(cacheGuild))
            {
                var getCacheItem = ApiMemoryCache.GetCacheItem(cacheGuild);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<GetGuild>(getCacheItem.Value.ToString());
                    deserializedResponseCache.FromCache = true;
                    return deserializedResponseCache;
                }
            }

            //Rate limit check
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"guild?key={_apiKey}&name={guildName}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetGuild>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                AddItemToCache(cacheGuild, response.Content);
                responseDeserialized.FromCache = false;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public GetGuild GetGuildByPlayerName(string playerName)
        {
            //convert the player name into a uuid - Hypixel doesn't allow guild requests by player names
            var playerUuid = GetUuidFromPlayerName(playerName);

            //use the get guild by uuid 
            return GetGuildByUuid(playerUuid);
        }

        public GetGuild GetGuildByUuid(string uuid)
        {
            var cacheGuild = uuid + "Type:GuildPlayerUuid";

            //Check if cached. If so deserialize and return
            if (ApiMemoryCache.Contains(cacheGuild))
            {
                var getCacheItem = ApiMemoryCache.GetCacheItem(cacheGuild);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    var deserializedResponseCache = JsonConvert.DeserializeObject<GetGuild>(getCacheItem.Value.ToString());
                    deserializedResponseCache.FromCache = true;
                    return deserializedResponseCache;
                }
            }

            //Rate limit check
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"guild?key={_apiKey}&player={uuid}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetGuild>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                AddItemToCache(cacheGuild, response.Content);
                responseDeserialized.FromCache = false;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public GetBoosters GetBoosters()
        {
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"boosters?key={_apiKey}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetBoosters>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public GetKey GetApiKeyInformation(string apiKey)
        {
            RateLimitCheck();
            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"key?key={_apiKey}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetKey>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public GetWatchdogStats GetWatchdogStats()
        {
            RateLimitCheck();
            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"watchdogstats?key={_apiKey}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetWatchdogStats>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        public GetLeaderboards GetLeaderboards()
        {
            RateLimitCheck();
            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"leaderboards?key={_apiKey}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            var responseDeserialized = JsonConvert.DeserializeObject<GetLeaderboards>(response.Content);

            //Verify that the request was successful
            if (responseDeserialized.WasSuccessful)
            {
                _apiRequests = _apiRequests + 1;
                return responseDeserialized;
            }

            //If the response wasn't successful, an exception will be thrown
            var message = $"{responseDeserialized.Cause} Please double check your request information";
            var hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

        private static void RateLimitCheck()
        {
            if (_apiRequests != 120)
            {
                return;
            }
            const string rateLimitHit = "Rate limit hit!";
            var hypixelRateLimitException = new ApplicationException(rateLimitHit);
            throw hypixelRateLimitException;
        }

        private string GetUuidFromPlayerName(string playerName)
        {
            ApplicationException hypixelException;

            var cacheName = playerName + "Type:PlayerData";

            //Check if cached. If so deserialize and return
            if (ApiMemoryCache.Contains(playerName))
            {
                var getCacheItem = ApiMemoryCache.GetCacheItem(cacheName);

                //Verify that this isn't null - if is then will do API request as normal
                if (getCacheItem != null)
                {
                    dynamic deserializedResponseCache = JsonConvert.DeserializeObject(getCacheItem.Value.ToString());
                    return deserializedResponseCache.player.uuid;
                }
            }

            //Rate limit check
            RateLimitCheck();

            //Create the request
            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"player?key={_apiKey}&name={playerName}", Method.GET);

            //Get the response and Deserialize
            var response = client.Execute(request);
            dynamic responseDeserialized = JsonConvert.DeserializeObject(response.Content);

            //Verify that the request was successful
            if ((bool)responseDeserialized.success && responseDeserialized.player != null)
            {
                _apiRequests = _apiRequests + 1;
                AddItemToCache(cacheName, response.Content);
                responseDeserialized.FromCache = false;
                return responseDeserialized.player.uuid;
            }

            //Hypixel API returns success at true though the player is null
            if (responseDeserialized.player == null && responseDeserialized.success)
            {
                const string playerNotFound = "Invalid UUID! Please double check your UUID";
                hypixelException = new ApplicationException(playerNotFound, response.ErrorException);
                throw hypixelException;
            }

            var message = $"{responseDeserialized.cause} Please double check your request information";
            hypixelException = new ApplicationException(message, response.ErrorException);
            throw hypixelException;
        }

    }
}
