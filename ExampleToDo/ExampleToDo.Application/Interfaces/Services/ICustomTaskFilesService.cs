using ExampleToDo.Application.BusinessModels.Request;
using ExampleToDo.Application.BusinessModels.Response;
using ExampleToDo.Application.Interfaces.Services.Results;
using System.IO;
using System.Threading.Tasks;

namespace ExampleToDo.Application.Interfaces.Services
{
    public interface ICustomTaskFilesService
    {
        Task<IServiceResult> AttachFileAsync(CustomTaskFileModel customTaskFileModel);
        Task<IServiceResult> DeleteFileAsync(int customTaskFileId);

        Task<IServiceObjectResult<CustomTaskFileDto[]>> GetTaskFilesAsync(int customTaskId);
        Task<IServiceObjectResult<FileStream>> OpenFileStreamAsync(int customTaskFileId);
    }
}
