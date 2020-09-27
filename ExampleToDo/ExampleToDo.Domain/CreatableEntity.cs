using ExampleToDo.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Domain
{
    public class CreatableEntity : EntityBase, IDomainNamedEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfCreation { get; set; }

        [Required]
        public DateTime DateOfChange { get; set; }
    }
}
