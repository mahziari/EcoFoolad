using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.ViewComponents
{
    public class GetFooters : ViewComponent
    {
        private readonly IFootersFrontEndFacad _footersFrontEndFacad;

        public GetFooters(IFootersFrontEndFacad footersFrontEndFacad)
        {
            _footersFrontEndFacad = footersFrontEndFacad;
        }


        public IViewComponentResult Invoke()
        {
            var result = _footersFrontEndFacad.GetFootersFrontEndService.GetFootersFrontEnd();
            return View("GetFooters",result.Data); 
        }
    }
}