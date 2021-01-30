using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command
{
    public interface IEditBlogsServices
    {
        ResultEditBlogsDto Execute(EditBlogsServicesDto editBlogsServicesDto,int id);
    }

    public class EditBlogsServices:IEditBlogsServices {
        private readonly IDataBaseContext _context;
        private readonly IWebHostEnvironment _environment;

        public EditBlogsServices(IDataBaseContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }

        public ResultEditBlogsDto Execute(EditBlogsServicesDto editBlogsServicesDto,int id)
        {
            // if (createBlogsServicesDto.Position != 0)
            // {
            //     for (int i = 0; i < 9; i++)
            //     {
            //         if (_context.CrmCmsNews.Where(n=>n.Position==i) != null)
            //         {
            //             return new ResultEditBlogsDto
            //             {
            //                 IsSuccess = false,
            //                 Message = "موقعیت قبلا انتخاب شده است"
            //             };
            //         }
            //     }
            // }
            
            var uploadedResult = UploadFile(editBlogsServicesDto.Images);

            // if (uploadedResult.Status != true)
            // {
            //     return new ResultEditBlogsDto
            //     {
            //         IsSuccess = false,
            //         Message = "لطفا یک عکس انتخاب کنید"
            //     };
            // }

          
            
            var blog = _context.CrmCmsNews.Find(id);

        
            if (uploadedResult.FileNameAddress != "ImageNotChange")
            {
                string file =blog.HeadLine;
                var filePath = Path.Combine(_environment.WebRootPath, file);
                var fileStream = new FileInfo(filePath);
                if (fileStream.Exists)
                {
                    fileStream.Delete();
                }
            }

            blog.NewsGroupId = editBlogsServicesDto.NewsGroupId;
            blog.Title = editBlogsServicesDto.Title;
            blog.NewsSummery = editBlogsServicesDto.NewsSummery;
            if (uploadedResult.FileNameAddress != "ImageNotChange")
            {
                blog.HeadLine = uploadedResult.FileNameAddress;
            }
            blog.NewsBody = editBlogsServicesDto.NewsBody;
            blog.Position = editBlogsServicesDto.Position;
            _context.SaveChanges();

            return new ResultEditBlogsDto
            {
                IsSuccess = true,
                Message = "بلاگ با موفقیت ویرایش شد"
            };
        }
        
        private UploadDto UploadFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
                return new UploadDto()
                {
                    Status = true,
                    FileNameAddress = "ImageNotChange",
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

    public class ResultEditBlogsDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    public class EditBlogsServicesDto
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
        // [Required(ErrorMessage = "لطفا یک {0} انتخاب کنید")]
        [DataType(DataType.Upload)]
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }


}