 

using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.ActiveBlogsCategories
{
    public class ActiveBlogsCategoriesServices : IActiveBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;

        public ActiveBlogsCategoriesServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }

        public BaseDto<BlogCategoryDto> Execute(int id)
        {
            var blog = _customDbContext.Blogs.Find(id);

            if (blog == null)
            {
                return new BaseDto<BlogCategoryDto>
                (
                    false,
                    new List<string> {"یافت نشد"},
                    null
                );
            }

            if (blog.IsVerified == false)
            {
                blog.IsVerified = true;  
            }
            else if(blog.IsVerified)
            {
                blog.IsVerified = false;
            }
            _customDbContext.SaveChanges();

            return new BaseDto<BlogCategoryDto>
            (
                false,
                new List<string> {"تغییر وضعیت با موفقیت انجام شد"},
                null
            );
        }

    }
}