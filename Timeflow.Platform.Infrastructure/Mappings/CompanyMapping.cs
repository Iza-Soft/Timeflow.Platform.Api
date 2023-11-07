//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Timeflow.Platform.Infrastructure.Entities;

//namespace Timeflow.Platform.Infrastructure.Mappings
//{
//    public static class CompanyMapping
//    {
//        public static void Configure(this EntityTypeBuilder<CompanyEntity> modelBuilder)
//        {
//            modelBuilder.HasMany(x => x.Persons).WithOne(y => y.Company).HasForeignKey(z => z.CompanyId).OnDelete(DeleteBehavior.ClientCascade);
//            modelBuilder.HasBaseType<ContractorEntity>();
//        }
//    }
//}
