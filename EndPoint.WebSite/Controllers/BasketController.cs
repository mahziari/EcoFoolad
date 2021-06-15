using System;
using Application.Services.FrontEnd.Basket;
using Application.Services.FrontEnd.Orders;
using Application.Services.FrontEnd.Payments;
using Application.Services.FrontEnd.User.Addresses;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Domain.Entities.Users;
using EndPoint.WebSite.Models.ViewModel.Baskets;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly SignInManager<User> _signInManager;
        private string _userId = null;
        private readonly IUserAddressServices _userAddressServices;
        private readonly IOrderServices _orderServices;
        private readonly IPaymentsServices _paymentsServices;
        public BasketController(IBasketService basketService, SignInManager<User> signInManager, IUserAddressServices userAddressServices, IOrderServices orderServices, IPaymentsServices paymentsServices)
        {
            _basketService = basketService;
            _signInManager = signInManager;
            _userAddressServices = userAddressServices;
            _orderServices = orderServices;
            _paymentsServices = paymentsServices;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/basket")]
        public IActionResult Index()
        {
            var model = GetOrSetBasket();
            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("/basket")]
        public IActionResult Index(long productId, int quantity = 1)
        {
            var basket = GetOrSetBasket();
            _basketService.AddItemToBasket(basket.Id, productId, quantity);
            return RedirectToAction(nameof(Index));
        }

        
        [AllowAnonymous]
        [HttpGet]
        [Route("/basket/RemoveItemFromBasket/{itemId}")]
        public IActionResult RemoveItemFromBasket(int itemId)
        {
            _basketService.RemoveItemFromBasket(itemId);
            return RedirectToAction(nameof(Index));
        }

        
        [AllowAnonymous]
        [HttpPost]
        public IActionResult SetQuantity(int basketItemId, int quantity)
        {
            return Json(_basketService.SetQuantities(basketItemId, quantity));
        }
        
        [AllowAnonymous]
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

        
        [AllowAnonymous]
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
        
        
        [Authorize(Policy = "UserRole")]
        [HttpGet]
        [Route("basket/shipping-payment")]
        public IActionResult ShippingPayment()
        {
            ShippingPaymentViewModel model = new ShippingPaymentViewModel();
            var userId = ClaimUtility.GetUserId(User);
            model.basket = _basketService.GetBasketForUser(userId);
            model.UserAddresses = _userAddressServices.GetUserAddress(userId);
            return View(model);
        }

        [Authorize(Policy = "UserRole")]
        [HttpPost]
        [Route("basket/shipping-payment")]
        public IActionResult ShippingPayment(int address,PaymentMethod paymentMethod)
        {
            var userId = ClaimUtility.GetUserId(User);
            var basket = _basketService.GetBasketForUser(userId);
            long orderId = _orderServices.CreateOrder(basket.Id, address, paymentMethod);

            if (paymentMethod==PaymentMethod.OnlinePayment)
            {
                var payment = _paymentsServices.PayForOrder(orderId);
                
                return RedirectToAction("Index","Pay", new{paymentId=payment.Id});
            }
            else
            {
                return RedirectToAction("Details","Orders", new{area="User"});
            }
        }

    }
}
