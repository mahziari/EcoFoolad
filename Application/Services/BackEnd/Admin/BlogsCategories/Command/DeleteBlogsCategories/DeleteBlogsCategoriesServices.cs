 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories
{
    public class DeleteBlogsCategoriesServices : IDeleteBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public DeleteBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultDeleteBlogsCategoriesDto Execute(int id)
        {
            var blogCategory = _context.CrmCmsNewsGroups.Find(id);
            
            if (blogCategory == null)
            {
                return new ResultDeleteBlogsCategoriesDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            _context.CrmCmsNewsGroups.Remove(blogCategory);
            _context.SaveChanges();
            return new ResultDeleteBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}