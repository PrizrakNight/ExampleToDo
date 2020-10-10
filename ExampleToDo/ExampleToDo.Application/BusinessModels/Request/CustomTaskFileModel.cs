using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels.Request
{
    public class CustomTaskFileModel
    {
        [Required]
        public int CustomTaskId { get; set; }

        [Required]
        public IFormFile File { get; set; }
    }
}
