using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class TimesheetMapping
    {
        public static void Configure(this EntityTypeBuilder<TimesheetEntity> modelBuilder)
        {
            modelBuilder.HasOne(x => x.Contractor).WithMany(y => y.Timesheets).HasForeignKey(x => x.ContractorId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("Timesheet");
        }
    }
}
