using Hypixel.NET.PlayerApi;
using Newtonsoft.Json;
using RestSharp;

namespace Hypixel.NET
{
    public class HypixelApi
    {
        private string _apiKey;

        public HypixelApi(string apiKey)
        {
            _apiKey = apiKey;
        }
        public PlayerByUuid GetUserByUuid(string uuid)
        {

            //TODO: add caching

            var client = new RestClient("https://api.hypixel.net/");
            var request = new RestRequest($"player?key={_apiKey}&uuid={uuid}", Method.GET);
            var response = client.Execute(request);

            var responseDeserialized = JsonConvert.DeserializeObject<PlayerByUuid>(response.Content);

            return responseDeserialized;
        }
    }
}
