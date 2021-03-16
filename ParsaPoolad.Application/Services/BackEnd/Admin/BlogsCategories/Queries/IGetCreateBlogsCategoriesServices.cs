using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Queries
{
    public interface IGetCreateBlogsCategoriesServices
    {
        ResultGetCreateBlogsCategoriesDto Execute();
    }

    public class GetCreateBlogsCategoriesServices : IGetCreateBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetCreateBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCreateBlogsCategoriesDto Execute()
        {
            // var blogsCategories = _context.CrmCmsNewsGroups
            //     .Select(g=>new GetBlogsCategoriesGroupsDto
            //     {
            //         BlogsGroupId = g.NewsGroupId,
            //         GroupName = g.GroupName,
            //     }).ToList();
            //

            return new ResultGetCreateBlogsCategoriesDto
            {
                // BlogsCategories = blogsCategories,
            };
        }
    }

    public class ResultGetCreateBlogsCategoriesDto
    {
        // public List<GetBlogsCategoriesGroupsDto> BlogsCategories { get; set; }
        public string GroupName { get; set; }
        public string en_GroupName { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
    }
    
    // public class GetBlogsCategoriesGroupsDto
    // {
    //     public int BlogsGroupId { get; set; }
    //     public string GroupName { get; set; }
    //
    // }
}