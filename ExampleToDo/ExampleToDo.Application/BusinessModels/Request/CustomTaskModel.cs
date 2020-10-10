using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels
{
    public class CustomTaskModel : NamedIdentifiableModel
    {
        [Required]
        public bool Accomplished { get; set; }

        public string Description { get; set; }
    }
}
