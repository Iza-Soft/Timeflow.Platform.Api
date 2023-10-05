using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class HourlyRateMapping
    {
        public static void Configure(this EntityTypeBuilder<HourlyRateEntity> modelBuilder)
        {
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("HourlyRate");
        }
    }
}
