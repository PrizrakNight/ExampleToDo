using ExampleToDo.Application.Interfaces.Services.Results;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface ICollaborationService
    {
        Task<IServiceResult> RemoveMember(int customTaskListId, int participantId);
        Task<IServiceResult> AssignTaskAsync(int customTaskId, int participantId);
        Task<IServiceResult> RemoveAssigment(int customTaskId);
    }
}
