﻿using Microsoft.AspNetCore.Mvc;

namespace Quarter.Areas.Admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}