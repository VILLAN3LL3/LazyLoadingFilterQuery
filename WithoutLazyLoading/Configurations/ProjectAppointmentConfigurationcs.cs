using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WithoutLazyLoading.Entities;

namespace WithoutLazyLoading.Configurations
{
    public class ProjectAppointmentConfigurationcs : IEntityTypeConfiguration<ProjectAppointment>
    {
        public void Configure(EntityTypeBuilder<ProjectAppointment> builder)
        {
            builder
                .HasOne(e => e.Project)
                .WithMany(p => p.ProjectAppointments)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);

            builder
                .HasOne(e => e.Appointment)
                .WithMany(p => p.ProjectAppointments)
                .HasForeignKey(e => e.AppointmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);

            builder
                .HasQueryFilter(pa => !pa.IsDeleted);
        }
    }
}
