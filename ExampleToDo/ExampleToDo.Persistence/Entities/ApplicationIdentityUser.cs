using ExampleToDo.Domain;
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
        public ICollection<Invitation<ApplicationIdentityUser>> SentInvitations { get; set; }
        public ICollection<Invitation<ApplicationIdentityUser>> ReceivedInvitations { get; set; }

        public ICollection<CustomTaskListGroup<ApplicationIdentityUser>> Groups { get; set; }
        public ICollection<CustomTaskList<ApplicationIdentityUser>> TaskLists { get; set; }
    }
}