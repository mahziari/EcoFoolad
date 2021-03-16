using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Queries
{
    public interface IGetIndexBlogsCategoriesServices
    {
        ResultGetIndexBlogsCategoriesDto Execute();
    }

    public class GetIndexBlogsCategoriesServices : IGetIndexBlogsCategoriesServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexBlogsCategoriesDto Execute()
        {
            var blogsCategories = _context.CrmCmsNewsGroups
                .OrderByDescending(n=> n.NewsGroupId)
                .ToList();

            return new ResultGetIndexBlogsCategoriesDto
            {
                BlogsCategories = blogsCategories,
            };
        }
    }

    public class ResultGetIndexBlogsCategoriesDto
    {
        public List<CrmCmsNewsGroups> BlogsCategories { get; set; }
    }

}