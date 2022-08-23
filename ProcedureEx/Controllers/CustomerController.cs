using Microsoft.AspNetCore.Mvc;
using ProcedureEx.Models;

namespace ProcedureEx.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindContext Context { get; }
        public CustomerController(NorthwindContext _context)
        {
            this.Context = _context;
        }

        public IActionResult Index()
        {
            List<Customer> customers = this.Context.Customers.ToList();
            return View(customers);
        }

        [HttpPost]
        public IActionResult Index(string customerName)
        {
            List<Customer> customers = this.Context.SearchCustomers(customerName).ToList();
            return View(customers);
        }
    }
}
