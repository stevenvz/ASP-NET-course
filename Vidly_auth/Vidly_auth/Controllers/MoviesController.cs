using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Back to the Future, Part 1"},
                new Movie { Id = 2, Name = "Star Trek: First Contact"}
            };

            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Steve"},
                new Customer { Id = 2, Name = "Swee"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies[0]
                //Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Back to the Future, Part 1"},
                new Movie { Id = 2, Name = "Star Trek: First Contact"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        [Route("Movies/Details/{Id}")]
        public ActionResult ById(int id)
        {
            return Content("Id=" + id);
        }
    }
}