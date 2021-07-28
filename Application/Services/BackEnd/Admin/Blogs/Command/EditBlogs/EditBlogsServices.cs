using System;
using System.Collections.Generic;
using System.IO;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using AutoMapper;
using Common.Utilities;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs
{
    public class EditBlogsServices : IEditBlogsServices
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        private readonly ICustomDbContext _customDbContext;
        private readonly IHttpContextAccessor _httpContext;

        public EditBlogsServices(IWebHostEnvironment environment, IMapper mapper, ICustomDbContext customDbContext,
            IHttpContextAccessor httpContext)
        {
            _environment = environment;
            _mapper = mapper;
            _customDbContext = customDbContext;
            _httpContext = httpContext;
        }

        public BaseDto Execute(BlogDto blogDto)
        {
            var blogModel = _customDbContext.Blogs.Find(blogDto.Id);

            var uploadedResult = UploadFile(blogDto.Image, blogModel.ImageUrl);
            

            blogDto.LocalTime = DateTime.Now.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM();
            blogDto.RegisterUserId = ClaimUtility.GetUserId(_httpContext.HttpContext?.User);
            blogDto.IsVerified = true;
            if (uploadedResult.FileNameAddress != "ImageNotChange")
            {
                blogDto.ImageUrl = uploadedResult.FileNameAddress;
            }
            
            _mapper.Map(blogDto, blogModel);
            _customDbContext.SaveChanges();

            return new BaseDto
            (
                true,
                new List<string> {"مجله با موفقیت ویرایش شد"}
            );
        }

        private UploadDto UploadFile(IFormFile file, string ImageUrl)
        {
            if (file == null || file.Length <= 0)
                return new UploadDto()
                {
                    Status = true,
                    FileNameAddress = "ImageNotChange",
                };

            if (ImageUrl !=null ||  file.Length > 0)
            {
                // Delete Old Image Source
                var oldFile = ImageUrl;
                var oldFilePath = Path.Combine(_environment.WebRootPath, oldFile);
                var oldFileStream = new FileInfo(oldFilePath);
                if (oldFileStream.Exists)
                {
                    oldFileStream.Delete();
                }
            }
            
            
            // Upload Image Source
            string folder = @"Images/Blogs/";
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
}