using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;
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


        public List<BlogDto>  Execute()
        {
            var blogsModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .OrderByDescending(s => s.Id);
            var blogs = _mapper.Map<List<BlogDto>>(blogsModel);


            return blogs;
        }
    }
}