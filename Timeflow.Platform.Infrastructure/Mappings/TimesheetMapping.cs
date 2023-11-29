using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class TimeSheetMapping
    {
        public static void Configure(this EntityTypeBuilder<TimeSheetEntity> modelBuilder)
        {
            modelBuilder.Property(x => x.Notes).HasColumnType("nvarchar").HasMaxLength(200);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.HasOne(x => x.Task).WithMany(y => y.Timesheets).HasForeignKey(x => x.TaskId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Property(x => x.ServiceTypeId).HasColumnType("tinyint").HasConversion(serviceTypeItem => (byte)serviceTypeItem, serviceTypeItem => (ServiceTypeEnum)Enum.Parse(typeof(ServiceTypeEnum), serviceTypeItem.ToString())).IsRequired();
            modelBuilder.ToTable("TimeSheet");
        }
    }
}
