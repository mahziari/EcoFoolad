using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories
{
    public class GetIndexBlogsCategoriesServices : IGetIndexBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetIndexBlogsCategoriesServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public List<BlogCategoryDto> Execute()
        {
            var blogsCategoriesModel = _customDbContext.BlogCategories
                .Include(s => s.Blog)
                .OrderByDescending(s => s.Id);
            var blogsCategories = _mapper.Map<List<BlogCategoryDto>>(blogsCategoriesModel);

            return blogsCategories;
        }
    }
}