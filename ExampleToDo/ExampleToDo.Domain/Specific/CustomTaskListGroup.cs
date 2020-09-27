using ExampleToDo.Domain.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Domain.Specific
{
    public class CustomTaskListGroup<TDomainUser> : EntityBase, IDomainNamedEntity
        where TDomainUser : IDomainUser
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public TDomainUser User { get; set; }

        public ICollection<CustomTaskList<TDomainUser>> CustomTaskLists { get; set; }
    }
}
