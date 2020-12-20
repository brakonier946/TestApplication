using System.Threading.Tasks;
using MvvmCross.Navigation;
using TestApplication.Core.Presentation.ViewModels.Base;
using TestApplication.Core.Presentation.ViewModels.Login;
using TestApplication.Core.Presentation.ViewModels.Tasks;

namespace TestApplication.Core.Presentation.Navigation
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
            return _mvxNavigationService.Navigate<LoginViewModel>();
        }

        public Task ShowTasksView()
        {
            return _mvxNavigationService.Navigate<TasksViewModel>();
        }

        public Task<bool> CloseView(BasePageViewModel viewModel)
        {
            return _mvxNavigationService.Close(viewModel);
        }
    }
}
