using System;
using Application.Services.FrontEnd.Basket;
using Application.Services.FrontEnd.User.Addresses;
using Domain.Entities.Users;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    [AllowAnonymous]
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly SignInManager<User> _signInManager;
        private string _userId = null;
        private readonly IUserAddressServices _userAddressServices;
        public BasketController(IBasketService basketService, SignInManager<User> signInManager, IUserAddressServices userAddressServices)
        {
            _basketService = basketService;
            _signInManager = signInManager;
            _userAddressServices = userAddressServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = GetOrSetBasket();
            
            string userId = ClaimUtility.GetUserId(User);
            data.UserAddresses = _userAddressServices.GetUserAddress(userId);
            
            return View(data);
        }


        [HttpPost]
        public IActionResult Index(long productId, int quantity = 1)
        {
            var basket = GetOrSetBasket();
            _basketService.AddItemToBasket(basket.Id, productId, quantity);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        [Route("/basket/RemoveItemFromBasket/{itemId}")]
        public IActionResult RemoveItemFromBasket(int itemId)
        {
            _basketService.RemoveItemFromBasket(itemId);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult SetQuantity(int basketItemId, int quantity)
        {
            return Json(_basketService.SetQuantities(basketItemId, quantity));
        }
        
        
        private BasketDto GetOrSetBasket()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userId = ClaimUtility.GetUserId(User);
                return _basketService.GetOrCreateBasketForUser(userId);
            }

            SetCookiesForBasket();
            return _basketService.GetOrCreateBasketForUser(_userId);
        }

        private void SetCookiesForBasket()
        {
            string basketCookieName = "BasketId";
            if (Request.Cookies.ContainsKey(basketCookieName))
            {
                _userId = Request.Cookies[basketCookieName];
            }
            if (_userId != null) return;
            _userId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions { IsEssential = true };
            cookieOptions.Expires = DateTime.Today.AddYears(2);
            Response.Cookies.Append(basketCookieName, _userId, cookieOptions);
        }
    }
}
