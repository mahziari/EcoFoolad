using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.AboutUs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "AboutUs")]
    [Route("panel/admin/About-Us/[action]/{id?}")]
    public class AboutUsController: Controller
    {
        private readonly IAboutUsFacad _aboutUsFacad;
        
        public AboutUsController(IAboutUsFacad aboutUsFacad)
        {
            _aboutUsFacad = aboutUsFacad;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var result = _aboutUsFacad.AboutUsServices.GetAboutUs();
            return View(result);
        }
        
        
        public IActionResult Edit(AboutUsDto aboutUsDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", _aboutUsFacad.AboutUsServices.GetAboutUs());
            }
            var result = _aboutUsFacad.AboutUsServices.EditAboutUsValues(aboutUsDto);
            
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];
            return RedirectToAction(nameof(Index));
        }
    }
}