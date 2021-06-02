// using System.Security.Claims;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using    Domain.Entities.Identity;
//
// namespace EndPoint.Web.Areas.Admin.Controllers
// {
//     [Authorize(Policy = "Admins")]
//     [Area("Admin")]
//     [Route("panel/admin/claims/[action]")]
//     public class ClaimsController:Controller
//     {
//         
//         private readonly UserManager<User> _userManager;
//
//         public ClaimsController(UserManager<User> userManager)
//         {
//             _userManager = userManager;
//         }
//         
//         
//         
//         public IActionResult Index()
//         {
//             return View(User.Claims);
//         }
//         
//         
//         [HttpGet]
//         public IActionResult Create()
//         {
//             return View();
//         }
//         
//         
//         [HttpPost]
//         public IActionResult Create(string ClaimType, string ClaimValue)
//         {
//             var user = _userManager.GetUserAsync(User).Result;
//             Claim newClaim = new Claim(ClaimType, ClaimValue, ClaimValueTypes.String);
//             var result = _userManager.AddClaimAsync(user, newClaim).Result;
//             if (result.Succeeded)
//             {
//                 RedirectToAction("Index");
//             }
//
//             foreach (var item in result.Errors)
//             {
//                 ModelState.AddModelError("",item.Description);
//             }
//
//             return View();
//         }
//     }
// }