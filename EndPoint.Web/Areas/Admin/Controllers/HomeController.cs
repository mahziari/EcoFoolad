using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    [Route("panel/home/[action]")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
