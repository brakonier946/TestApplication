using System.Threading.Tasks;
using TestApplication.Presentation.ViewModels.Base;

namespace TestApplication.Presentation.Navigation
{
    public interface INavigationManager
    {
        Task AppStart();

        Task<bool> CloseView(BasePageViewModel viewModel);
    }
}
