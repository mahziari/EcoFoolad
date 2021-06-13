﻿using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Products.Queries;
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
        [Route("{CategoryName}/{MenuName}/{PageWordForUrl?}/{PageNum?}")]
        public IActionResult Category(ProductsFiltersDto productsFiltersDto)
        {
            var result = _productsFrontEndFacad.GetProductsCategoryFrontEndService.Execute(productsFiltersDto);
            return View(result);
        }


        [HttpGet]
        [Route("{CategoryName}/{MenuName}/{PageNum?}/{PageSize?}/{id?}")]
        public IActionResult Details(string category,string name,string pageView ,int pageNumber=1)
        {
            var result = _productsFrontEndFacad.GetProductsDetailsFrontEndService.Execute(name,pageNumber);
            return View(result);
        }
    }
}