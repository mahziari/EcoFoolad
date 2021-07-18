 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories
{
    public class DeleteBlogsCategoriesServices : IDeleteBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;

        public DeleteBlogsCategoriesServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }


        public ResultDeleteBlogsCategoriesDto Execute(int id)
        {
            var blogCategory = _customDbContext.BlogCategories.Find(id);
            
            if (blogCategory == null)
            {
                return new ResultDeleteBlogsCategoriesDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            _customDbContext.BlogCategories.Remove(blogCategory);
            _customDbContext.SaveChanges();
            return new ResultDeleteBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}