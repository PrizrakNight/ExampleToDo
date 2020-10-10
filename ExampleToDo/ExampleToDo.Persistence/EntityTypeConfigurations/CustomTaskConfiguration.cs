using ExampleToDo.Domain.Specific;
using ExampleToDo.Persistence.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleToDo.Persistence.EFCore.EntityTypeConfigurations
{
    internal class CustomTaskConfiguration : IEntityTypeConfiguration<CustomTask<ApplicationIdentityUser>>
    {
        public void Configure(EntityTypeBuilder<CustomTask<ApplicationIdentityUser>> builder)
        {
            builder.HasMany(ct => ct.Subtasks)
                   .WithOne(s => s.Task)
                   .HasForeignKey(s => s.TaskId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(ct => ct.Files)
                   .WithOne(ctf => ctf.CustomTask)
                   .HasForeignKey(ctf => ctf.CustomTaskId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
