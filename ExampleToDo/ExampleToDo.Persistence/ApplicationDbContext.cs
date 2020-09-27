using ExampleToDo.Domain.Specific;
using ExampleToDo.Persistence.EFCore.Entities;
using ExampleToDo.Persistence.EFCore.EntityTypeConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExampleToDo.Persistence.EFCore
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole<int>, int>
    {
        public DbSet<CustomSubtask<ApplicationIdentityUser>> Subtasks { get; set; }
        public DbSet<CustomTask<ApplicationIdentityUser>> Tasks { get; set; }
        public DbSet<CustomTaskList<ApplicationIdentityUser>> TaskLists { get; set; }
        public DbSet<CustomTaskListGroup<ApplicationIdentityUser>> ListGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationIdentityUserConfiguration());
            builder.ApplyConfiguration(new CustomTaskConfiguration());
            builder.ApplyConfiguration(new CustomTaskListConfiguration());
            builder.ApplyConfiguration(new CustomTaskListGroupConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
