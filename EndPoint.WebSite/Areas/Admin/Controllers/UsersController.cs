using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Users.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
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
        [HttpGet]
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
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var result = _usersFacad.GetEditUsersServices.Execute(id);
            return View(result);
        }
        
        [Authorize(Policy = "UsersEdit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ResultGetEditUsersDto resultGetEditUsersDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", _usersFacad.GetEditUsersServices.Execute(resultGetEditUsersDto.UserId));
            }
        
            var result = _usersFacad.EditUsersServices.Execute(resultGetEditUsersDto);
        
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
        
        
        // public IActionResult Active(int id)
        // {
        //     var result = _usersFacad.ActiveUsersServices.Execute(id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message;
        //
        //     return Redirect("~/Admin/Users/Index");
        // }
        
        [HttpGet]
        public IActionResult RequestToBeOwner()
        {
            var result = _usersFacad.GetIndexUserOwnerServices.Execute();
            return View(result);
        }
        
        
        [HttpPost]
        public IActionResult RequestToBeOwner(string id)
        {
            var result = _usersFacad.ActiveRequestToBeOwnerServices.Execute(id);
            
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(RequestToBeOwner));
        }
        
        
    }
}