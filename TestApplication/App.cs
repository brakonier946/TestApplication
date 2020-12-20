using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestApplication.Presentation.Navigation;
using TestApplication.Services.Http;
using TestApplication.Services.Storage;

namespace TestApplication
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
