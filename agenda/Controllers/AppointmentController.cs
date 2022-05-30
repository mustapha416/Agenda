using Microsoft.AspNetCore.Mvc;
using agenda.Models;
using agenda.Data;

namespace agenda.Controllers
{
    public class AppointmentController : Controller
    {
        readonly agendaContext _db;

        public AppointmentController(agendaContext db)
        {
            _db = db;
        }
        public IActionResult Listappointment()
        {
            IEnumerable<Appointment> appointmentsList = _db.Appointments;
            return View(appointmentsList);
        }
    }
}
