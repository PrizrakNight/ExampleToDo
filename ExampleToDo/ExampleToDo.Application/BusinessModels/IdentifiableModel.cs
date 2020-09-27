using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels
{
    public class IdentifiableModel
    {
        [Required]
        public int Id { get; set; }
    }
}
