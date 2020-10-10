using System.Collections.Generic;

namespace ExampleToDo.Application.Interfaces.Services.Results
{
    public interface IServiceResult
    {
        bool IsSucceed { get; }

        IReadOnlyCollection<string> Errors { get; }
    }
}
