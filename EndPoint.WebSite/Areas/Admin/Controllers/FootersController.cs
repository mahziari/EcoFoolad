using Application.Services.BackEnd.Admin.Footers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "Footers")]
    [Route("panel/admin/footers/[action]/{id?}")]
    public class FootersController: Controller
    {
        private readonly IFootersServices _footersServices;

        public FootersController(IFootersServices footersServices)
        {
            _footersServices = footersServices;
        }

        public IActionResult Index()
        {
            var footer = _footersServices.GetFootersValues();
            return View(footer);
        }
        
        public IActionResult Edit(FooterDto footerDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", _footersServices.GetFootersValues());
            }
            var result = _footersServices.EditFootersValues(footerDto);
            
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];
            return RedirectToAction(nameof(Index));
        }
    }
}