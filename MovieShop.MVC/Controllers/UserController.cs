using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using MovieShop.MVC.Filters;

namespace MovieShop.MVC.Controllers
{
    public class UserController : Controller
    {
        //[ServiceFilter(typeof(MovieShopHeaderFilterAttribute))]
        [Authorize]
        public async Task<IActionResult> Purchases()
        {
            // call the user service with userid and get list of movies that user purchased
            // it should look for cookie is present, cookie should not be expired and get the user id from cookie
            return View();
        }
    }
}