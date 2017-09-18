using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Udemy_NETmosh_vidly.Models;
using Udemy_NETmosh_vidly.ViewModels;

namespace Udemy_NETmosh_vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer

        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer() { Id = 1, Name = "John Smith" },
                new Customer() { Id = 2, Name = "Mary Williams"}
            };
        }
    }
}