using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Queries
{
    public interface IGetEditBlogsServices
    {
        ResultGetEditBlogsDto Execute(int id);
    }

    public class GetEditBlogsServices : IGetEditBlogsServices
    {
        private readonly IDataBaseContext _context;

        public GetEditBlogsServices(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditBlogsDto Execute(int id)
        {
            var blog = _context.CrmCmsNews
                .Where(n => n.NewsId == id)
                .Include(n=>n.NewsGroup)
                .Select(n => new GetEditBlogsDto
                {
                    NewsId=n.NewsId,
                    NewsGroupId=n.NewsGroupId,
                    NewsGroupName = n.NewsGroup.GroupName,
                    Title = n.Title,
                    NewsBody=n.NewsBody,
                    NewsSummery=n.NewsSummery,
                    RegisterDatePersian = n.FirstRegisterDatePersian,
                    IsVerified = n.IsVerified,
                    Position=n.Position
                }).FirstOrDefault();
            
            var blogsGroup = _context.CrmCmsNewsGroups.ToList();

            return new ResultGetEditBlogsDto
            {
                Blog = blog,
                BlogsGroup = blogsGroup,
            };
            
        }
        
    }

    public class ResultGetEditBlogsDto
    {
        public GetEditBlogsDto Blog { get; set; }
        public List<CrmCmsNewsGroups> BlogsGroup { get; set; }
        
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public int NewsGroupId { get; set; }
        // public IFormFile Images { get; set; }
        
        public int Position { get; set; }
    }
    
    public class GetEditBlogsDto
    {
        public int NewsId { get; set; }
        public string NewsGroupName { get; set; }
        public string RegisterDatePersian { get; set; }
        public bool? IsVerified { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public int NewsGroupId { get; set; }
        public int Position { get; set; }
    }
}