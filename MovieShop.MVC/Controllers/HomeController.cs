using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShop.MVC.Models;

namespace MovieShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    //_logger = logger;
        //}

        //private MovieService movieService;
        // "readonly" limits the _movieService only be used in a private constructor (NOT a public method)
        private readonly IMovieService _movieService
        {
            _movieService = _movieService;
        }
        public HomeController(IMovieServce movieServce)
        {
            //_movieService = new MovieService();
            //_movieService = new movieService();

            _movieService = movieService;

            //_movieService = new MovieService();


        }
        public IActionResult Index()
        {
            // call the database and get top 30 revenue movies
            // passing data from my controller/action method to view
            // ViewBag and ViewData - hard to get feedback for developers

            //ViewBag.TotalMovies = movies.Count();
            //ViewData["PageTitle"] = "Top Movies Page";
            //return View(movies);

            var movies = _movieService.GetTop30RevenueMovie();
            return View(movies);
            

        }





        //Always make it a habbit of putting a request type
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        //Note: url points to the action method, NOT VIEW!
        public IActionResult TopRatedMovies()
        {
            return View("TopMovies");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
