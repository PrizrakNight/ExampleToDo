using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels.Request
{
    public class CustomSubtaskModel : IdentifiableModel
    {
        [Required]
        public string Name { get; set; }
    }
}
