using ExampleToDo.Application.BusinessModels;
using ExampleToDo.Application.Interfaces.Services.Results;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface ICustomSubtaskService
    {
        Task<IServiceResult> CreateSubtaskAsync(NamedIdentifiableModel customSubtaskModel);
        Task<IServiceResult> UpdateSubtaskAsync(NamedIdentifiableModel customSubtaskModel);
        Task<IServiceResult> DeleteSubtaskAsync(int customSubtaskId);
    }
}
