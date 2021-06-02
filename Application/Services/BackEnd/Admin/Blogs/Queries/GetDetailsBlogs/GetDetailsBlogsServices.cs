using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs
{
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
}