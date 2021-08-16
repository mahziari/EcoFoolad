using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Blogs;
using Application.Services.BackEnd.Admin.Experts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "Experts")]
    [Route("panel/admin/Experts/[action]/{id?}")]
    public class ExpertsController : Controller
    {
         private readonly IExpertsFacad _expertsFacad;

         public ExpertsController(IExpertsFacad expertsFacad)
         {
             _expertsFacad = expertsFacad;
         }


         public IActionResult Index()
        {
            var result = _expertsFacad.ExpertsServices.GetIndexExpertsServices();
            return View(result);
        }
         

        [HttpGet]
        public IActionResult Create()
        {
            var result = _expertsFacad.ExpertsServices.GetCreateExpertsServices();

            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpertDto expertDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", _expertsFacad.ExpertsServices.GetCreateExpertsServices());
            }

            var result = _expertsFacad.ExpertsServices.CreateExpertsServices(expertDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _expertsFacad.ExpertsServices.GetEditExpertsServices(id);
            return View(result.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ExpertDto expertDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", _expertsFacad.ExpertsServices.GetEditExpertsServices(expertDto.Id).Data);
            }

            var result = _expertsFacad.ExpertsServices.EditExpertsServices(expertDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var result = _expertsFacad.ExpertsServices.DeleteExpertsServices(id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }
        
    }
}