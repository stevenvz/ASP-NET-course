using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Steve"},
            new Customer { Id = 2, Name = "Swee"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = _customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{Id}")]
        public ActionResult Details(int id)
        {
            var customer = _customers.Find(c => c.Id.Equals(id));

            var viewModel = new CustomerViewModel
            {
                Customer = customer
            };

            return View(viewModel);
        }
    }
}