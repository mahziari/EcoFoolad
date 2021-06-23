using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public class GetCreateBlogsServices : IGetCreateBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetCreateBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCreateBlogsDto Execute()
        {
            var blogsGroup = _context.CrmCmsNewsGroups
                .Select(g=>new GetBlogsGroupsDto
                {
                    NewsGroupId = g.NewsGroupId,
                    GroupName = g.GroupName
                }).ToList();
            
            // var blogs = _context.CrmCmsNews.Where(p=>p.Position==0).ToList();
            var blogs = _context.CrmCmsNews.ToList();

            return new ResultGetCreateBlogsDto
            {
                BlogsGroup = blogsGroup,
                Blogs = blogs,
            };
        }
    }
}