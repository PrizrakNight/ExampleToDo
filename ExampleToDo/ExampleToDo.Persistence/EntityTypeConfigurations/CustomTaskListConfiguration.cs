using ExampleToDo.Domain.Specific;
using ExampleToDo.Persistence.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleToDo.Persistence.EFCore.EntityTypeConfigurations
{
    internal class CustomTaskListConfiguration : IEntityTypeConfiguration<CustomTaskList<ApplicationIdentityUser>>
    {
        public void Configure(EntityTypeBuilder<CustomTaskList<ApplicationIdentityUser>> builder)
        {
            builder.HasMany(ctl => ctl.Tasks)
                   .WithOne(ct => ct.CustomTaskList)
                   .HasForeignKey(ct => ct.CustomTaskListId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
