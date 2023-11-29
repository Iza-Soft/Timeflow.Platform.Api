using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class ProjectMapping
    {
        public static void Configure(this EntityTypeBuilder<ProjectEntity> modelBuilder)
        {
            //modelBuilder.HasOne(x => x.Customer).WithMany(y => y.Projects).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Property(x => x.Title).HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(200);
            modelBuilder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.ToTable("Project");
        }
    }
}