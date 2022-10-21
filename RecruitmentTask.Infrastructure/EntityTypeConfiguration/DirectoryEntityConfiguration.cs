using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecruitmentTask.Core.Entities;
using RecruitmentTask.Core.Seed;

namespace RecruitmentTask.Infrastructure.EntityTypeConfiguration
{
    internal class DirectoryEntityConfiguration: IEntityTypeConfiguration<Directory>
    {
        public void Configure(EntityTypeBuilder<Directory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(DirectorySeed.DirectoriesSeed);
        }
    }
}
