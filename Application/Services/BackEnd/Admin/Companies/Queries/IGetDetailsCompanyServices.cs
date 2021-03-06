using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Company.Queries
{
    public interface IGetDetailsCompanyServices
    {
        ResultGetDetailsCompanyDto Execute(int id);
    }

    public class GetDetailsCompanyServices : IGetDetailsCompanyServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetDetailsCompanyServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetDetailsCompanyDto Execute(int id)
        {
            var blog = _context.CrmCmsNews
                .Where(n => n.NewsId == id)
                .Include(n=>n.NewsGroup)
                .Select(n => new GetDetailsCompanyDto
                {
                    NewsGroupName = n.NewsGroup.GroupName,
                    Title = n.Title,
                    NewsSummery=n.NewsSummery,
                    RegisterDatePersian = n.FirstRegisterDatePersian,
                    IsVerified = n.IsVerified,
                    HeadLine=n.HeadLine,
                    NewsBody = n.NewsBody,
                    Position=n.Position
                }).FirstOrDefault();

            return new ResultGetDetailsCompanyDto
            {
                Blog = blog,
            };
        }
    }

    public class ResultGetDetailsCompanyDto
    {
        public GetDetailsCompanyDto Blog { get; set; }
    }

    public class GetDetailsCompanyDto
    {
        public string NewsGroupName { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string RegisterDatePersian { get; set; }
        public bool? IsVerified { get; set; }
        public string NewsBody { get; set; }
        public string HeadLine { get; set; }
        public int Position { get; set; }

    }
}