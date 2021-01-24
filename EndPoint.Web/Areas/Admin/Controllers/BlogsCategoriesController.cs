using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Command;
using ParsaPoolad.Domain.Entities;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
    [Area("Admin")]
    [Route("panel/admin/blog-categories/[action]/{id?}")]
    public class BlogsCategoriesController: Controller
    {
        private readonly IBlogsCategoriesFacad _blogsCategoriesFacad;

        public BlogsCategoriesController(IBlogsCategoriesFacad blogsCategoriesFacad)
        {
            _blogsCategoriesFacad = blogsCategoriesFacad;
        }


        public IActionResult Index()
        {
            var result = _blogsCategoriesFacad.GetIndexBlogsCategoriesServices.Execute();
            return View(result);
        }
        
        
        
      
        
        
        
        public IActionResult Create()
        {
            var result = _blogsCategoriesFacad.GetCreateBlogsCategoriesServices.Execute();
           
            return View(result);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_blogsCategoriesFacad.GetCreateBlogsCategoriesServices.Execute());
            }
            
            var result = _blogsCategoriesFacad.CreateBlogsCategoriesServices.Execute(createBlogsCategoriesServicesDto);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
            
        }
        
        
        
        public IActionResult Edit(int id)
        {
            var result = _blogsCategoriesFacad.GetEditBlogsCategoriesServices.Execute(id);
            return View(result);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto,CrmCmsNewsGroups crmCmsNewsGroups,int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",_blogsCategoriesFacad.GetEditBlogsCategoriesServices.Execute(id));
            }
            
            var result = _blogsCategoriesFacad.EditBlogsCategoriesServices.Execute(createBlogsCategoriesServicesDto,crmCmsNewsGroups,id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        public IActionResult Delete(int id)
        {
            var result = _blogsCategoriesFacad.DeleteBlogsCategoriesServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        //
        // public IActionResult Active(int id)
        // {
        //     var result = _blogsCategoriesFacad.ActiveBlogsCategoriesServices.Execute(id);
        //
        //     TempData["IsSuccess"] = result.IsSuccess;
        //     TempData["Message"] = result.Message; 
        //     
        //     return RedirectToAction(nameof(Index));
        // }

    }
}