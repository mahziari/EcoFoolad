using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.BlogsCategories;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Blogs;
using Microsoft.EntityFrameworkCore;


namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public class GetCreateBlogsServices : IGetCreateBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public GetCreateBlogsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public GetCreateBlogsDto Execute()
        {
            var blogsModel = _customDbContext.Blogs;
            var blogCategoryModel = _customDbContext.BlogCategories;
            
            var data =new GetCreateBlogsDto();
            data.Blogs = _mapper.Map<List<BlogDto>>(blogsModel);
            data.BlogCategory = _mapper.Map<List<BlogCategoryDto>>(blogCategoryModel);

            return data;
        }
    }
}