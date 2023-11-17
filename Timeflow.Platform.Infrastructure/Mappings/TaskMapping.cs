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
            modelBuilder.Property(x => x.Notes).HasColumnType("nvarchar").HasMaxLength(200);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.HasOne(x => x.Project).WithMany(y => y.Tasks).HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.ToTable("Tasks");
        }
    }
}
