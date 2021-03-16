using System.IO;
using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command
{
    public interface IDeleteBlogsServices
    {
        ResultDeleteBlogDto Execute(int id);
    }
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

    public class ResultDeleteBlogDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}