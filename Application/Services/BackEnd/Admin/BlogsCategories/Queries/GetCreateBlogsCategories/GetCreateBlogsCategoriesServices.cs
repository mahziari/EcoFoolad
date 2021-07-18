 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetCreateBlogsCategories
{
    public class GetCreateBlogsCategoriesServices : IGetCreateBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;

        public GetCreateBlogsCategoriesServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }


        public ResultGetCreateBlogsCategoriesDto Execute()
        {
            // var blogsCategories = _context.CrmCmsNewsGroups
            //     .Select(g=>new GetBlogsCategoriesGroupsDto
            //     {
            //         BlogsGroupId = g.NewsGroupId,
            //         GroupName = g.GroupName,
            //     }).ToList();
            //

            return new ResultGetCreateBlogsCategoriesDto
            {
                // BlogsCategories = blogsCategories,
            };
        }
    }
}