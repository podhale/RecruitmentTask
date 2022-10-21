using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentTask.Core.Entities;

namespace RecruitmentTask.Infrastructure.EntityTypeConfiguration
{
    internal class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Price).HasPrecision(9, 2);
            
            builder.HasOne(dir => dir.Directory)
                    .WithMany(x => x.Products)
                    .HasForeignKey(mt => mt.DirectoryId)
                    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
