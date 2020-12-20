using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Commands;
using TestApplication.Core.Managers.Login;
using TestApplication.Core.Presentation.ViewModels.Base;

namespace TestApplication.Core.Presentation.ViewModels.Login
{
    public class LoginViewModel : BasePageViewModel
    {
        private readonly ILoginManager _loginManager;
        private readonly IUserDialogs _userDialogs;

        private string _login = "admin";
        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        private string _password = "123";
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public IMvxAsyncCommand LoginCommand { get; }

        public LoginViewModel(
            IUserDialogs userDialogs,
            ILoginManager loginManager)
        {
            _userDialogs = userDialogs;
            _loginManager = loginManager;

            LoginCommand = new MvxAsyncCommand(OnLoginAsync);
        }

        private async Task OnLoginAsync()
        {
            using (_userDialogs.Loading())
            {
                var result = await _loginManager.AuthorizeAsync(Login, Password);
            }
        }
    }
}
