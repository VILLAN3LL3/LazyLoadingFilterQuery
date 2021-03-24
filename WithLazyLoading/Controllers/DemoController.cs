using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WithLazyLoading.Controllers
{
    public class AppointmentDto
    {
        public IEnumerable<Guid> ProjectApppointments { get; set; }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;
        private readonly AppContext _appContext;

        public DemoController(ILogger<DemoController> logger, AppContext appContext)
        {
            _logger = logger;
            _appContext = appContext;
        }

        [HttpGet]
        public AppointmentDto Get()
        {
            Entities.ProjectAppointment pa = _appContext.ProjectAppointments.FirstOrDefault();
            pa.IsDeleted = true;
            _appContext.Update(pa);
            _appContext.SaveChanges();
            // ProjectAppointments Collection should be empty
            return new AppointmentDto { ProjectApppointments = _appContext.Appointments.First().ProjectAppointments.Select(pa => pa.Id) };
        }
    }
}
