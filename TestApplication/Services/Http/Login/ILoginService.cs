using System.Threading;
using System.Threading.Tasks;
using TestApplication.Core.Models.Api.Response;
using TestApplication.Core.Models.Http;
using TestApplication.Models.Api.Requests;

namespace TestApplication.Core.Services.Http.Login
{
    public interface ILoginService
    {
        Task<HttpResponse<BaseApiResponse<LoginApiResponse>>> AuthorizeAsync(LoginApiRequest loginApiRequest, CancellationToken cancellationToken);

        Task<HttpResponse> LogoutAsync(CancellationToken cancellationToken);
    }
}
