using System;
using System.Threading;
using System.Threading.Tasks;
using TestApplication.Core.Common;
using TestApplication.Core.Models.Api.Response;
using TestApplication.Core.Models.Http;
using TestApplication.Models.Api.Requests;

namespace TestApplication.Core.Services.Http.Login
{
    public class LoginService : ILoginService
    {
        private readonly IHttpService _httpService;

        public LoginService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<HttpResponse<BaseApiResponse<LoginApiResponse>>> AuthorizeAsync(LoginApiRequest loginApiRequest, CancellationToken cancellationToken)
        {
            return _httpService.ExecuteAsync<BaseApiResponse<LoginApiResponse>>(
                Method.Post,
                Constants.Rest.Login.Auth,
                Json.Serialize(loginApiRequest),
                cancellationToken);
        }

        public Task<HttpResponse> LogoutAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
