using System.Threading;
using System.Threading.Tasks;
using Core.Models.Enums;
using Core.Services.Http.Tasks;
using TestApplication.Core.Managers;

namespace Core.Managers.Tasks
{
    public class TasksManager : BaseManager, ITasksManager
    {
        private readonly ITasksService _tasksService;

        private int _page;
        private int _tasksTotalCount;

        public TasksManager(ITasksService tasksService)
        {
            _tasksService = tasksService;
            _page = 0;
        }

        public async Task GetListOfTasksAsync(SortField sortField, SortDirection sortDirection, CancellationToken cancellationToken)
        {
            var result = await _tasksService.GetListOfTasksAsync(
                sortField.ToString().ToLower(),
                sortDirection.ToString().ToLower(),
                _page++,
                cancellationToken);

            if (result.Data == null)
            {
                return;
            }

            _tasksTotalCount = result.Data.TasksTotalCount;
            var d = result.Data.Tasks;
        }
    }
}
