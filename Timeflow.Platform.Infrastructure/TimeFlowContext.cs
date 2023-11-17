using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Authentication;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Mappings;

namespace Timeflow.Platform.Infrastructure
{
    /*https://stackoverflow.com/questions/24079133/what-is-the-difference-between-dbset-and-virtual-dbset*/
    public class TimeFlowContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public TimeFlowContext(DbContextOptions<TimeFlowContext> options) : base(options) { }

        public virtual DbSet<ProjectEntity> Projects { get; set; } = null!;

        public virtual DbSet<TaskEntity> Tasks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectEntity>().Configure();
            modelBuilder.Entity<TaskEntity>().Configure();

            base.OnModelCreating(modelBuilder);
        }
    }
}