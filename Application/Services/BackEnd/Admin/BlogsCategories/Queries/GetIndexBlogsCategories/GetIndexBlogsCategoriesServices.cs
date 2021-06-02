using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories
{
    public class GetIndexBlogsCategoriesServices : IGetIndexBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexBlogsCategoriesDto Execute()
        {
            var blogsCategories = _context.CrmCmsNewsGroups
                .OrderByDescending(n=> n.NewsGroupId)
                .ToList();

            return new ResultGetIndexBlogsCategoriesDto
            {
                BlogsCategories = blogsCategories,
            };
        }
    }
}