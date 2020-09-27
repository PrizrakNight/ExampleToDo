using ExampleToDo.Domain.Interfaces;
using ExampleToDo.Domain.Specific;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ExampleToDo.Persistence.EFCore.Entities
{
    public class ApplicationIdentityUser : IdentityUser<int>, IDomainUser,
        IDomainGroupContainer<ApplicationIdentityUser>,
        IDomainTaskListContainer<ApplicationIdentityUser>
    {
        public ICollection<CustomTaskListGroup<ApplicationIdentityUser>> Groups { get; set; }
        public ICollection<CustomTaskList<ApplicationIdentityUser>> TaskLists { get; set; }
    }
}