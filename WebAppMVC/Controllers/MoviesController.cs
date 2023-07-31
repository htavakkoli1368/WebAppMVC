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
        public ActionResult Index (int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content($"pageindex is ={pageIndex} and sort by {sortBy}");
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
