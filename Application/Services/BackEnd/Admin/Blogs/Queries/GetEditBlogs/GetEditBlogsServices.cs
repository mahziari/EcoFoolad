using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using Application.Services.BackEnd.Admin.BlogsCategories;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Blogs;
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

        public GetEditBlogsDto Execute(int id)
        {
            var blogModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .FirstOrDefault(b=>b.Id==id);
            var blogsModel = _customDbContext.Blogs;
            var blogCategoriesModel = _customDbContext.BlogCategories;
            
            var data =_mapper.Map<GetEditBlogsDto>(blogModel);
            data.Blog = _mapper.Map<List<BlogDto>>(blogsModel);
            data.BlogCategories = _mapper.Map<List<BlogCategoryDto>>(blogCategoriesModel);

            return data;
        }

        private void Include(Func<object, object> func)
        {
            throw new NotImplementedException();
        }
    }
}