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
            //var movie = new Movie() { Name }
            //var movie = new Movie() { Name };
            var movie = new Movie() {Name = "Shrek!"};
            
            //Old version MVC
            //ViewData["RandomMovie"] = movie;
            //Old version MVC

            //Old version MVC
            //ViewBag.RandomMovie = movie;
            //Old version MVC

            var viewResult = new ViewResult();
            var customers = new List<Customer>()
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
                new Customer {Name = "Customer 3"},
                new Customer {Name = "Customer 4"},
                new Customer {Name = "Customer 5"},
            };
            //viewResult.ViewData.Model
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return new ViewResult();
            //return Content("Hell o world!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page =1, sortBy = "name"});

            
            

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        public ViewResult Index()
        {
            //if (!pageIndex.HasValue)
            //{
            //    pageIndex = 1;
            //}

            //if (String.IsNullOrWhiteSpace(sortBy))
            //{
            //    sortBy = "Name";
            //}

            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"},
            };
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}|\\d{1}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        //mvcaction4    

    }
}