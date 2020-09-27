using ExampleToDo.Domain.Specific;
using ExampleToDo.Persistence.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleToDo.Persistence.EFCore.EntityTypeConfigurations
{
    internal class CustomTaskListGroupConfiguration : IEntityTypeConfiguration<CustomTaskListGroup<ApplicationIdentityUser>>
    {
        public void Configure(EntityTypeBuilder<CustomTaskListGroup<ApplicationIdentityUser>> builder)
        {
            builder.HasMany(ctlg => ctlg.CustomTaskLists)
                   .WithOne(ctl => ctl.TaskListGroup)
                   .HasForeignKey(ctl => ctl.CustomTaskListGroupId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
