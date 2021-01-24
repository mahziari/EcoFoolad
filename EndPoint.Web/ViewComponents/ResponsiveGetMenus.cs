using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Common.Menus.FacadPattern;

namespace EndPoint.Web.ViewComponents
{
    public class ResponsiveGetMenus : ViewComponent
    {
        private readonly IMenusFrontEndFacad _menusFacad;

        public ResponsiveGetMenus(IMenusFrontEndFacad menusFacad)
        {
            _menusFacad = menusFacad;
        }

        public IViewComponentResult Invoke()
        {
            var result = _menusFacad.GetMenusFrontEndService.Execute();
            return View("ResponsiveGetMenus",result); 
        }
    }
}