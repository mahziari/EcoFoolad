using Application.Interfaces.FacadPatterns.BackEnd.Owner;
using Application.Services.BackEnd.Owner.Profile.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Owner.Controllers
{
    
    [Area("Owner")]
    [Authorize(Policy = "OwnerRole")]
    [Route("panel/owner/Profile/[action]/{phoneNumber?}")]
    public class ProfileController : Controller
    {
        
        private readonly IOwnerProfileFacad _ownerProfileFacad;
        public ProfileController(IOwnerProfileFacad ownerProfileFacad)
        {
            _ownerProfileFacad = ownerProfileFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _ownerProfileFacad.GetIndexOwnerProfileServices.Execute();
            return View(result);
        }
        
        
        [HttpGet]
        public IActionResult ChangePassword(string phoneNumber)
        {
            var result = _ownerProfileFacad.GetIndexChangePasswordOwnerProfileServices.Execute(phoneNumber);
            return View("ChangePassword",result);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(ChangePasswordOwnerProfileDto changePasswordOwnerProfileDto,string phoneNumber)
        {
            if (!ModelState.IsValid)
            {
                return View("ChangePassword", _ownerProfileFacad.GetIndexChangePasswordOwnerProfileServices.Execute(phoneNumber));
            }
            
            var result = _ownerProfileFacad.ChangePasswordOwnerProfileServices.Execute(changePasswordOwnerProfileDto,phoneNumber);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return Redirect("/users/auth/checkout");
        }
    }
}