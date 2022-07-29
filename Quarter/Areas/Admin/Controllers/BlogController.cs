﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Quarter.Areas.Admin.Controllers
{
    [Area("admin"), Authorize(Roles = "Admin,SuperAdmin")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
