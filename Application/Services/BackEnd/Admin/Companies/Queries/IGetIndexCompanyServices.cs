using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Company.Queries
{
    public interface IGetIndexCompanyServices
    {
        ResultGetIndexCompanyDto Execute();
    }

    public class GetIndexCompanyServices : IGetIndexCompanyServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexCompanyDto Execute()
        {
            var company = _context.CrmCompany
                .OrderByDescending(c=>c.CompanyId)
                .Select(c=>new GetIndexCompanyDto
                {
                    CompanyId=c.CompanyId,
                    CmpName=c.CmpName,
                    MenuName=c.ParsaPooladMenus.Name,
                    IsFactory= c.IsFactory,
                }).ToList();
            
            
            return new ResultGetIndexCompanyDto
            {
                Company = company,
            };
        }
    }

    public class ResultGetIndexCompanyDto
    {
        public List<GetIndexCompanyDto> Company { get; set; }
    }

    public class GetIndexCompanyDto
    {
        public int CompanyId { get; set; }
        public string CmpName { get; set; }
        public string MenuName { get; set; }
        public bool IsFactory { get; set; }
    }

}