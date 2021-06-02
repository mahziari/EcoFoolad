using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Roles.Commands.CreateRoles;
using Application.Services.BackEnd.Admin.Roles.Commands.EditRoles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
    [Area("Admin")]
    [Route("panel/admin/roles/[action]/{id?}")]
    public class RolesController : Controller
    {
        private readonly IRolesFacad _rolesFacad;

        public RolesController(IRolesFacad rolesFacad)
        {
            _rolesFacad = rolesFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _rolesFacad.GetIndexRolesServices.Execute();
            return View(result);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var result = _rolesFacad.GetCreateRolesServices.Execute();

            return View(result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateRolesServicesDto createRolesServicesDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", _rolesFacad.GetCreateRolesServices.Execute());
            }

            var result = _rolesFacad.CreateRolesServices.Execute(createRolesServicesDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(string id)
        {
            var result = _rolesFacad.GetEditRolesServices.Execute(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditRolesServicesDto editRolesServicesDto,string id)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", _rolesFacad.GetEditRolesServices.Execute(id));
            }

            var result = _rolesFacad.EditRolesServices.Execute(editRolesServicesDto,id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }


        // public IActionResult Delete(int id)
        // {
        //     var result = _rolesFacad.DeleteProductServices.Execute(id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message; 
        //     
        //     return RedirectToAction(nameof(Index));
        // }
    }
}