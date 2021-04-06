using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Owner;

namespace Endpoint.Web.Areas.Owner.Controllers
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

        
        
        public IActionResult Index()
        {
            var result = _ownerHomeFacad.GetIndexHomeServices.Execute();
            return View(result);
        }
        
    }
}
