using System;
using System.IO;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Utilities;
using Domain.Entities.Blogs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs
{
    public class CreateBlogsServices : ICreateBlogsServices
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        private readonly ICustomDbContext _customDbContext;
        private readonly IHttpContextAccessor _httpContext;
        public CreateBlogsServices(IWebHostEnvironment environment, IMapper mapper, ICustomDbContext customDbContext, IHttpContextAccessor httpContext)
        {
            _environment = environment;
            _mapper = mapper;
            _customDbContext = customDbContext;
            _httpContext = httpContext;
        }

        public ResultCreateBlogsDto Execute(CreateBlogsServicesDto createBlogsServicesDto)
        {
            var uploadedResult = UploadFile(createBlogsServicesDto.Image);

            if (uploadedResult.Status != true)
            {
                return new ResultCreateBlogsDto
                {
                    IsSuccess = false,
                    Message = "لطفا یک عکس انتخاب کنید"
                };
            }
            

            var blogs = _mapper.Map<Blog>(createBlogsServicesDto);
            blogs.LocalTime = DateTime.Now.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM();
            blogs.RegisterUserId= ClaimUtility.GetUserId(_httpContext.HttpContext?.User);
            blogs.ImageUrl = uploadedResult.FileNameAddress;
            blogs.IsVerified = true;
            
            _customDbContext.Blogs.Add(blogs);
            _customDbContext.SaveChanges();
            
            return new ResultCreateBlogsDto
            {
                IsSuccess = true,
                Message = "بلاگ با موفقیت اضافه شد"
            };

        }
        
        private UploadDto UploadFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
                return new UploadDto()
                {
                    Status = false,
                    FileNameAddress = "",
                };
            
            
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