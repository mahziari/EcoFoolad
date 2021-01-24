using System;
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
        ResultEditBlogsDto Execute(CreateBlogsServicesDto createBlogsServicesDto,CrmCmsNews crmCmsNews,int id);
    }

    public class EditBlogsServices:IEditBlogsServices {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;

        public EditBlogsServices(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }

        public ResultEditBlogsDto Execute(CreateBlogsServicesDto createBlogsServicesDto,CrmCmsNews crmCmsNews,int id)
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
            
            var uploadedResult = UploadFile(createBlogsServicesDto.Images);

            // if (uploadedResult.Status != true)
            // {
            //     return new ResultEditBlogsDto
            //     {
            //         IsSuccess = false,
            //         Message = "لطفا یک عکس انتخاب کنید"
            //     };
            // }

          
            
            var blog = _context.CrmCmsNews.Find(id);

            string file =blog.HeadLine;
            string folder = _environment.WebRootPath;
            var filePath = Path.Combine(_environment.WebRootPath, file);
            var fileStream = new FileInfo(filePath);
            if (fileStream.Exists)
            {
                fileStream.Delete();
            }
            

            blog.NewsGroupId = crmCmsNews.NewsGroupId;
            blog.Title = crmCmsNews.Title;
            blog.NewsSummery = crmCmsNews.NewsSummery;
            blog.HeadLine = uploadedResult.FileNameAddress;
            blog.NewsBody = createBlogsServicesDto.NewsBody;
            blog.Position = createBlogsServicesDto.Position;
            _context.SaveChanges();

            return new ResultEditBlogsDto
            {
                IsSuccess = true,
                Message = "بلاگ با موفقیت ویرایش شد"
            };
        }
        
        private UploadDto UploadFile(IFormFile file)
        {
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


}