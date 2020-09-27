using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleToDo.Application.BusinessModels.Response
{
    public class CustomTaskDto : NamedIdentifiableModel
    {
        public string Description { get; set; }

        public bool Accomplished { get; set; }

        public DateTime? DateOfCompletion { get; set; }
        public DateTime? Reiteration { get; set; }

        public CustomSubtaskDto[] Subtasks { get; set; }
    }
}
