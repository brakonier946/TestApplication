using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TestApplication.Presentation.Navigation;

namespace TestApplication
{
    public class CustomAppStart : MvxAppStart
    {
        private readonly INavigationManager _navigationManager;

        public CustomAppStart(
            IMvxApplication application,
            IMvxNavigationService mvxNavigationService,
            INavigationManager navigationManager)
            : base(application, mvxNavigationService)
        {
            _navigationManager = navigationManager;
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return _navigationManager.AppStart();
        }
    }
}
