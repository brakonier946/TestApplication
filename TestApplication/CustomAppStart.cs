using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TestApplication.Core.Presentation.Navigation;

namespace TestApplication.Core
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
