using ExampleToDo.Domain.Interfaces;
using System.Collections.Generic;

namespace ExampleToDo.Domain.Specific
{
    public class CustomTaskListGroup<TDomainUser> : EntityBase, IDomainNamedEntity
        where TDomainUser : IDomainUser
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public TDomainUser User { get; set; }

        public ICollection<CustomTaskList<TDomainUser>> CustomTaskLists { get; set; }
    }
}
