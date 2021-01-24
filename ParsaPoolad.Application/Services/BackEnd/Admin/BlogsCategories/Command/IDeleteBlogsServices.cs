using System.IO;
using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Command
{
    public interface IDeleteBlogsCategoriesServices
    {
        ResultDeleteBlogsCategoriesDto Execute(int id);
    }
    public class DeleteBlogsCategoriesServices : IDeleteBlogsCategoriesServices
    {
        private readonly IDataBaseContext _context;

        public DeleteBlogsCategoriesServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDeleteBlogsCategoriesDto Execute(int id)
        {
            var blogCategory = _context.CrmCmsNewsGroups.Find(id);
            
            if (blogCategory == null)
            {
                return new ResultDeleteBlogsCategoriesDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            _context.CrmCmsNewsGroups.Remove(blogCategory);
            _context.SaveChanges();
            return new ResultDeleteBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }

    public class ResultDeleteBlogsCategoriesDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}