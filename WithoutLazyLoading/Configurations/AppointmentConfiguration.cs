using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WithoutLazyLoading.Entities;

namespace WithoutLazyLoading.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder
                .HasQueryFilter(pa => !pa.IsDeleted);
        }
    }
}
