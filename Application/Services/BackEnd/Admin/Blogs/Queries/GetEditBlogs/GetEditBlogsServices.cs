using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs
{
    public class GetEditBlogsServices : IGetEditBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetEditBlogsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public ResultGetEditBlogsDto Execute(int id)
        {

            // var blog = _customDbContext.CrmCmsNews
            //     .Where(n => n.NewsId == id)
            //     .Include(n=>n.NewsGroup)
            //     .Select(n => new GetEditBlogsDto
            //     {
            //         NewsId=n.NewsId,
            //         NewsGroupId=n.NewsGroupId,
            //         NewsGroupName = n.NewsGroup.GroupName,
            //         Title = n.Title,
            //         NewsBody=n.NewsBody,
            //         NewsSummery=n.NewsSummery,
            //         RegisterDatePersian = n.FirstRegisterDatePersian,
            //         IsVerified = n.IsVerified,
            //         Position=n.Position,
            //         RequestToAuthorFav=n.RequestToAuthorFav
            //     }).FirstOrDefault();
            
            var blogModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav!=true)
                .OrderByDescending(s => s.Id)
                .Take(18);
            var blog = _mapper.Map<GetEditBlogsDto>(blogModel);

            var blogsGroup = _customDbContext.BlogCategories.ToList();

            return new ResultGetEditBlogsDto
            {
                Blog = blog,
                BlogsGroup = blogsGroup,
            };
            
        }
        
    }
}