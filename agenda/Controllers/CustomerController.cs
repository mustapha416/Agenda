using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using agenda.Models;
using agenda.Data;

namespace agenda.Controllers
{
    public class CustomerController : Controller
    {
        readonly agendaContext _db;

        public CustomerController(agendaContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));

        }

        public IActionResult ListCustomers()
        {
            IEnumerable<Customer> customerList = _db.Customers;
            return View(customerList);
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("listCustomers");

        }


        // GET: CustomerController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CustomerController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: CustomerController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: CustomerController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            Customer? cust = _db.Customers.Find(id);  
            return View(cust);
        }

        public ActionResult ProfilCustomer(int id)
        {
            Customer? cust = _db.Customers.Find(id);
            return View(cust);
        }

        public ActionResult Edit(int id)
        {
            Customer? cust = _db.Customers.Find(id);
            return View(cust);
        }

        // POST: BrokerController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(Customer cust)
        {
            _db.Customers.Update(cust);
            _db.SaveChanges();
            return RedirectToAction("ListCustomers");
        }


        // POST: CustomerController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(Customer custom)
        {
            _db.Customers.Remove(custom);
            _db.SaveChanges();
            return RedirectToAction("ListCustomers");
        }
    }
}
