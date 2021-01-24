using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Queries;

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
        public IActionResult Index(int pageNumber=1,int pageSize=20)
        {
            var result = _blogsFrontEndFacad.GetBlogsFrontEndService.Execute(pageNumber,pageSize);
            return View(result);
        }


        [HttpGet]
        [Route("{category}")]
        public IActionResult Category(string category)
        {
            var result = _blogsFrontEndFacad.GetBlogsCategoryFrontEndService.Execute(category);
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