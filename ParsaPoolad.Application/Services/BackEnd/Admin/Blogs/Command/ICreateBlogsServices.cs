using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command
{
    public interface ICreateBlogsServices
    {
        ResultCreateBlogsDto Execute(CreateBlogsServicesDto createBlogsServicesDto);
    }

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


    public class ResultCreateBlogsDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    internal class UploadDto
    {
        public bool Status { get; set; }
        public string FileNameAddress { get; set; }
    }

    public class CreateBlogsServicesDto
    {
        public int NewsId { get; set; }

        [Display(Name = "نوع بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int NewsGroupId { get; set; }

        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(200, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string Title { get; set; }

        [Display(Name = "توضیح کوتاه بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string NewsSummery { get; set; }

        [Display(Name = "متن بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string NewsBody { get; set; }
        
        [Display(Name = "تصویر بلاگ")]
        [Required(ErrorMessage = "لطفا یک {0} انتخاب کنید")]
        [DataType(DataType.Upload)]
        // [FileExtensions(Extensions = ".png,.jpg,.jpeg,.gif", ErrorMessage = "فرمت عکس نامعتبر است")]
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }
}