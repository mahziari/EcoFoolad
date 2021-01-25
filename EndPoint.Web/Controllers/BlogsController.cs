using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
namespace EndPoint.Web.Controllers
{
    [Route("blog")]
    public class BlogsController : Controller
    {
        private readonly IBlogsFrontEndFacad _blogsFrontEndFacad;
        public BlogsController(IBlogsFrontEndFacad blogsFrontEndFacad)
        {
            _blogsFrontEndFacad = blogsFrontEndFacad;
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var result = _blogsFrontEndFacad.GetBlogsFrontEndService.Execute();
            return View(result);
        }


        [HttpGet]
        [Route("{category}/{pageView?}/{page?}")]
        public IActionResult Category(string category,string pageView ,int page=1)
        {
            var result = _blogsFrontEndFacad.GetBlogsCategoryFrontEndService.Execute(category,page);
            return View(result);
        }


        [HttpGet]
        [Route("{category}/{title}")]
        public IActionResult Details(string category,string title)
        {
            var result = _blogsFrontEndFacad.GetBlogsDetailsFrontEndService.Execute(title);
            return View(result);
        }
    }
}