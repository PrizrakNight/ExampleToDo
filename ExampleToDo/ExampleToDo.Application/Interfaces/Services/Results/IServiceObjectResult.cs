namespace ExampleToDo.Application.Interfaces.Services.Results
{
    public interface IServiceObjectResult<TObjectData> : IServiceResult
    {
        TObjectData ObjectData { get; }
    }
}
