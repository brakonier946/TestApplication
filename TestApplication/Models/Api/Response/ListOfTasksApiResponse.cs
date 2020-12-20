using System.Collections.Generic;
using Newtonsoft.Json;

namespace Core.Models.Api.Response
{
    public class ListOfTasksApiResponse
    {
        [JsonProperty("tasks")]
        public List<Task> Tasks { get; set; }

        [JsonProperty("total_task_count")]
        public int TasksTotalCount { get; set; }
    }

    public class Task
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
