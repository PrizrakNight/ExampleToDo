using ExampleToDo.Domain.Interfaces;
using System;

namespace ExampleToDo.Domain
{
    public class Invitation<TDomainUser> : EntityBase
        where TDomainUser : IDomainUser
    {
        public int CustomTaskListId { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }

        public string Message { get; set; }

        public DateTime SentIn { get; set; }

        public TDomainUser Sender { get; set; }
        public TDomainUser Recipient { get; set; }
    }
}
