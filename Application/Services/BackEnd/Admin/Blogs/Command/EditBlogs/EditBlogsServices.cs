using System;
using System.IO;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
 
using  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using AutoMapper;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs
{
    public class EditBlogsServices:IEditBlogsServices
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        private readonly ICustomDbContext _customDbContext;
        public EditBlogsServices(IWebHostEnvironment environment, IMapper mapper, ICustomDbContext customDbContext)
        {
            _environment = environment;
            _mapper = mapper;
            _customDbContext = customDbContext;
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

          
            
            var blogModel = _customDbContext.Blogs.Find(id);

        
            if (uploadedResult.FileNameAddress != "ImageNotChange")
            {
                string file =blogModel.ImageUrl;
                var filePath = Path.Combine(_environment.WebRootPath, file);
                var fileStream = new FileInfo(filePath);
                if (fileStream.Exists)
                {
                    fileStream.Delete();
                }
            }

            // blog.NewsGroupId = editBlogsServicesDto.NewsGroupId;
            // blog.Title = editBlogsServicesDto.Title;
            // blog.NewsSummery = editBlogsServicesDto.NewsSummery;
            // if (uploadedResult.FileNameAddress != "ImageNotChange")
            // {
            //     blog.HeadLine = uploadedResult.FileNameAddress;
            // }
            // blog.NewsBody = editBlogsServicesDto.NewsBody;
            // blog.Position = editBlogsServicesDto.Position;
            // blog.RequestToAuthorFav = editBlogsServicesDto.RequestToAuthorFav;
            // _context.SaveChanges();
            
            
            
            var blog = _mapper.Map<EditBlogsServicesDto>(blogModel);
            blog.UpdatedAt = DateTime.Now;
            _customDbContext.SaveChanges();
     
            

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
}