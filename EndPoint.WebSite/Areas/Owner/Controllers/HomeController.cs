using Application.Interfaces.FacadPatterns.BackEnd.Owner;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Owner.Controllers
{
    [Area("Owner")]
    [Authorize(Policy = "OwnerRole")]
    [Route("panel/owner/home/[action]")]
    public class HomeController : Controller
    {
        private readonly IOwnerHomeFacad _ownerHomeFacad;
        public HomeController(IOwnerHomeFacad ownerHomeFacad)
        {
            _ownerHomeFacad = ownerHomeFacad;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            var result = _ownerHomeFacad.GetIndexHomeServices.Execute();
            return View(result);
        }
        
    }
}
