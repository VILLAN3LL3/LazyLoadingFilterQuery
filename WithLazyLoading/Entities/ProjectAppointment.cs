using System;

namespace WithLazyLoading.Entities
{
    public class ProjectAppointment : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public Guid AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
