using System.Collections.Generic;
using System.IO;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Company.Command;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Dtos;
using Microsoft.AspNetCore.Hosting;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs
{
    public class DeleteBlogsServices : IDeleteBlogsServices
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        private readonly ICustomDbContext _customDbContext;
        public DeleteBlogsServices(IWebHostEnvironment environment, IMapper mapper, ICustomDbContext customDbContext)
        {
            _environment = environment;
            _mapper = mapper;
            _customDbContext = customDbContext;
        }

        public BaseDto Execute(int id)
        {
            var blog = _customDbContext.Blogs.Find(id);

            if (blog == null)
            {
                return new BaseDto
                (
                    false,
                    new List<string> {"یافت نشد"}
                );
            }
            
            string file =blog.ImageUrl;
            string folder = _environment.WebRootPath;
            var filePath = Path.Combine(_environment.WebRootPath, file);
            var fileStream = new FileInfo(filePath);
            if (fileStream.Exists)
            {
                fileStream.Delete();
            }
            
            
            
            _customDbContext.Blogs.Remove(blog);
            _customDbContext.SaveChanges();
            return new BaseDto
            (
                true,
                new List<string> {"با موفقست حذف شد"}
            );
        }

    }
}