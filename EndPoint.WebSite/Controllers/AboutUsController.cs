using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    public class AboutUsController: Controller
    {
        private readonly IAboutUsFrontEndFacad _aboutUsFrontEndFacad;

        public AboutUsController(IAboutUsFrontEndFacad aboutUsFrontEndFacad)
        {
            _aboutUsFrontEndFacad = aboutUsFrontEndFacad;
        }


        [HttpGet]
        [Route("about-us")]
        public IActionResult Index()
        {
            var result = _aboutUsFrontEndFacad.AboutUsFrontEndServices.GetAboutUs();
            return View(result);
        }
        
    }
}