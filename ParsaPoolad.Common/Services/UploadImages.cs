using System;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ParsaPoolad.Common.Services
{
    [Authorize(Policy = "SeniorProgrammer")]
    [Route("panel/admin/upload/images")]
    public class UploadImages
    {
        public readonly IHostingEnvironment _environment;
        public UploadImages(IHostingEnvironment environment)
        {
            _environment = environment;
        }
        public UploadDto UplaodFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
                return new UploadDto()
                {
                    Status = false,
                    FileNameAddress = "",
                };
            
            
            string folder = @"Images/CkEditor/";
            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
            if (!Directory.Exists(uploadsRootFolder))
            {
                Directory.CreateDirectory(uploadsRootFolder);
            }

            string fileName = DateTime.Now.Ticks + file.FileName;
            var filePath = Path.Combine(uploadsRootFolder, fileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fileStream);

            return new UploadDto()
            {
                Status = true,
                FileNameAddress = folder + fileName,
            };

        }
    }

 

    public class UploadDto
    {
        public bool Status { get; set; }
        public string FileNameAddress { get; set; }
    }

    
}