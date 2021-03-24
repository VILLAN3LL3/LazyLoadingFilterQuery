using System;

namespace WithoutLazyLoading.Entities
{
    public class ProjectAppointment : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
