﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> GetUserPurchases()
        {
            return View();
        }
    }
}
