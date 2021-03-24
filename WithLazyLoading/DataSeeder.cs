using System.Linq;

namespace WithLazyLoading
{
    public static class DataSeeder
    {
        public static void SeedData(AppContext appContext)
        {
            var project = new Entities.Project();
            var appointment = new Entities.Appointment();
            var deletedProjectAppointment = new Entities.ProjectAppointment { ProjectId = project.Id, AppointmentId = appointment.Id, IsDeleted = true };
            var projectAppointment = new Entities.ProjectAppointment { ProjectId = project.Id, AppointmentId = appointment.Id };

            if (!appContext.Projects.Any())
            {
                appContext.Projects.Add(project);
            }
            if (!appContext.Appointments.Any())
            {
                appContext.Appointments.Add(appointment);
            }
            if (!appContext.ProjectAppointments.Any())
            {
                appContext.ProjectAppointments.Add(deletedProjectAppointment);
                appContext.ProjectAppointments.Add(projectAppointment);
            }
            appContext.SaveChanges();
        }
    }
}
