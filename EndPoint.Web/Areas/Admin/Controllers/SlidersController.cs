using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Commands;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Authorize(Policy = "Sliders")]
    [Area("Admin")]
    [Route("panel/sliders/[action]/{id?}")]
    public class SlidersController : Controller
    {
        private readonly ISlidersFacad _slidersFacad;

        public SlidersController(ISlidersFacad slidersFacad)
        {
            _slidersFacad = slidersFacad;
        }
        
        
         public IActionResult Index()
        {
            var result = _slidersFacad.GetIndexSlidersServices.Execute();
            return View(result);
        }

         public IActionResult Create()
        {
            var result = _slidersFacad.GetCreateSlidersServices.Execute();
           
            return View(result);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateSlidersServicesDto createSlidersServicesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_slidersFacad.GetCreateSlidersServices.Execute());
            }
            
            var result = _slidersFacad.CreateSlidersServices.Execute(createSlidersServicesDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        public IActionResult Delete(int id)
        {
            var result = _slidersFacad.DeleteSlidersServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
    }
}