using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Application.Interfaces.Contexts;
using Domain.Entities;
using Domain.Entities.Orders;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;

namespace Application.Services.BackEnd.Admin.FileManager
{
    public interface IImageUploadService
    {
        UploadDto Upload(MultiImageDto multiImageDto);
        BaseDto<ListFilesDto> GetAllFileManager();
    }
    
    public class ImageUploadService : IImageUploadService
    {
        
        private readonly IWebHostEnvironment _environment;
        private readonly ICustomDbContext _customDbContext;
        public ImageUploadService(IWebHostEnvironment environment, ICustomDbContext customDbContext)
        {
            _environment = environment;
            _customDbContext = customDbContext;
        }
        
        public UploadDto Upload(MultiImageDto multiImageDto)
        {
            string newName = Guid.NewGuid().ToString();
            var date = DateTime.Now;
            string folder = $@"BackEnd/Admin/images/fileManager/{date.Year}/{date.Year}-{date.Month}/";
            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
            if (!Directory.Exists(uploadsRootFolder))
            {
                Directory.CreateDirectory(uploadsRootFolder);
            }
            
            List<string> address = new List<string>();
            List<string> type = new List<string>();
            foreach (var file in multiImageDto.files)
            {
                if (file != null && file.Length > 0)
                {
                    string fileName = newName + file.FileName;
                    var filePath = Path.Combine(uploadsRootFolder, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    address.Add(folder + fileName);
                }
            }
            return new UploadDto()
            {
                FileNameAddress=address,
                IsSuccess=true,
                Message="فایل ها با موفقیت آپلود شدند",
            };
        }


        public BaseDto<ListFilesDto> GetAllFileManager()
        {
            var allFiles = _customDbContext.FileManagers.OrderByDescending(p=>p.Id).ToList();
            return new BaseDto<ListFilesDto>
            (
                true,
                null,
                new ListFilesDto()
                {
                    FileAddress = allFiles
                }
            );
        }

    }

    public class MultiImageDto
    {
        [Display(Name = "فایل ")]
        [Required(ErrorMessage = "لطفا یک {0} انتخاب کنید")]
        public IFormFileCollection files { get; set; }
    }


    public class UploadDto
    {
        public List<string> FileNameAddress { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class ListFilesDto
    {
        public List<Domain.Entities.FileManager.FileManager> FileAddress { get; set; }
        public string Address { get; set; }
    }
    
    public class FileManagerDto
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string? Title { get; set; }
    }




}
