using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels
{
    public class CustomTaskModel : IdentifiableModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
