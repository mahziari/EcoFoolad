using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Queries
{
    public interface IGetEditBlogsCategoriesServices
    {
        ResultGetEditBlogsCategoriesDto Execute(int id);
    }

    public class GetEditBlogsCategoriesServices : IGetEditBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetEditBlogsCategoriesDto Execute(int id)
        {
            var blogsCategory = _context.CrmCmsNewsGroups
                .Where(n=>n.NewsGroupId==id)
                .Select(n => new GetEditBlogsCategoriesDto
                {
                    BlogsGroupId=n.NewsGroupId,
                    GroupName=n.GroupName,
                    en_GroupName=n.en_GroupName,
                    Color=n.Color,
                    FaIcon = n.FaIcon
                }).FirstOrDefault();
            
            return new ResultGetEditBlogsCategoriesDto
            {
                BlogsCategory = blogsCategory,
            };
        }
    }


    public class ResultGetEditBlogsCategoriesDto
    {
        public GetEditBlogsCategoriesDto BlogsCategory { get; set; }
        public string GroupName { get; set; }
        public string en_GroupName { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }

    }
    
    public class GetEditBlogsCategoriesDto
    {
        public int BlogsGroupId { get; set; }
        public string GroupName { get; set; }
        public string en_GroupName { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
    }
}