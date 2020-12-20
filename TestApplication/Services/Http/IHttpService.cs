using System.Threading;
using System.Threading.Tasks;
using TestApplication.Models.Http;

namespace TestApplication.Services.Http
{
    public interface IHttpService
    {
        Task<HttpResponse<T>> ExecuteAsync<T>(Method method, string url, string content, CancellationToken cancellationToken)
           where T : class;

        Task<HttpResponse<T>> ExecuteAsync<T>(Method method, string url, CancellationToken cancellationToken)
            where T : class;

        Task<HttpResponse> ExecuteAsync(Method method, string url, string content, CancellationToken cancellationToken);

        Task<HttpResponse> ExecuteAsync(Method method, string url, CancellationToken cancellationToken);
    }
}
