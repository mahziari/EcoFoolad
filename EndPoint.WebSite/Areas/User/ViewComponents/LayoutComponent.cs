using System.Linq;
using System.Security.Claims;
using Application.Services.BackEnd.User.Home;
using Common.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace EndPoint.WebSite.Areas.User.ViewComponents
{
    public class LayoutComponent: ViewComponent
    {
        private readonly IUserHomeServices _userHomeServices;

        public LayoutComponent(IUserHomeServices userHomeServices)
        {
            _userHomeServices = userHomeServices;
        }
      
        public IViewComponentResult Invoke()
        {
            var result = _userHomeServices.UserHomeInformation();
            return View("LayoutComponent",result);
        }
        
        
    }
}