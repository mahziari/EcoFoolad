using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.ViewComponents
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