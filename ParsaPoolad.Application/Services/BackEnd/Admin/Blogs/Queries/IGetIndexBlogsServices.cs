using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.IdealCrm;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Queries
{
    public interface IGetIndexBlogsServices
    {
        ResultGetIndexBlogsDto Execute();
    }

    public class GetIndexBlogsServices : IGetIndexBlogsServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetIndexBlogsServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetIndexBlogsDto Execute()
        {
            var blogs = _context.CrmCmsNews
                .Include(n=>n.NewsGroup)
                .OrderByDescending(n=> n.NewsId)
                .ToList();

            return new ResultGetIndexBlogsDto
            {
                Blogs = blogs,
            };
        }
    }

    public class ResultGetIndexBlogsDto
    {
        public List<CrmCmsNews> Blogs { get; set; }
    }

}