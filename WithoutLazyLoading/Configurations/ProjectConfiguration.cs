using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WithoutLazyLoading.Entities;

namespace WithoutLazyLoading.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasQueryFilter(pa => !pa.IsDeleted);
        }
    }
}
