using Application.Interfaces.FacadPatterns.BackEnd.Owner;
using Application.Services.BackEnd.Owner.Products.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Owner.Controllers
{
    [Area("Owner")]
    [Authorize(Policy = "OwnerRole")]
    [Route("panel/owner/products/[action]/{id?}")]
    public class ProductsController: Controller
    {
        private readonly IOwnerProductsFacad _ownerProductsFacad;

        public ProductsController(IOwnerProductsFacad productsFacad)
        {
            _ownerProductsFacad = productsFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _ownerProductsFacad.GetIndexProductsServices.Execute();
            return View(result);
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = _ownerProductsFacad.GetDetailsProductsServices.Execute(id);
            return View(result);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            var result = _ownerProductsFacad.GetCreateProductServices.Execute();
           
            return View(result);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductsServicesDto createProductsServicesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_ownerProductsFacad.GetCreateProductServices.Execute());
            }
            
            var result = _ownerProductsFacad.CreateProductsServices.Execute(createProductsServicesDto);
      
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _ownerProductsFacad.GetEditProductServices.Execute(id);
            return View(result);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductsServicesDto editProductsServicesDto,int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",_ownerProductsFacad.GetEditProductServices.Execute(id));
            }
            
            var result = _ownerProductsFacad.EditProductsServices.Execute(editProductsServicesDto,id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpDelete]
        // [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var result = _ownerProductsFacad.DeleteProductServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Active(int id)
        {
            var result = _ownerProductsFacad.ActiveProductServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public JsonResult GetReturnSubMenuAjax(int id)
        {
            var result = _ownerProductsFacad.GetReturnSubMenusAjaxServices.Execute(id);
            return Json(result.SubMenus);
        }
        
        
        
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public JsonResult GetReturnSubSubMenuAjax(int id)
        {
            var result = _ownerProductsFacad.GetReturnSubSubMenusAjaxServices.Execute(id);
            return Json(result.SubSubMenus);
        }
        
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetReturnCompanyAjax(int id)
        {
            var result = _ownerProductsFacad.GetReturnCompanyAjaxServices.Execute(id);
            return Json(result.CompanyMenus);
        }


    }
}