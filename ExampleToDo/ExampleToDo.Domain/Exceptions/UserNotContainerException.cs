using ExampleToDo.Domain.Interfaces;
using System;

namespace ExampleToDo.Domain.Exceptions
{
    public class UserNotContainerException : Exception
    {
        public readonly IDomainUser User;

        public UserNotContainerException(IDomainUser user, Type containerType)
            : base($"User '{user.GetType().Name}' is not container '{containerType.Name}'")
        {
            User = user;
        }
    }
}
