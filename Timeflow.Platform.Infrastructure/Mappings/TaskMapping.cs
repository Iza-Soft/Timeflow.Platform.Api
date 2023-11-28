using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;

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
            modelBuilder.HasOne(x => x.PaymentType).WithMany(y => y.Tasks).HasForeignKey(x => x.PaymentTypeId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.HasOne(x => x.Project).WithMany(y => y.Tasks).HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.HasOne(x => x.ServiceType).WithMany(y => y.Tasks).HasForeignKey(x => x.ServiceTypeId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.ToTable("Task");
        }
    }
}
