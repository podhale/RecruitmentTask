using Microsoft.EntityFrameworkCore;
using RecruitmentTask.Core.Entities;
using RecruitmentTask.Core.Interfaces;
using RecruitmentTask.Infrastructure.EntityTypeConfiguration;

namespace RecruitmentTask.Infrastructure
{
    public class SimpleApiContext : DbContext, ISimpleApiContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Directory> Directories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "MemoryDb");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new DirectoryEntityConfiguration().Configure(builder.Entity<Directory>());
            new ProductEntityConfiguration().Configure(builder.Entity<Product>());
        }
    }
}
