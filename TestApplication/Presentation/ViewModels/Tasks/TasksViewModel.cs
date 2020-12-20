using System.Threading;
using System.Threading.Tasks;
using Core.Managers.Tasks;
using Core.Models.Enums;
using MvvmCross.Commands;
using TestApplication.Core.Presentation.ViewModels.Base;

namespace TestApplication.Core.Presentation.ViewModels.Tasks
{
    public class TasksViewModel : BasePageViewModel
    {
        private readonly ITasksManager _tasksManager;

        public IMvxAsyncCommand LoadDataCommand { get; }

        public TasksViewModel(ITasksManager tasksManager)
        {
            _tasksManager = tasksManager;

            LoadDataCommand = new MvxAsyncCommand(OnLoadDataAsync);
        }

        public override Task Initialize()
        {
            return LoadDataCommand.ExecuteAsync();
        }

        private async Task OnLoadDataAsync()
        {
            await _tasksManager.GetListOfTasksAsync(SortField.Id, SortDirection.Asc, CancellationToken.None);
        }
    }
}
