using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Application.Services.BackEnd.Admin.Factory.Command.EditFactory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "Factory")]
    [Route("panel/admin/factory/[action]/{id?}")]
    public class FactoryController : Controller
    {
        private readonly IFactoryFacad _factoryFacad;

        public FactoryController(IFactoryFacad factoryFacad)
        {
            _factoryFacad = factoryFacad;
        }

        public IActionResult Index()
        {
            var result = _factoryFacad.GetIndexFactoryServices.GetIndexFactory();
            return View(result);
        }

        


        [HttpGet]
        public IActionResult Create()
        {
            var result = _factoryFacad.GetCreateFactoryServices.GetCreateFactory();

            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FactoryDto factoryDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", _factoryFacad.GetCreateFactoryServices.GetCreateFactory());
            }

            var result = _factoryFacad.CreateFactoryServices.CreateFactory(factoryDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }


        // [HttpGet]
        // public IActionResult Edit(int id)
        // {
        //     var result = _factoryFacad.GetEditFactoryServices.Execute(id);
        //     return View(result);
        // }
        //
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Edit(EditFactoryServicesDto editFactoryServicesDto, int id)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return View("Edit", _factoryFacad.GetEditFactoryServices.Execute(id));
        //     }
        //
        //     var result = _factoryFacad.EditFactoryServices.Execute(editFactoryServicesDto, id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message;
        //
        //     return RedirectToAction(nameof(Index));
        // }
        

    }
}