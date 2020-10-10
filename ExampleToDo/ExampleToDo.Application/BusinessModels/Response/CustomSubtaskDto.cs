using System;

namespace ExampleToDo.Application.BusinessModels.Response
{
    public class CustomSubtaskDto : NamedIdentifiableModel
    {
        public bool Accomplished { get; set; }

        public DateTime? DateOfCompletion { get; set; }
    }
}
