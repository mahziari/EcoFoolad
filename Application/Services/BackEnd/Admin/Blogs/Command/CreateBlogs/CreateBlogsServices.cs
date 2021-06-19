using System;
using System.IO;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
 
using  Domain.Entities.IdealCrm;
using Microsoft.AspNetCore.Mvc;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs
{
    public class CreateBlogsServices : ICreateBlogsServices
    {

        private readonly IIdealCrmDataBaseContext _context;
        private readonly IWebHostEnvironment _environment;
        public CreateBlogsServices(IIdealCrmDataBaseContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultCreateBlogsDto Execute(CreateBlogsServicesDto createBlogsServicesDto)
        {


            var uploadedResult = UploadFile(createBlogsServicesDto.Images);

            if (uploadedResult.Status != true)
            {
                return new ResultCreateBlogsDto
                {
                    IsSuccess = false,
                    Message = "لطفا یک عکس انتخاب کنید"
                };
            }

            var blogs = new CrmCmsNews()
            {
                NewsGroupId = createBlogsServicesDto.NewsGroupId,
                HeadLine = uploadedResult.FileNameAddress,
                Title = createBlogsServicesDto.Title,
                NewsSummery = createBlogsServicesDto.NewsSummery,
                NewsBody = createBlogsServicesDto.NewsBody,
                Position=createBlogsServicesDto.Position,
                IsVerified = true,
                UserId = 57,
                Month1 = 6,
                FirstRegisterUserId = 57,
                PublishDateTime = DateTime.Now,
                FirstRegisterDate = DateTime.Now,
                FirstRegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                RegisterDate = DateTime.Now,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                AppType = "web",
                LanguageId = 1065
            };

            _context.CrmCmsNews.Add(blogs);
            _context.SaveChanges();

            return new ResultCreateBlogsDto
            {
                IsSuccess = true,
                Message = "بلاگ با موفقیت اضافه شد"
            };

        }

        [HttpPost]
        [Route("/Images/CkEditor")]
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