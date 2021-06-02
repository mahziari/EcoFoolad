 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs
{
    public class ActiveBlogsServices : IActiveBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public ActiveBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultActiveBlogtDto Execute(int id)
        {
            var blog = _context.CrmCmsNews.Find(id);

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
            _context.SaveChanges();

            return new ResultActiveBlogtDto()
            {
                IsSuccess = true,
                Message = "تغییر وضعیت با موفقیت انجام شد"
            };
        }

    }
}