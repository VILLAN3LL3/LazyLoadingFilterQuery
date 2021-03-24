using System.Collections.Generic;

namespace WithoutLazyLoading.Entities
{
    public class Project : BaseEntity
    {
        public ICollection<ProjectAppointment> ProjectAppointments { get; set; } = new HashSet<ProjectAppointment>();
    }
}
