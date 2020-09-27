using ExampleToDo.Domain.Specific;
using System.Collections.Generic;

namespace ExampleToDo.Domain.Interfaces
{
    public interface IDomainGroupContainer<TDomainUser> : IDomainEntity
        where TDomainUser : IDomainUser
    {
        ICollection<CustomTaskListGroup<TDomainUser>> Groups { get; set; }
    }
}
