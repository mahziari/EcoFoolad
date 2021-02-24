using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Web.Areas.Owner.Controllers
{
    [Area("Owner")]
    [Authorize(Policy = "OwnerRole")]
    [Route("panel/owner/home/[action]")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
