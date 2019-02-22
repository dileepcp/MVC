using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VedioRent.Models;

namespace VedioRent.ViewModel
{
    public class CustomersMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}