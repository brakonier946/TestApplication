using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Models.Api.Response;
using TestApplication.Core.Common;
using TestApplication.Core.Models.Api.Response;
using TestApplication.Core.Models.Http;
using TestApplication.Core.Services.Http;

namespace Core.Services.Http.Tasks
{
    public class TasksService : ITasksService
    {
        private readonly IHttpService _httpService;

        public TasksService(IHttpService httpService)
        {
            _httpService = httpService;
        }


        public Task<HttpResponse<BaseApiResponse<string>>> CreateTaskAsync(CancellationToken cancellationToken)
        {
            return _httpService.ExecuteAsync<BaseApiResponse<string>>(
                Method.Post,
                Constants.Rest.Tasks.CreateTask,
                Json.Serialize(new int[2]),
                cancellationToken);
        }

        public Task<HttpResponse<BaseApiResponse<string>>> EditTaskAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponse<ListOfTasksApiResponse>> GetListOfTasksAsync(string sortField, string sortDirection, int page, CancellationToken cancellationToken)
        {
            return _httpService.ExecuteAsync<ListOfTasksApiResponse>(
                Method.Get,
                string.Format(Constants.Rest.Tasks.ListOfTasks, sortField, sortDirection, page),
                cancellationToken);
        }
    }
}
