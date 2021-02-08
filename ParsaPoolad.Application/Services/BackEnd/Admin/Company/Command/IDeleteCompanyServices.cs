using System.IO;
using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Company.Command
{
    public interface IDeleteCompanyServices
    {
        ResultDeleteBlogDto Execute(int id);
    }
    public class DeleteCompanyServices : IDeleteCompanyServices
    {
        private readonly IDataBaseContext _context;

        public DeleteCompanyServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDeleteBlogDto Execute(int id)
        {
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