using ExampleToDo.Domain.Interfaces;

namespace ExampleToDo.Domain
{
    public abstract class EntityBase : IDomainEntity
    {
        public int Id { get; set; }
    }
}
