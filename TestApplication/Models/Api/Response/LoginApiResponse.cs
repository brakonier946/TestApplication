﻿using Newtonsoft.Json;

namespace TestApplication.Models.Api.Response
{
    public class LoginApiResponse
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}