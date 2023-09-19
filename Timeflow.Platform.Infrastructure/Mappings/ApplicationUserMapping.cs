using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Authentication;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class ApplicationUserMapping
    {
        public static void Configure(this EntityTypeBuilder<ApplicationUser> modelBuilder)
        {
            //modelBuilder.HasMany(x => x.Cars).WithOne(y => y.User).HasForeignKey(z => z.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
