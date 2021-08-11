using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("panel/admin/blog-categories/[action]/{id?}")]
    public class BlogsCategoriesController : Controller
    {
        private readonly IBlogsCategoriesFacad _blogsCategoriesFacad;

        public BlogsCategoriesController(IBlogsCategoriesFacad blogsCategoriesFacad)
        {
            _blogsCategoriesFacad = blogsCategoriesFacad;
        }

        [Authorize(Policy = "BlogCategoriesIndex")]
        public IActionResult Index()
        {
            var result = _blogsCategoriesFacad.GetIndexBlogsCategoriesServices.Execute();
            return View(result);
        }


        [Authorize(Policy = "BlogCategoriesCreate")]
        [HttpGet]
        public IActionResult Create()
        {
            var result = _blogsCategoriesFacad.GetCreateBlogsCategoriesServices.Execute();

            return View(result);
        }

        [Authorize(Policy = "BlogCategoriesCreate")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", _blogsCategoriesFacad.GetCreateBlogsCategoriesServices.Execute());
            }

            var result = _blogsCategoriesFacad.CreateBlogsCategoriesServices.Execute(createBlogCategoryDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }


        [Authorize(Policy = "BlogCategoriesEdit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _blogsCategoriesFacad.GetEditBlogsCategoriesServices.Execute(id);
            return View(result.Data);
        }

        [Authorize(Policy = "BlogCategoriesEdit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditBlogCategoryDto editBlogCategoryDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", _blogsCategoriesFacad.GetEditBlogsCategoriesServices.Execute(editBlogCategoryDto.Id).Data);
            }

            var result = _blogsCategoriesFacad.EditBlogsCategoriesServices.Execute(editBlogCategoryDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "BlogCategoriesDelete")]
        public IActionResult Delete(int id)
        {
            var result = _blogsCategoriesFacad.DeleteBlogsCategoriesServices.Execute(id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

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