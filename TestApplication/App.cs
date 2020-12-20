using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestApplication.Core.Presentation.Navigation;
using TestApplication.Core.Services.Http;
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

            RegisterCustomAppStart<CustomAppStart>();
        }
    }
}
