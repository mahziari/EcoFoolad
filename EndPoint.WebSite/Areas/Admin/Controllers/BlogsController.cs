using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Blogs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("panel/admin/blog/[action]/{id?}")]
    public class BlogsController : Controller
    {
        private readonly IBlogsFacad _blogsFacad;

        public BlogsController(IBlogsFacad blogsFacad)
        {
            _blogsFacad = blogsFacad;
        }

        [Authorize(Policy = "BlogsIndex")]
        public IActionResult Index()
        {
            var result = _blogsFacad.GetIndexBlogsServices.Execute();
            return View(result);
        }


        [Authorize(Policy = "BlogsIndex")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = _blogsFacad.GetDetailsBlogsServices.Execute(id);
            return View(result.Data);
        }


        [Authorize(Policy = "BlogsCreate")]
        [HttpGet]
        public IActionResult Create()
        {
            var result = _blogsFacad.GetCreateBlogsServices.Execute();

            return View(result);
        }

        [Authorize(Policy = "BlogsCreate")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogDto blogDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", _blogsFacad.GetCreateBlogsServices.Execute());
            }

            var result = _blogsFacad.CreateBlogsServices.Execute(blogDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }


        [Authorize(Policy = "BlogsEdit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _blogsFacad.GetEditBlogsServices.Execute(id);
            return View(result);
        }

        [Authorize(Policy = "BlogsEdit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogDto blogDto)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", _blogsFacad.GetEditBlogsServices.Execute(blogDto.Id));
            }

            var result = _blogsFacad.EditBlogsServices.Execute(blogDto);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "BlogsDelete")]
        public IActionResult Delete(int id)
        {
            var result = _blogsFacad.DeleteBlogsServices.Execute(id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "BlogsActive")]
        public IActionResult Active(int id)
        {
            var result = _blogsFacad.ActiveBlogsServices.Execute(id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message[0];

            return RedirectToAction(nameof(Index));
        }
    }
}