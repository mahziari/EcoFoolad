using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs
{
    public class GetIndexBlogsServices : IGetIndexBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexBlogsDto Execute()
        {
            var blogs = _context.CrmCmsNews
                .Include(n=>n.NewsGroup)
                .OrderByDescending(n=> n.NewsId)
                .ToList();

            return new ResultGetIndexBlogsDto
            {
                Blogs = blogs,
            };
        }
    }
}