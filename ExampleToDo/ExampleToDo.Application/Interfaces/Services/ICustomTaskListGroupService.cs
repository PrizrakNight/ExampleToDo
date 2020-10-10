using ExampleToDo.Application.BusinessModels;
using ExampleToDo.Application.BusinessModels.Response;
using ExampleToDo.Application.Interfaces.Services.Results;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface ICustomTaskListGroupService
    {
        Task<IServiceResult> CreateGroupAsync(NamedIdentifiableModel customTaskListGroupModel);
        Task<IServiceResult> UpdateGroupAsync(NamedIdentifiableModel customTaskListGroupModel);
        Task<IServiceResult> DeleteGroupAsync(int customTaskListGroupId);

        Task<IServiceObjectResult<CustomTaskListGroupDto[]>> GetGroupsAsync(bool includeTaskLists);
    }
}
