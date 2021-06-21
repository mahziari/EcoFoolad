using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Company.Command
{
    public interface IEditCompanyServices
    {
        ResultEditCompanyDto Execute(EditCompanyDto editCompanyDto,int id);
    }

    public class EditCompanyServices:IEditCompanyServices {
        private readonly IIdealCrmDataBaseContext _context;

        public EditCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultEditCompanyDto Execute(EditCompanyDto editCompanyDto,int id)
        {

            var company = _context.CrmCompany.Find(id);
            company.ParsaPooladMenusId = editCompanyDto.ParsaPooladMenusId;
            _context.SaveChanges();
            
            return new ResultEditCompanyDto
            {
                IsSuccess = true,
                Message = "ویرایش با موفقیت ویرایش شد"
            };   
        }
        
    }

    public class ResultEditCompanyDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    public class EditCompanyDto
    {
        public int? ParsaPooladMenusId { get; set; }
    }


}