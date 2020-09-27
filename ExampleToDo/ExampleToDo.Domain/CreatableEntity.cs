using ExampleToDo.Domain.Interfaces;
using System;

namespace ExampleToDo.Domain
{
    public class CreatableEntity : EntityBase, IDomainNamedEntity
    {
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfChange { get; set; }
    }
}
