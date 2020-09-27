using ExampleToDo.Domain.Interfaces;
using System;

namespace ExampleToDo.Domain.Specific
{
    public class CustomSubtask<TDomainUser> : EntityBase, IDomainNamedEntity, IAccomplishable
        where TDomainUser : IDomainUser
    {
        public int TaskId { get; set; }

        public string Name { get; set; }

        public bool Accomplished { get; set; }

        public DateTime DateOfCompletion { get; set; }

        public CustomTask<TDomainUser> Task { get; set; }
    }
}
