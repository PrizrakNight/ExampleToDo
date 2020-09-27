using ExampleToDo.Domain.Specific;
using System.Collections.Generic;

namespace ExampleToDo.Domain.Interfaces
{
    public interface IDomainTaskListContainer<TDomainUser> : IDomainEntity
        where TDomainUser : IDomainUser
    {
        ICollection<CustomTaskList<TDomainUser>> TaskLists { get; set; }
    }
}
