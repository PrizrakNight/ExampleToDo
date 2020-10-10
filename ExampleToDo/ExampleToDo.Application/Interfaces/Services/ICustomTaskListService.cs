using ExampleToDo.Application.BusinessModels;
using ExampleToDo.Application.BusinessModels.Response;
using ExampleToDo.Application.Interfaces.Services.Results;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface ICustomTaskListService
    {
        Task<IServiceResult> CreateTaskListAsync(NamedIdentifiableModel customTaskListModel);
        Task<IServiceResult> UpdateTaskListAsync(NamedIdentifiableModel customTaskListModel);
        Task<IServiceResult> DeleteTaskListAsync(int customTaskListId);

        Task<IServiceObjectResult<CustomTaskListDto[]>> GetTaskListsAsync(bool includeTasks);
    }
}
