using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Web.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Policy = "UserRole")]
    [Route("panel/user/home/[action]")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
