using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class HourlyRateMapping
    {
        public static void Configure(this EntityTypeBuilder<HourlyRateEntity> modelBuilder)
        {
            modelBuilder.HasOne(x => x.Currency).WithMany(y => y.HourlyRates).HasForeignKey(x => x.CurrencyId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("HourlyRate");
        }
    }
}
