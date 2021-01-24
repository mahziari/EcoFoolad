using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command
{
    public interface IActiveBlogsServices
    {
        ResultActiveBlogtDto Execute(int id);
    }
    public class ActiveBlogsServices : IActiveBlogsServices
    {
        private readonly IDataBaseContext _context;

        public ActiveBlogsServices(IDataBaseContext context)
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

    public class ResultActiveBlogtDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}