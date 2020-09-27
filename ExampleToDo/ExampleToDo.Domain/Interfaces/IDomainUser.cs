namespace ExampleToDo.Domain.Interfaces
{
    public interface IDomainUser : IDomainEntity
    {
        string Email { get; set; }
        string UserName { get; set; }
        string PasswordHash { get; set; }
    }
}
