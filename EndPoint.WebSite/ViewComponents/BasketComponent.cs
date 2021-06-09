using System.Security.Claims;
using Application.Services.FrontEnd.Basket;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.ViewComponents
{
    public class BasketComponent : ViewComponent
    {
        private readonly IBasketService _basketService;
        public BasketComponent(IBasketService basketService)
        {
            _basketService = basketService;
        }
        private ClaimsPrincipal userClaimsPrincipal => ViewContext?.HttpContext?.User;
        public IViewComponentResult Invoke()
        {
            BasketDto basket = null;
            if (User.Identity.IsAuthenticated)
            {
                basket = _basketService.GetBasketForUser(ClaimUtility.GetUserId(userClaimsPrincipal));
            }
            else
            {
                string basketCookieName = "BasketId";
                if (Request.Cookies.ContainsKey(basketCookieName))
                {
                    var buyerId = Request.Cookies[basketCookieName];
                    basket = _basketService.GetBasketForUser(buyerId);
                }

            }
            return View(viewName: "BasketComponent", model: basket);
        }
    }
}
