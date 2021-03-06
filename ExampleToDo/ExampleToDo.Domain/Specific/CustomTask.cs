﻿using ExampleToDo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExampleToDo.Domain.Specific
{
    public class CustomTask<TDomainUser> : CreatableEntity, IAccomplishable
        where TDomainUser : IDomainUser
    {
        public int? AssignedUserId { get; set; }
        public int? CustomTaskListId { get; set; }

        public string Description { get; set; }

        [Required]
        public bool Accomplished { get; set; }

        public DateTime? DateOfCompletion { get; set; }
        public DateTime? Reiteration { get; set; }

        public TDomainUser Assigned { get; set; }
        public CustomTaskList<TDomainUser> CustomTaskList { get; set; }

        public ICollection<CustomSubtask<TDomainUser>> Subtasks { get; set; }
        public ICollection<CustomTaskFile<TDomainUser>> Files { get; set; }
    }
}
