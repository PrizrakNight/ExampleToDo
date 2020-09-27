using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels
{
    public class NamedIdentifiableModel : IdentifiableModel
    {
        [Required]
        public string Name { get; set; }
    }
}
