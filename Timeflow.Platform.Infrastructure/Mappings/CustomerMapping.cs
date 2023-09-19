using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Mappings
{
    public static class CustomerMapping
    {
        public static void Configure(this EntityTypeBuilder<CustomerEntity> modelBuilder)
        {
            //modelBuilder.HasMany(x => x.Cars).WithOne(y => y.User).HasForeignKey(z => z.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.ToTable("Customers");
        }
    }
}
