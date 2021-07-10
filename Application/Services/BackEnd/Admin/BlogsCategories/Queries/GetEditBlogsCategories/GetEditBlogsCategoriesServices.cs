using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories
{
    public class GetEditBlogsCategoriesServices : IGetEditBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditBlogsCategoriesDto Execute(int id)
        {
            var blogsCategory = _context.CrmCmsNewsGroups
                .Where(n=>n.NewsGroupId==id)
                .Select(n => new GetEditBlogsCategoriesDto
                {
                    BlogsGroupId=n.NewsGroupId,
                    GroupName=n.GroupName,
                    en_GroupName=n.en_GroupName,
                    Color=n.Color,
                    Description=n.Description,
                    FaIcon = n.FaIcon,
                    Image = n.Image
                }).FirstOrDefault();
            
            return new ResultGetEditBlogsCategoriesDto
            {
                BlogsCategory = blogsCategory,
            };
        }
    }
}