using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;

namespace EndPoint.Web.Areas.Admin.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
    [Area("Admin")]
    [Route("panel/admin/menus/[action]/{id?}")]
    public class MenusController : Controller
    {
        private readonly IMenusFacad _menusFacad;

        public MenusController(IMenusFacad menusFacad)
        {
            _menusFacad = menusFacad;
        }

        public IActionResult Index()
        {
            var result = _menusFacad.GetMenusService.Execute();
            return View(result);
        }


        //----------> Menus

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMenu(int id, string name)
        {
            var result = _menusFacad.CreateNewMenusServices.Execute(id, name);


            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetEditMenu(int id)
        {
            var result = _menusFacad.GetEditMenusService.Execute(id);
            ViewBag.Id = result.PrdFirstGroupId;
            ViewBag.Fgname = result.Fgname;
            return View();
        }

        // [HttpGet]
        // [ValidateAntiForgeryToken]
        public IActionResult EditMenu(string name, int id)
        {
            var result = _menusFacad.EditMenusServices.Execute(name, id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMenu(int id)
        {
            var result = _menusFacad.RemoveMenusServices.Execute(id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }


        //----------> Sub Menus

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSubMenu(int id, string name)
        {
            var result = _menusFacad.CreateNewSubMenusServices.Execute(id, name);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetEditSubMenu(int id)
        {
            var result = _menusFacad.GetEditSubMenusService.Execute(id);
            ViewBag.Id = result.PrdSecondGroupId;
            ViewBag.Sgname = result.Sgname;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSubMenu(string name, int id)
        {
            var result = _menusFacad.EditSubMenusServices.Execute(name, id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }

        // [HttpGet]
        // [ValidateAntiForgeryToken]
        public IActionResult DeleteSubMenu(int id)
        {
            var result = _menusFacad.RemoveSubMenusServices.Execute(id);

            TempData["IsSuccess"] = result.IsSuccess;
            TempData["Message"] = result.Message;

            return RedirectToAction(nameof(Index));
        }
    }
}