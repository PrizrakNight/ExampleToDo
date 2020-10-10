using ExampleToDo.Domain.Interfaces;

namespace ExampleToDo.Application.Interfaces
{
    public interface IApplicationUserProvider
    {
        IDomainUser CurrentUser { get; }

        int CurrentUserId { get; }
    }
}
