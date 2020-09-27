﻿using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Application.BusinessModels
{
    public class CustomTaskModel : NamedIdentifiableModel
    {
        public string Description { get; set; }
    }
}
