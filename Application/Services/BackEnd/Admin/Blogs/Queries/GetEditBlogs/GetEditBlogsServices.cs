using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs
{
    public class GetEditBlogsServices : IGetEditBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditBlogsDto Execute(int id)
        {

            var blog = _context.CrmCmsNews
                .Where(n => n.NewsId == id)
                .Include(n=>n.NewsGroup)
                .Select(n => new GetEditBlogsDto
                {
                    NewsId=n.NewsId,
                    NewsGroupId=n.NewsGroupId,
                    NewsGroupName = n.NewsGroup.GroupName,
                    Title = n.Title,
                    NewsBody=n.NewsBody,
                    NewsSummery=n.NewsSummery,
                    RegisterDatePersian = n.FirstRegisterDatePersian,
                    IsVerified = n.IsVerified,
                    Position=n.Position,
                    RequestToAuthorFav=n.RequestToAuthorFav
                }).FirstOrDefault();

            var blogsGroup = _context.CrmCmsNewsGroups.ToList();

            return new ResultGetEditBlogsDto
            {
                Blog = blog,
                BlogsGroup = blogsGroup,
            };
            
        }
        
    }
}