using System.Collections.Generic;

namespace WithoutLazyLoading.Entities
{
    public class Appointment : BaseEntity
    {
        public ICollection<ProjectAppointment> ProjectAppointments { get; set; } = new HashSet<ProjectAppointment>();
    }
}
