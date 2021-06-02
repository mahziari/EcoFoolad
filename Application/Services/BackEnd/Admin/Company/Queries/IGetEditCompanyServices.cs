using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Company.Queries
{
    public interface IGetEditCompanyServices
    {
        ResultGetEditCompanyDto Execute(int id);
    }

    public class GetEditCompanyServices : IGetEditCompanyServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditCompanyDto Execute(int id)
        {
            var company = _context.CrmCompany
                .Where(c=>c.CompanyId==id)
                .Select(c=>new GetEditCompanyDto
                {
                    CompanyId=c.CompanyId,
                    CmpName=c.CmpName,
                    MenuName=c.ParsaPooladMenus.Name,
                    ParsaPooladMenusId=c.ParsaPooladMenusId
                }).FirstOrDefault();
            
            var parsaPooladMenus = _context.ParsaPooladMenus.ToList();

            return new ResultGetEditCompanyDto
            {
                Company= company,
                ParsaPooladMenus= parsaPooladMenus,
            };
            
        }
        
    }

    public class ResultGetEditCompanyDto
    {
        public GetEditCompanyDto Company { get; set; }
        public List<ParsaPooladMenus> ParsaPooladMenus { get; set; }
        public string CmpName { get; set; }
        public string MenuName { get; set; }
        public int ParsaPooladMenusId { get; set; }
    }

    public class GetEditCompanyDto
    {
        public int CompanyId { get; set; }
        public string CmpName { get; set; }
        public string MenuName { get; set; }
        public int? ParsaPooladMenusId { get; set; }
    }
}