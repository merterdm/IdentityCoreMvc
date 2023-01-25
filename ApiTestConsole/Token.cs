using Newtonsoft.Json;

namespace ApiTestConsole
{
    public class Token
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

    }
}