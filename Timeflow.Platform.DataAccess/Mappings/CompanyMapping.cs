using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.DataAccess.Entities;

namespace Timeflow.Platform.DataAccess.Mappings
{
    public static class CompanyMapping
    {
        public static void Configure(this EntityTypeBuilder<CompanyEntity> modelBuilder)
        {
            //modelBuilder.HasMany(x => x.Cars).WithOne(y => y.User).HasForeignKey(z => z.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.ToTable("Companies");
        }
    }
}
