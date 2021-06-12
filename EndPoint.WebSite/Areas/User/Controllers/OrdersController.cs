using System.Linq;
using Application.Services.FrontEnd.User.Orders;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Policy = "UserRole")]
    [Route("panel/user/orders/[action]/{id?}")]
    public class OrdersController : Controller
    {
        private readonly IUserOrdersServices _userOrdersServices;

        public OrdersController(IUserOrdersServices userOrdersServices)
        {
            _userOrdersServices = userOrdersServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string userId = ClaimUtility.GetUserId(User);
            var data = _userOrdersServices.GetUserOrders(userId);
            return View(data);
        }
        
        
        
        [HttpGet]
        public IActionResult Details(long id)
        {
            var data = _userOrdersServices.GetDetailsUserOrders(id);
            return View(data.Data);
        }

    }
    
}