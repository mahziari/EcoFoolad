using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Command
{
    public interface IActiveBlogsCategoriesServices
    {
        ResultActiveBlogsCategoriestDto Execute(int id);
    }
    public class ActiveBlogsCategoriesServices : IActiveBlogsCategoriesServices
    {
        private readonly IDataBaseContext _context;

        public ActiveBlogsCategoriesServices(IDataBaseContext context)
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

    public class ResultActiveBlogsCategoriestDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}