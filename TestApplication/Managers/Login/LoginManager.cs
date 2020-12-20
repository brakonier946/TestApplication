using System;
using System.Threading;
using System.Threading.Tasks;
using TestApplication.Core.Services.Http.Login;
using TestApplication.Models.Api.Requests;

namespace TestApplication.Core.Managers.Login
{
    public class LoginManager : BaseManager, ILoginManager
    {
        private readonly ILoginService _loginService;

        public LoginManager(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<(bool IsLoggedIn, string message)> AuthorizeAsync(string username, string password)
        {
            var model = new LoginApiRequest(username, password);
            var response = await _loginService.AuthorizeAsync(model, CancellationToken.None);
            if (response.IsSuccessful)
            {
                return (
                    string.IsNullOrWhiteSpace(response.Data.Message.Password) && string.IsNullOrWhiteSpace(response.Data.Message.Username),
                    string.Concat(response.Data.Message.Password, Environment.NewLine, response.Data.Message.Username));
            }

            return (false, "Error at server");
        }

        public async Task<bool> LogoutAsync()
        {
            var response = await _loginService.LogoutAsync(CancellationToken.None);
            return response.IsSuccessful;
        }
    }
}
