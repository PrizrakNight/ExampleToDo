using ExampleToDo.Domain.Interfaces;
using System.Collections.Generic;

namespace ExampleToDo.Domain.Specific
{
    public class CustomTaskList<TDomainUser> : CreatableEntity
        where TDomainUser : IDomainUser
    {
        public int UserId { get; set; }
        public int? CustomTaskListGroupId { get; set; }

        public TDomainUser User { get; set; }
        public CustomTaskListGroup<TDomainUser> TaskListGroup { get; set; }

        public ICollection<TDomainUser> Participants { get; set; }
        public ICollection<CustomTask<TDomainUser>> Tasks { get; set; }
    }
}
