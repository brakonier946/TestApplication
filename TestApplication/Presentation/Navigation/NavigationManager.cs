using System.Threading.Tasks;
using MvvmCross.Navigation;
using TestApplication.Presentation.ViewModels.Base;

namespace TestApplication.Presentation.Navigation
{
    public class NavigationManager : INavigationManager
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public NavigationManager(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }

        public Task AppStart()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CloseView(BasePageViewModel viewModel)
        {
            return _mvxNavigationService.Close(viewModel);
        }
    }
}
