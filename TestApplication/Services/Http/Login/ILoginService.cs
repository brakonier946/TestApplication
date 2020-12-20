using System.Threading;
using System.Threading.Tasks;
using TestApplication.Models.Api.Requests;
using TestApplication.Models.Api.Response;
using TestApplication.Models.Http;

namespace TestApplication.Services.Http.Login
{
    public interface ILoginService
    {
        Task<HttpResponse<BaseApiResponse<LoginApiResponse>>> AuthorizeAsync(LoginApiRequest loginApiRequest, CancellationToken cancellationToken);

        Task<HttpResponse> LogoutAsync(CancellationToken cancellationToken);
    }
}
