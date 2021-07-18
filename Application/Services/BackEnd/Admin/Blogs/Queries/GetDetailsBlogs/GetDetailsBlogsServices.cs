using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs
{
    public class GetDetailsBlogsServices : IGetDetailsBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetDetailsBlogsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public ResultGetDetailsBlogsDto Execute(int id)
        {
            // var blog = _customDbContext.Blogs
            //     .Where(n => n.NewsId == id)
            //     .Include(n=>n.NewsGroup)
            //     .Select(n => new GetDetailsBlogsDto
            //     {
            //         NewsGroupName = n.NewsGroup.GroupName,
            //         Title = n.Title,
            //         NewsSummery=n.NewsSummery,
            //         RegisterDatePersian = n.FirstRegisterDatePersian,
            //         IsVerified = n.IsVerified,
            //         HeadLine=n.HeadLine,
            //         NewsBody = n.NewsBody,
            //         Position=n.Position,
            //     }).FirstOrDefault();
            
            var blogModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav!=true)
                .OrderByDescending(s => s.Id)
                .Take(18);
            var blog = _mapper.Map<GetDetailsBlogsDto>(blogModel);

            return new ResultGetDetailsBlogsDto
            {
                Blog = blog,
            };
        }
    }
}