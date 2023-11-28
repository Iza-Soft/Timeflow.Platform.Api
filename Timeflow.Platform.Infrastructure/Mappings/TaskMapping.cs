using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class TaskMapping
    {
        public static void Configure(this EntityTypeBuilder<TaskEntity> modelBuilder)
        {
            modelBuilder.Property(x => x.Title).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(200);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Property(x => x.PaymentAmount).HasPrecision(18, 2);
            modelBuilder.Property(x => x.PaymentTypeId).HasColumnType("tinyint").HasConversion(paymentTypeItem => (byte)paymentTypeItem, paymentTypeItem => (PaymentTypeEnum)Enum.Parse(typeof(PaymentTypeEnum), paymentTypeItem.ToString())).IsRequired();
            modelBuilder.Property(x => x.ServiceTypeId).HasColumnType("tinyint").HasConversion(serviceTypeItem => (byte)serviceTypeItem, serviceTypeItem => (ServiceTypeEnum)Enum.Parse(typeof(ServiceTypeEnum), serviceTypeItem.ToString())).IsRequired();
            modelBuilder.HasOne(x => x.Project).WithMany(y => y.Tasks).HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.ToTable("Task");
        }
    }
}
