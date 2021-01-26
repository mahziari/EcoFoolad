using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;

namespace EndPoint.Web.Controllers
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
        [Route("{category}/{menu}/{subMenu}/{pageView?}/{page?}")]
        public IActionResult Category(string category,string Menu,string subMenu,string pageView ,int page=1)
        {
            var result = _productsFrontEndFacad.GetProductsCategoryFrontEndService.Execute(subMenu,page);
            return View(result);
        }


        [HttpGet]
        [Route("{category}/{title}")]
        public IActionResult Details(string category,string title)
        {
            var result = _productsFrontEndFacad.GetProductsDetailsFrontEndService.Execute(title);
            return View(result);
        }
    }
}