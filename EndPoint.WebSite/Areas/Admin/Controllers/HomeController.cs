﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Authorize(Policy = "Home")]
    [Area("Admin")]
    [Route("panel/admin/home/[action]")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
    }
}