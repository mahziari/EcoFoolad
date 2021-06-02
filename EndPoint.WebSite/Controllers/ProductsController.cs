using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        private readonly IProductsFrontEndFacad _productsFrontEndFacad;
        public ProductsController(IProductsFrontEndFacad productsFrontEndFacad)
        {
            _productsFrontEndFacad = productsFrontEndFacad;
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var result = _productsFrontEndFacad.GetProductsFrontEndService.Execute();
            return View(result);
        }
        
        [HttpGet]
        [Route("{category}/{menuName}/{page?}/{pageNumber?}")]
        public IActionResult Category(string category,string menuName,string page ,int pageNumber=1)
        {
            var result = _productsFrontEndFacad.GetProductsCategoryFrontEndService.Execute(menuName,pageNumber);
            return View(result);
        }


        [HttpGet]
        [Route("{category}/{name}/{page?}/{pageNumber?}/{id?}")]
        public IActionResult Details(string category,string name,string pageView ,int pageNumber=1)
        {
            var result = _productsFrontEndFacad.GetProductsDetailsFrontEndService.Execute(name,pageNumber);
            return View(result);
        }
    }
}