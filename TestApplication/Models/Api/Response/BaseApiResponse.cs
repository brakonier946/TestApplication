using System;
using Newtonsoft.Json;

namespace TestApplication.Models.Api.Response
{
    public class BaseApiResponse<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public T Message { get; set; }
    }
}
