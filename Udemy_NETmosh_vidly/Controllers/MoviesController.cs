using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Udemy_NETmosh_vidly.Models;
using Udemy_NETmosh_vidly.ViewModels;

namespace Udemy_NETmosh_vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }
        
        IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie() { Id = 1, Name = "Shrek!" },
                new Movie() { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies/Random

        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            { 
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            
            //return Content("HelloWorld");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult MoviesByReleaseDate(int year, byte month)
        {

            return Content(year + "/" + month);
        }
        
        //Returns a list of movies from the database
        /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            //If pageIndex has no value, start pageIndex at 1
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/
    }
}