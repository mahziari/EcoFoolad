using EndPoint.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;

namespace EndPoint.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeFrontEndFacad _homeFacad;

        public HomeController(IHomeFrontEndFacad homeFacad)
        {
            _homeFacad = homeFacad;
        }

        public IActionResult Index()
        {
            var result = _homeFacad.GetHomeFrontEndService.Execute();
            
            
            return View(result); 
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
