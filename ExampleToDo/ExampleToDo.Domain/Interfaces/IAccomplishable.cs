using System;

namespace ExampleToDo.Domain.Interfaces
{
    public interface IAccomplishable
    {
        bool Accomplished { get; set; }

        DateTime? DateOfCompletion { get; set; }
    }
}
