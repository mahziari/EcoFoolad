using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command;
using ParsaPoolad.Domain.Entities;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
    [Area("Admin")]
    [Route("panel/admin/blog/[action]/{id?}")]
    public class BlogsController: Controller
    {
        private readonly IBlogsFacad _blogsFacad;

        public BlogsController(IBlogsFacad blogsFacad)
        {
            _blogsFacad = blogsFacad;
        }


        public IActionResult Index()
        {
            var result = _blogsFacad.GetIndexBlogsServices.Execute();
            return View(result);
        }
        
        
        
        public IActionResult Details(int id)
        {
            var result = _blogsFacad.GetDetailsBlogsServices.Execute(id);
            return View(result);
        }
        
        
        
        public IActionResult Create()
        {
            var result = _blogsFacad.GetCreateBlogsServices.Execute();
           
            return View(result);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBlogsServicesDto createBlogsServicesDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Create",_blogsFacad.GetCreateBlogsServices.Execute());
            }
            
            var result = _blogsFacad.CreateBlogsServices.Execute(createBlogsServicesDto);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
            
        }
        
        
        
        public IActionResult Edit(int id)
        {
            var result = _blogsFacad.GetEditBlogsServices.Execute(id);
            return View(result);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CreateBlogsServicesDto createBlogsServicesDto,CrmCmsNews crmCmsNews,int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",_blogsFacad.GetEditBlogsServices.Execute(id));
            }
            
            var result = _blogsFacad.EditBlogsServices.Execute(createBlogsServicesDto,crmCmsNews,id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        public IActionResult Delete(int id)
        {
            var result = _blogsFacad.DeleteBlogsServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }
        
        
        public IActionResult Active(int id)
        {
            var result = _blogsFacad.ActiveBlogsServices.Execute(id);
        
            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message; 
            
            return RedirectToAction(nameof(Index));
        }

    }
}