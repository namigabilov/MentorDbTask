﻿using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
