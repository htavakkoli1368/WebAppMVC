using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

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
            var movie = new Movies() {Name="Power of Learning .net core MVC" };
            return RedirectToAction("Index", "Home", new {page=1,sortBy="name" });
        }

        public ActionResult Edit(int id)
        {
            return Content($"id ={id} this is power of learning");
        }
    }
}
