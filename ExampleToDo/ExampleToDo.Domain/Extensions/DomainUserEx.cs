using ExampleToDo.Domain.Exceptions;
using ExampleToDo.Domain.Interfaces;

namespace ExampleToDo.Domain.Extensions
{
    public static class DomainUserEx
    {
        public static IDomainGroupContainer<TDomainUser> ToGroupContainer<TDomainUser>(this TDomainUser domainUser)
            where TDomainUser : IDomainUser
        {
            if (domainUser is IDomainGroupContainer<TDomainUser> container)
                return container;

            else throw new UserNotContainerException(domainUser, typeof(IDomainGroupContainer<>));
        }

        public static IDomainTaskListContainer<TDomainUser> ToTaskListContainer<TDomainUser>(this TDomainUser domainUser)
            where TDomainUser : IDomainUser
        {
            if (domainUser is IDomainTaskListContainer<TDomainUser> container)
                return container;

            else throw new UserNotContainerException(domainUser, typeof(IDomainTaskListContainer<>));
        }
    }
}
