using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMovie(MovieCreateRequestModel movieCreateRequestModel)
        {
            // Note: modalbyname is case insensitive

            // take the information from View and Save it to Database
            // save to database
            return View();
        }

        [HttpGet]
        // Get an empty page before posting out movie details
        public IActionResult CreateMovie()
        {
            // will show emoty page so admin can enter movie information
            return View();
        }

    }
}
