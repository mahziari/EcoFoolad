using System.IO;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs
{
    public class DeleteBlogsServices : IDeleteBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IWebHostEnvironment _environment;

        public DeleteBlogsServices(IIdealCrmDataBaseContext context,IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }

        public ResultDeleteBlogDto Execute(int id)
        {
            var blog = _context.CrmCmsNews.Find(id);

            if (blog == null)
            {
                return new ResultDeleteBlogDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            string file =blog.HeadLine;
            string folder = _environment.WebRootPath;
            var filePath = Path.Combine(_environment.WebRootPath, file);
            var fileStream = new FileInfo(filePath);
            if (fileStream.Exists)
            {
                fileStream.Delete();
            }
            
            
            
            _context.CrmCmsNews.Remove(blog);
            _context.SaveChanges();
            return new ResultDeleteBlogDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}