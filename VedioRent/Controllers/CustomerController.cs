using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VedioRent.Models;

namespace VedioRent.Controllers
{
    public class CustomerController : Controller
    {   
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>() { new Customer { Id = 1, Name = "Dileep" }, new Customer { Id = 2, Name = "Naveen" } };
            return View(customers);
        }

        public ActionResult Details(int id)
        {
         
            return View();
        }
    }
}