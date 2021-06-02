using System.Security.Claims;
using Application.Services.FrontEnd.Carts;
using Domain.Entities.Users;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        private readonly ICartFrontEndService _cartFrontEndService;
        private readonly CookiesManeger _cookiesManeger ;
        public CartController(ICartFrontEndService cartFrontEndService)
        {
            _cartFrontEndService = cartFrontEndService;
            _cookiesManeger = new CookiesManeger();
        }

        [Route("Cart")]
        public IActionResult Index()
        {
            var resultGetLst=  _cartFrontEndService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), null);
            return View(resultGetLst.Data);
        }
        

        [Route("Cart/AddToCart/{productId}")]
        public IActionResult AddToCart(long productId)
        {
            var resultAdd= _cartFrontEndService.AddToCart(productId, _cookiesManeger.GetBrowserId(HttpContext));
            return RedirectToAction("Index");
        }
        
        [Route("Cart/Add/{cartItemId}")]
        public IActionResult Add(long cartItemId)
        {
            _cartFrontEndService.Add(cartItemId);
            return RedirectToAction("Index");
        }  
        
        [Route("Cart/LowOff/{cartItemId}")]
        public IActionResult LowOff(long cartItemId)
        {
            _cartFrontEndService.LowOff(cartItemId);
            return RedirectToAction("Index");
        }

        [Route("Cart/Remove/{productId}")]
        public IActionResult Remove(long productId)
        {
            _cartFrontEndService.RemoveFromCart(productId, _cookiesManeger.GetBrowserId(HttpContext));
            return RedirectToAction("Index");
        }
    }
}
