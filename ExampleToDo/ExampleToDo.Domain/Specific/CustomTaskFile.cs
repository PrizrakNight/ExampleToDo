using ExampleToDo.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Domain.Specific
{
    public class CustomTaskFile<TDomainUser> : EntityBase
        where TDomainUser : IDomainUser
    {
        public int CustomTaskId { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public string MimeType { get; set; }

        public CustomTask<TDomainUser> CustomTask { get; set; }
    }
}
