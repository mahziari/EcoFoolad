using System.IO;
using Application.Interfaces.Contexts;
using AutoMapper;
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

        public ResultDeleteBlogDto Execute(int id)
        {
            var blog = _customDbContext.Blogs.Find(id);

            if (blog == null)
            {
                return new ResultDeleteBlogDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
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
            return new ResultDeleteBlogDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}