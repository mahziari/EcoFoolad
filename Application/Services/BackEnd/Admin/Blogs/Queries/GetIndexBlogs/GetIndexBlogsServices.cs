using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs
{
    public class GetIndexBlogsServices : IGetIndexBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetIndexBlogsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public ResultGetIndexBlogsDto Execute()
        {
            var blogsModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .OrderByDescending(s => s.Id);
            var blogs = _mapper.Map<List<GetIndexBlogsDto>>(blogsModel);


            return new ResultGetIndexBlogsDto
            {
                Blogs = blogs,
            };
        }
    }
}