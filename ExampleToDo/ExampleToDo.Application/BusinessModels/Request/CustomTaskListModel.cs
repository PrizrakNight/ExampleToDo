using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels.Request
{
    public class CustomTaskListModel : IdentifiableModel
    {
        [Required]
        public string Name { get; set; }

        public int[] CustomTasks { get; set; }
    }
}
