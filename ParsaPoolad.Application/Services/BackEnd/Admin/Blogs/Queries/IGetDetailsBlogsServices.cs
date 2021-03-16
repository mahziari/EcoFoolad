using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Queries
{
    public interface IGetDetailsBlogsServices
    {
        ResultGetDetailsBlogsDto Execute(int id);
    }

    public class GetDetailsBlogsServices : IGetDetailsBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetDetailsBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetDetailsBlogsDto Execute(int id)
        {
            var blog = _context.CrmCmsNews
                .Where(n => n.NewsId == id)
                .Include(n=>n.NewsGroup)
                .Select(n => new GetDetailsBlogsDto
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

            return new ResultGetDetailsBlogsDto
            {
                Blog = blog,
            };
        }
    }

    public class ResultGetDetailsBlogsDto
    {
        public GetDetailsBlogsDto Blog { get; set; }
    }

    public class GetDetailsBlogsDto
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