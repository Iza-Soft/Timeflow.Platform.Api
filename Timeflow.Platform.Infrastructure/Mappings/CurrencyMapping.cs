using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;


namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class CurrencyMapping
    {
        public static void Configure(this EntityTypeBuilder<CurrencyEntity> modelBuilder)
        {
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("Currency");
        }
    }
}
