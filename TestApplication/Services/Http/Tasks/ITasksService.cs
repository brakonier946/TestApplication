using System.Threading;
using System.Threading.Tasks;
using Core.Models.Api.Response;
using TestApplication.Core.Models.Api.Response;
using TestApplication.Core.Models.Http;

namespace Core.Services.Http.Tasks
{
    public interface ITasksService
    {
        Task<HttpResponse<ListOfTasksApiResponse>> GetListOfTasksAsync(string sortField, string sortDirection, int page, CancellationToken cancellationToken);

        Task<HttpResponse<BaseApiResponse<string>>> CreateTaskAsync(CancellationToken cancellationToken);

        Task<HttpResponse<BaseApiResponse<string>>> EditTaskAsync(CancellationToken cancellationToken);
    }
}
