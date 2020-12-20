using System;
using System.Threading.Tasks;

namespace TestApplication.Managers.Login
{
    public interface ILoginManager
    {
        Task<(bool IsLoggedIn, string message)> AuthorizeAsync(string username, string password);

        Task<bool> LogoutAsync();
    }
}
