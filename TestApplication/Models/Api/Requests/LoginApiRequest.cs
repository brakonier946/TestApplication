using Newtonsoft.Json;

namespace TestApplication.Models.Api.Requests
{
    public class LoginApiRequest
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public LoginApiRequest(string login, string password)
        {
            Username = login;
            Password = password;
        }
    }
}
