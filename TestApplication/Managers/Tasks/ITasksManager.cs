using System.Threading;
using System.Threading.Tasks;
using Core.Models.Enums;

namespace Core.Managers.Tasks
{
    public interface ITasksManager
    {
        Task GetListOfTasksAsync(SortField sortField, SortDirection sortDirection, CancellationToken cancellationToken);
    }
}
