using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.ViewComponents
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