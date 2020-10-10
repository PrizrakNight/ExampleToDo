using ExampleToDo.Persistence.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleToDo.Persistence.EFCore.EntityTypeConfigurations
{
    internal class ApplicationIdentityUserConfiguration : IEntityTypeConfiguration<ApplicationIdentityUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationIdentityUser> builder)
        {
            builder.HasMany(aiu => aiu.Groups)
                   .WithOne(g => g.User)
                   .HasForeignKey(g => g.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(aiu => aiu.TaskLists)
                   .WithOne(tl => tl.User)
                   .HasForeignKey(tl => tl.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(aiu => aiu.ReceivedInvitations)
                   .WithOne(i => i.Recipient)
                   .HasForeignKey(i => i.RecipientId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(aiu => aiu.SentInvitations)
                   .WithOne(i => i.Sender)
                   .HasForeignKey(i => i.SenderId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
