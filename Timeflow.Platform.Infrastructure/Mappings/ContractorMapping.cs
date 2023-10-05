using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class ContractorMapping
    {
        public static void Configure(this EntityTypeBuilder<ContractorEntity> modelBuilder)
        {
            //modelBuilder.HasMany(x => x.Cars).WithOne(y => y.User).HasForeignKey(z => z.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("Contractors");
        }
    }
}
