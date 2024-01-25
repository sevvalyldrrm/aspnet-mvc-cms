﻿using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
