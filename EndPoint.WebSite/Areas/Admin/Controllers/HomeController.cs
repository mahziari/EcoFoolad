using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Authorize(Policy = "Home")]
    [Area("Admin")]
    [Route("panel/admin/home/[action]")]
    public class HomeController : Controller
    {
        private readonly IHomeFacad _homeFacad;

        public HomeController(IHomeFacad homeFacad)
        {
            _homeFacad = homeFacad;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
