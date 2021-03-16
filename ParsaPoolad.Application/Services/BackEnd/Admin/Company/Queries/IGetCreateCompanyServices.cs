using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Company.Queries
{
    public interface IGetCreateCompanyServices
    {
        ResultGetCreateCompanyDto Execute();
    }

    public class GetCreateCompanyServices : IGetCreateCompanyServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetCreateCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCreateCompanyDto Execute()
        {
            var companyGroup = _context.CrmCmsNewsGroups
                .Select(g=>new GetCompanyGroupsDto
                {
                    NewsGroupId = g.NewsGroupId,
                    GroupName = g.GroupName
                }).ToList();
            
            var company = _context.CrmCmsNews.ToList();

            return new ResultGetCreateCompanyDto
            {
                CompanyGroup = companyGroup,
                Company = company,
            };
        }
    }

    public class ResultGetCreateCompanyDto
    {
        public List<GetCompanyGroupsDto> CompanyGroup { get; set; }
        public List<CrmCmsNews> Company { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }
    
    public class GetCompanyGroupsDto
    {
        public int NewsGroupId { get; set; }
        public string GroupName { get; set; }

    }
}