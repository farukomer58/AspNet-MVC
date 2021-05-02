using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class MoviesController : Controller
    {
 
        // GET: Movies/Random, you can see it as route
        public ActionResult Random() {
            var movie = new Movie() { Name="Shrek!" };
            return View(movie);
        }

        // GET: Movies/Edit
        public ActionResult Edit(int id) {
            return Content("id= "+id);
        }

        // GET: Movies index page
        public ActionResult Index(int? pageIndex, string sortBy) {

            if (!pageIndex.HasValue) {
                pageIndex=1; // if no query parameter is passed set the default value
            }
            if (String.IsNullOrEmpty(sortBy)) {
                sortBy="Name"; // if no query parameter is passed set the default value
            }

            return Content(String.Format("pageIndex={0} & sortBy={1} ", pageIndex, sortBy));
        }


    }
}