using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Products.Queries;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
 
    public class ProductsController : Controller
    {
        private readonly IProductsFrontEndFacad _productsFrontEndFacad;
        public ProductsController(IProductsFrontEndFacad productsFrontEndFacad)
        {
            _productsFrontEndFacad = productsFrontEndFacad;
        }


        [HttpGet]
        [Route("search")]
        public IActionResult Index()
        {
            var result = _productsFrontEndFacad.GetProductsFrontEndService.Execute();
            return View(result);
        }
        
        [HttpGet]
        [Route("search/category-{MenuName}/{PageWordForUrl?}/{PageNum?}/")]
        public IActionResult Category(ProductsFiltersDto productsFiltersDto)
        {
            var result = _productsFrontEndFacad.GetProductsCategoryThirdGroupFrontEndService.Execute(productsFiltersDto);
            return View(result);
        }
        
        [HttpGet]
        [Route("main/{FirstGroupName}/{PageWordForUrl?}/{PageNum?}/")]
        public IActionResult CategoryFirstGroup(ProductsFiltersDto productsFiltersDto)
        {
            var result = _productsFrontEndFacad.GetProductsCategoryFirstGroupFrontEndService.Execute(productsFiltersDto);
            return View("Category",result);
        }
        
        [HttpGet]
        [Route("main/category-{SecoundGroupName}/{PageWordForUrl?}/{PageNum?}/")]
        public IActionResult CategorySecoundGroup(ProductsFiltersDto productsFiltersDto)
        {
            var result = _productsFrontEndFacad.GetProductsSecoundGroupNameFrontEndService.Execute(productsFiltersDto);
            return View("Category",result);
        }


        [HttpGet]
        [Route("product/{MenuName}/{PrdName}/")]
        public IActionResult Details(string CategoryName,string MenuName,string PrdName)
        {
            var result = _productsFrontEndFacad.GetProductsDetailsFrontEndService.Execute(PrdName);
            return View(result);
        }
    }
}