using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels
{
    public abstract class IdentifiableModel
    {
        [Required]
        public int Id { get; set; }
    }
}
