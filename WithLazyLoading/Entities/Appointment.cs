using System.Collections.Generic;

namespace WithLazyLoading.Entities
{
    public class Appointment : BaseEntity
    {
        public virtual ICollection<ProjectAppointment> ProjectAppointments { get; set; } = new HashSet<ProjectAppointment>();
    }
}
