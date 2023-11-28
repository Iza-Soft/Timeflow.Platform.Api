using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class PaymentTypeMapping
    {
        public static void Configure(this EntityTypeBuilder<PaymentTypeEntity> modelBuilder)
        {
            modelBuilder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(20);
            modelBuilder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(200);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("PaymentType");
        }
    }
}
