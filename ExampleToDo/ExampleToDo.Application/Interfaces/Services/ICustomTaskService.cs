using ExampleToDo.Application.BusinessModels;
using ExampleToDo.Application.BusinessModels.Response;
using ExampleToDo.Application.Interfaces.Services.Results;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface ICustomTaskService
    {
        Task<IServiceResult> CreateCustomTaskAsync(CustomTaskModel customTaskModel);
        Task<IServiceResult> UpdateCustomTaskAsync(CustomTaskModel customTaskModel);
        Task<IServiceResult> DeleteCustomTaskAsync(int customTaskId);

        Task<IServiceObjectResult<CustomTaskDto[]>> GetCustomTasksAsync();
    }
}
