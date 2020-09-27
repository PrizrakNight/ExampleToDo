using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleToDo.Application.BusinessModels.Response
{
    public class CustomSubtaskDto : NamedIdentifiableModel
    {
        public bool Accomplished { get; set; }

        public DateTime? DateOfCompletion { get; set; }
    }
}
