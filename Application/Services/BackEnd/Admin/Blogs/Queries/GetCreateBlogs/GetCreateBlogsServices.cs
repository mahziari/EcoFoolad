using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public class GetCreateBlogsServices : IGetCreateBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;

        public GetCreateBlogsServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }


        public ResultGetCreateBlogsDto Execute()
        {
            var blogCategory = _customDbContext.BlogCategories
                .Select(g=>new GetBlogCategoryDto
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList();
            
            var blogs = _customDbContext.Blogs.ToList();

            return new ResultGetCreateBlogsDto
            {
                BlogCategory = blogCategory,
                Blogs = blogs,
            };
        }
    }
}