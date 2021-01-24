using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries;

namespace EndPoint.Web.Areas.Admin.Controllers
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


        public IActionResult Index()
        {
            var result = _rolesFacad.GetIndexRolesServices.Execute();
            return View(result);
        }



        public IActionResult Create()
        {
            var result = _rolesFacad.GetCreateRolesServices.Execute();
           
            return View(result);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GetIndexRolesRolesDto getIndexRolesRolesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_rolesFacad.GetCreateRolesServices.Execute());
            }
            
            var result = _rolesFacad.CreateRolesServices.Execute(getIndexRolesRolesDto);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
            
        }
        
    }
}