using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Queries
{
    public interface IGetCreateBlogsServices
    {
        ResultGetCreateBlogsDto Execute();
    }

    public class GetCreateBlogsServices : IGetCreateBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetCreateBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCreateBlogsDto Execute()
        {
            var blogsGroup = _context.CrmCmsNewsGroups
                .Select(g=>new GetBlogsGroupsDto
                {
                    NewsGroupId = g.NewsGroupId,
                    GroupName = g.GroupName
                }).ToList();
            
            var blogs = _context.CrmCmsNews.ToList();

            return new ResultGetCreateBlogsDto
            {
                BlogsGroup = blogsGroup,
                Blogs = blogs,
            };
        }
    }

    public class ResultGetCreateBlogsDto
    {
        public List<GetBlogsGroupsDto> BlogsGroup { get; set; }
        public List<CrmCmsNews> Blogs { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }
    
    public class GetBlogsGroupsDto
    {
        public int NewsGroupId { get; set; }
        public string GroupName { get; set; }

    }
}