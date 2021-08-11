using System.Collections.Generic;
using System.IO;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.FileManagers;
using Domain.Entities;
using Domain.Entities.FileManagers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "FileManagers")]
    [Route("panel/admin/file-manager/[action]/{id?}")]
    public class FileManagerController:Controller
    {

        private readonly IFileManagerFacad _fileManagerFacad;
        private readonly ICustomDbContext _customDbContext;

        public FileManagerController(IFileManagerFacad fileManagerFacad, ICustomDbContext customDbContext)
        {
            _fileManagerFacad = fileManagerFacad;
            _customDbContext = customDbContext;
        }

        public IActionResult Index()
        {
            var data = _fileManagerFacad.ImageUploadService.GetAllFileManager();
            return View(data.Data);
        }


        // public IActionResult Create()
        // {
        //     return View();
        // }
        
        [HttpPost]
        public IActionResult Create(MultiImageDto multiImageDto)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                // return new JsonResult(new BaseDto<int>(false, allErrors.Select(p => p.ErrorMessage).ToList(), 0));
                
                TempData["IsSuccess"] = false;
                TempData["Message"] = allErrors.Select(p => p.ErrorMessage).FirstOrDefault();

                return RedirectToAction(nameof(Index));
            }
            
            // var files = Request.Form.multiImageDto;
            if (multiImageDto.files != null)
            {
                //upload
                var uploadRtesult = _fileManagerFacad.ImageUploadService.Upload(multiImageDto);
                foreach (var item in uploadRtesult.FileData)
                {
                    var data = new FileManager
                    {
                        Address = item,
                    };
                    
                    _customDbContext.FileManagers.Add(data);
                    _customDbContext.SaveChanges();
                }
                
                TempData["IsSuccess"] = uploadRtesult.IsSuccess;
                TempData["Message"] = uploadRtesult.Message;

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}