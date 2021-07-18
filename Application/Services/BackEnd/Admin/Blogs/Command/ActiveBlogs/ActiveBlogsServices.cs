 

using Application.Interfaces.Contexts;
using AutoMapper;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs
{
    public class ActiveBlogsServices : IActiveBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        public ActiveBlogsServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }

        public ResultActiveBlogtDto Execute(int id)
        {
            var blog = _customDbContext.Blogs.Find(id);

            if (blog == null)
            {
                return new ResultActiveBlogtDto()
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
            _customDbContext.SaveChanges();

            return new ResultActiveBlogtDto()
            {
                IsSuccess = true,
                Message = "تغییر وضعیت با موفقیت انجام شد"
            };
        }

    }
}