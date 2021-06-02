 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.ActiveBlogsCategories
{
    public class ActiveBlogsCategoriesServices : IActiveBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public ActiveBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultActiveBlogsCategoriestDto Execute(int id)
        {
            var blog = _context.CrmCmsNews.Find(id);

            if (blog == null)
            {
                return new ResultActiveBlogsCategoriestDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            if (blog.IsVerified == false)
            {
                blog.IsVerified = true;  
            }
            else if(blog.IsVerified == true)
            {
                blog.IsVerified = false;
            }
            _context.SaveChanges();

            return new ResultActiveBlogsCategoriestDto()
            {
                IsSuccess = true,
                Message = "تغییر وضعیت با موفقیت انجام شد"
            };
        }

    }
}