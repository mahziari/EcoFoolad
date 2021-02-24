using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Products.Commands;
using ParsaPoolad.Domain.Entities;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("panel/admin/products/[action]/{id?}")]
    public class ProductsController: Controller
    {
        private readonly IProductsFacad _productsFacad;

        public ProductsController(IProductsFacad productsFacad)
        {
            _productsFacad = productsFacad;
        }

        [Authorize(Policy = "ProductsIndex")]
        public IActionResult Index()
        {
            var result = _productsFacad.GetIndexProductsServices.Execute();
            return View(result);
        }
        
        
        [Authorize(Policy = "ProductsIndex")]
        public IActionResult Details(int id)
        {
            var result = _productsFacad.GetDetailsProductsServices.Execute(id);
            return View(result);
        }
        
        
        [Authorize(Policy = "ProductsCreate")]
        public IActionResult Create()
        {
            var result = _productsFacad.GetCreateProductServices.Execute();
           
            return View(result);
        }
        
        
        [Authorize(Policy = "ProductsCreate")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductsServicesDto createProductsServicesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_productsFacad.GetCreateProductServices.Execute());
            }
            
            var result = _productsFacad.CreateProductsServices.Execute(createProductsServicesDto);
      
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
            
        }

        [Authorize(Policy = "ProductsEdit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _productsFacad.GetEditProductServices.Execute(id);
            return View(result);
        }
        
        [Authorize(Policy = "ProductsEdit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductsServicesDto editProductsServicesDto,int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",_productsFacad.GetEditProductServices.Execute(id));
            }
            
            var result = _productsFacad.EditProductsServices.Execute(editProductsServicesDto,id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [Authorize(Policy = "ProductsDelete")]
        [HttpDelete]
        // [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var result = _productsFacad.DeleteProductServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        [Authorize(Policy = "ProductsActive")]
        public IActionResult Active(int id)
        {
            var result = _productsFacad.ActiveProductServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetReturnSubMenuAjax(int id)
        {
            var result = _productsFacad.GetReturnSubMenusAjaxServices.Execute(id);
            return Json(result.SubMenus);
        }
        
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetReturnSubSubMenuAjax(int id)
        {
            var result = _productsFacad.GetReturnSubSubMenusAjaxServices.Execute(id);
            return Json(result.SubSubMenus);
        }
        
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetReturnCompanyAjax(int id)
        {
            var result = _productsFacad.GetReturnCompanyAjaxServices.Execute(id);
            return Json(result.CompanyMenus);
        }


    }
}