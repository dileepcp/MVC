using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VedioRent.Models;

namespace VedioRent.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.Name = "KGF";
            return View(movie);
        }
        public ActionResult Index()
        {
            var movie = new List<Movie> {new Movie { Id = 1, Name = "KGF" }, new Movie { Id = 1, Name = "Kurukshetra" } } ;
            return View(movie);
        }
    }
}