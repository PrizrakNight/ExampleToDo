using ExampleToDo.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Domain.Specific
{
    public class CustomSubtask<TDomainUser> : EntityBase, IDomainNamedEntity, IAccomplishable
        where TDomainUser : IDomainUser
    {
        public int TaskId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Accomplished { get; set; }

        public DateTime? DateOfCompletion { get; set; }

        public CustomTask<TDomainUser> Task { get; set; }
    }
}
