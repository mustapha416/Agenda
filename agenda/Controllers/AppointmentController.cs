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

        public ActionResult AddAppointment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAppointment(Appointment ap)
        {
            _db.Appointments.Add(ap);
            _db.SaveChanges();
            return RedirectToAction("listAppointment");

        }

        public void GetBrokers()
        {
            ViewBag.Brokers = _db.Brokers.ToList();
        }

    }
}
