using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;
using WebAppMVC.ViewModel;

namespace WebAppMVC.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index ()
        {

            var listmovie = GetCustomers();
            var lst = new Movies() { ListMovie = listmovie };
            return View(lst) ;
        }
        public ActionResult Details(int id)
        {
            var film = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (film == null)
                return Content("it does not found");

            return View(film);
        }
        private List<Movies> GetCustomers()
        {
            return new List<Movies> {
                new Movies { Id=1,Name="John Wick 4"},
                new Movies { Id=2,Name="Terminator"},
                new Movies { Id=3,Name="Shrek"}
            };
        }
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Power of Learning .net core MVC" };
            var customersList = new List<Customers>
            {
                new Customers {Name="Customers 1"},
                new Customers {Name="Customers 2"}
            };
            var ranViewModel = new RandomViewModel()
            {
                movies = movie,
                customers = customersList
            };
            return View(ranViewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content($"id ={id} this is power of learning");
        }
        [Route("Movies/released/{month}")]
        public ActionResult newRoute(int? month)
        {
            return Content($"month ={month} new route  this is power of learning");
        }

    }
}
