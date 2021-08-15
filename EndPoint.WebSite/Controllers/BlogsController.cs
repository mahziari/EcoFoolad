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
        [Route("Archive/{pageView?}/{pageNumber?}")]
        public IActionResult Archive(string pageView,int pageNumber=1)
        {
            var result = _blogsFrontEndFacad.GetArchiveBlogsFrontEndService.Execute(pageNumber);
            return View(result);
        }
        
        [HttpGet]
        [Route("Archive/category/{category}/{pageView}/{pageNumber?}")]
        public IActionResult CategoryArchive(string category,string pageView,int pageNumber=1)
        {
            var result = _blogsFrontEndFacad.GetBlogsCategoryArchiveFrontEndServices.Execute(category,pageNumber);
            return View(result);
        }


        [HttpGet]
        [Route("category/{category}/{pageView?}/{pageNumber?}")]
        public IActionResult Category(string category,string pageView ,int pageNumber=1)
        {
            var result = _blogsFrontEndFacad.GetBlogsCategoryFrontEndService.Execute(category,pageNumber);
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