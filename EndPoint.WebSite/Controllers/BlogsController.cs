using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    [Route("mag")]
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
        [Route("Archive/{pageView?}/{page?}")]
        public IActionResult All(int page=1)
        {
            var result = _blogsFrontEndFacad.GetAllBlogsFrontEndService.Execute(page);
            return View(result);
        }


        [HttpGet]
        [Route("category/{category}/{pageView?}/{page?}")]
        public IActionResult Category(string category,string pageView ,int page=1)
        {
            var result = _blogsFrontEndFacad.GetBlogsCategoryFrontEndService.Execute(category,page);
            ViewBag.Blogs  = result.Blogs;
            return View(result);
        }


        [HttpGet]
        [Route("{title}")]
        public IActionResult Details(string title)
        {
            var result = _blogsFrontEndFacad.GetBlogsDetailsFrontEndService.Execute(title);
            return View(result);
        }
    }
}