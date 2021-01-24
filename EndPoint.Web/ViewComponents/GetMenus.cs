using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Common.Menus.FacadPattern;

namespace EndPoint.Web.ViewComponents
{
    public class GetMenus : ViewComponent
    {
        private readonly IMenusFrontEndFacad _menusFacad;

        public GetMenus(IMenusFrontEndFacad menusFacad)
        {
            _menusFacad = menusFacad;
        }

        public IViewComponentResult Invoke()
        {
            var result = _menusFacad.GetMenusFrontEndService.Execute();
            return View("GetMenus",result); 
        }
    }
}