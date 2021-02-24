using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Users.Queries;
using ParsaPoolad.Domain.Entities;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("panel/admin/users/[action]/{id?}")]
    public class UsersController : Controller
    {
        private readonly IUsersFacad _usersFacad;

        public UsersController(IUsersFacad usersFacad)
        {
            _usersFacad = usersFacad;
        }

        [Authorize(Policy = "UsersIndex")]
        public IActionResult Index()
        {
            var result = _usersFacad.GetIndexUsersServices.Execute();
            return View(result);
        }



        // public IActionResult Create()
        // {
        //     var result = _usersFacad.GetCreateUsersServices.Execute();
        //
        //     return View(result);
        // }
        //
        //
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Create(CrmCmsNews crmCmsNews)
        // {
        //
        //     if (!ModelState.IsValid)
        //     {
        //         return View("Create", _usersFacad.GetCreateUsersServices.Execute());
        //     }
        //
        //     var result = _usersFacad.CreateUsersServices.Execute(crmCmsNews);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message;
        //
        //     return Redirect("~/Admin/Users/Index");
        //
        // }
        //
        
        [Authorize(Policy = "UsersEdit")]
        public IActionResult Edit(string id)
        {
            var result = _usersFacad.GetEditUsersServices.Execute(id);
            return View(result);
        }
        
        [Authorize(Policy = "UsersEdit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ResultGetIndexUsersDto resultGetIndexUsersDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", _usersFacad.GetEditUsersServices.Execute(resultGetIndexUsersDto.Id));
            }
        
            var result = _usersFacad.EditUsersServices.Execute(resultGetIndexUsersDto);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }
        
        
        // public IActionResult Delete(int id)
        // {
        //     var result = _usersFacad.DeleteUsersServices.Execute(id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message;
        //
        //     return Redirect("~/Admin/Users/Index");
        // }
        //
        //
        // public IActionResult Active(int id)
        // {
        //     var result = _usersFacad.ActiveUsersServices.Execute(id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message;
        //
        //     return Redirect("~/Admin/Users/Index");
        // }
    }
}