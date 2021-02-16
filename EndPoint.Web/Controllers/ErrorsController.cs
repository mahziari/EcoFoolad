using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Web.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class ErrorsController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult PageNotFound(int statusCode)
        {
            switch (statusCode)
            {
                case 404: ViewBag.ErrorMessage404 = true;
                    break;
                case 500: ViewBag.ErrorMessage500 = true;
                    break;
            }
            return View("Errors/Error");
        }
        
        [Route("Error/AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View("Errors/AccessDenied");
        }
    }
}