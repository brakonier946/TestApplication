using Acr.UserDialogs;
using Core.Managers.Tasks;
using Core.Services.Http.Tasks;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestApplication.Core.Managers.Login;
using TestApplication.Core.Presentation.Navigation;
using TestApplication.Core.Services.Http;
using TestApplication.Core.Services.Http.Login;
using TestApplication.Core.Services.Storage;

namespace TestApplication.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<INavigationManager, NavigationManager>();
            Mvx.IoCProvider.RegisterSingleton(() => UserDialogs.Instance);

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IStorageService, StorageService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IHttpService, HttpService>();

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ITasksService, TasksService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ILoginService, LoginService>();


            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ITasksManager, TasksManager>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ILoginManager, LoginManager>();

            RegisterCustomAppStart<CustomAppStart>();
        }
    }
}
