using System.IO;
using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Company.Command
{
    public interface IDeleteCompanyServices
    {
        ResultDeleteBlogDto Execute(int id);
    }
    public class DeleteCompanyServices : IDeleteCompanyServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public DeleteCompanyServices(IIdealCrmDataBaseContext context)
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