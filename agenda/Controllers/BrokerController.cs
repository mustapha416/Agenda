using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using agenda.Models;
using agenda.Data;

namespace agenda.Controllers
{
    public class BrokerController : Controller
    {
        readonly agendaContext _db;

        public BrokerController(agendaContext db)
        {
            _db = db;

        }

        public IActionResult ListBrokers()
        {
            IEnumerable<Broker> brokerList = _db.Brokers;
            return View(brokerList);
        }
        public IActionResult ProfilBrokers(int id)
        {
            Broker? broker = _db.Brokers.Find(id);
            return View(broker);
        }

        // GET: BrokerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BrokerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrokerController/Create
        public ActionResult CreateBroker()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBroker(Broker broker)
        {
                _db.Brokers.Add(broker);
                _db.SaveChanges();
                return RedirectToAction("listBrokers");
    
        }

        // POST: BrokerController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
                return View(collection);
            
        }

        // GET: BrokerController/Edit/5
        public ActionResult Edit(int id)
        {
            Broker? bro = _db.Brokers.Find(id);
            return View(bro);
        }

        // POST: BrokerController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(Broker bro)
        {
            //try
            //{
            //    return RedirectToAction(nameof(ListBrokers));
            //}
            //catch
            //{

            //    return View(bro);
            //}

           
            _db.Brokers.Update(bro);
            _db.SaveChanges();
            return RedirectToAction("ListBrokers");
        }

        // GET: BrokerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrokerController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Afficher(int id)
        {
            Broker? bro = _db.Brokers.Find(id);
            return View(bro);
        }

    }


}
