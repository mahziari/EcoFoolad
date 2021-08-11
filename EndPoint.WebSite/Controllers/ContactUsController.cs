using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.BackEnd.Admin.Footers;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    public class ContactUsController:Controller
    {
        private readonly IFootersFrontEndFacad _footersFrontEndFacad;

        public ContactUsController(IFootersFrontEndFacad footersFrontEndFacad)
        {
            _footersFrontEndFacad = footersFrontEndFacad;
        }
        
        [HttpGet]
        [Route("contact-us")]
        public IActionResult Index()
        {
            var result = _footersFrontEndFacad.GetFootersFrontEndService.GetFootersFrontEnd();
            return View(result);
        }
    }
}