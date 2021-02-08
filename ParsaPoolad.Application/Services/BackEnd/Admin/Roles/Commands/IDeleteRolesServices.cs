using System.IO;
using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Command
{
    public interface IDeleteRolesServices
    {
        ResultDeleteRtolesCategoriesDto Execute(int id);
    }
    public class DeleteRolesServices : IDeleteRolesServices
    {
        private readonly IDataBaseContext _context;

        public DeleteRolesServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDeleteRtolesCategoriesDto Execute(int id)
        {
            var blogCategory = _context.CrmCmsNewsGroups.Find(id);
            
            if (blogCategory == null)
            {
                return new ResultDeleteRtolesCategoriesDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            _context.CrmCmsNewsGroups.Remove(blogCategory);
            _context.SaveChanges();
            return new ResultDeleteRtolesCategoriesDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }

    public class ResultDeleteRtolesCategoriesDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}