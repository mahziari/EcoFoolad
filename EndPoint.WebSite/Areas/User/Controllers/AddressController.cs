using Application.Services.FrontEnd.User.Addresses;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Policy = "UserRole")]
    [Route("panel/user/address/[action]/{id?}")]
    public class AddressController:Controller
    {
        private readonly IUserAddressServices _userAddressServices;

        public AddressController(IUserAddressServices userAddressServices)
        {
            _userAddressServices = userAddressServices;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var addresses = _userAddressServices.GetUserAddress(ClaimUtility.GetUserId(User));
            return View(addresses);
        }
        
        
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new UserAddressDto());
        }
        
        [HttpPost]
        public IActionResult Create(UserAddressDto userAddressDto)
        {
            string userId = ClaimUtility.GetUserId(User);
            userAddressDto.UserId = userId;
            _userAddressServices.AddNewAddress(userAddressDto);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _userAddressServices.GetEditAddressServices(id);
            return View(result.Data);
        }
        
        [HttpPost]
        public IActionResult Edit(UserAddressDto userAddressDto)
        {
            string userId = ClaimUtility.GetUserId(User);
            userAddressDto.UserId = userId;
            _userAddressServices.EditAddressServices(userAddressDto);
            return RedirectToAction(nameof(Index));
        }
        
    }
}