using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Controllers
{
    public class MoviesController : Controller
    {

        public async Task<IActionResult> Details(int id)
        {
            // movie service to get the details
            return View();
        }

        public async Task<IActionResult> GetMoviesByGenre(int id)
        {
            // call my movie service to get the movies by genre
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
