using ExampleToDo.Application.BusinessModels.Response;
using ExampleToDo.Application.Interfaces.Services.Results;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface IInvitationService
    {
        Task<IServiceResult> InviteUserAsync(int recipientId, int customTaskListId);
        Task<IServiceResult> FlagInvitationAsync(bool accept);

        Task<IServiceObjectResult<InvitationDto[]>> GetReceivedInvitationsAsync();
        Task<IServiceObjectResult<InvitationDto[]>> GetSentInvitationsAsync();
    }
}
