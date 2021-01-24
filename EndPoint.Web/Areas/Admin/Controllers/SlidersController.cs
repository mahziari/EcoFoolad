using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Commands;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
    [Area("Admin")]
    [Route("panel/admin/sliders/[action]/{id?}")]
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
        //
        //
        //
        // public IActionResult Details(int id)
        // {
        //     var result = _SlidersFacad.GetDetailsSlidersServices.Execute(id);
        //     return View(result);
        // }
        
        
        
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
        
        
        
        // public IActionResult Edit(int id)
        // {
        //     var result = _slidersFacad.GetEditSlidersServices.Execute(id);
        //     return View(result);
        // }
        //
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Edit(CrmCmsNews crmCmsNews,int id)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return View("Edit",_slidersFacad.GetEditSlidersServices.Execute(id));
        //     }
        //     
        //     var result = _slidersFacad.EditSlidersServices.Execute(crmCmsNews,id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message; 
        //     
        //     return Redirect("~/Admin/Sliders/Index");
        // }
        
        
        public IActionResult Delete(int id)
        {
            var result = _slidersFacad.DeleteSlidersServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        // public IActionResult Active(int id)
        // {
        //     var result = _slidersFacad.ActiveSlidersServices.Execute(id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message; 
        //     
        //     return Redirect("~/Admin/Sliders/Index");
        // }
    }
}