﻿using Microsoft.AspNetCore.Mvc;

namespace ProductsAPI.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
