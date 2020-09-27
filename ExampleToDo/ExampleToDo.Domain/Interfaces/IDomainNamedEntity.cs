namespace ExampleToDo.Domain.Interfaces
{
    public interface IDomainNamedEntity : IDomainEntity
    {
        string Name { get; set; }
    }
}
