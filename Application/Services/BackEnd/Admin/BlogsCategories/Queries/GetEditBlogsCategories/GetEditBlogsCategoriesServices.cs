using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.User.Addresses;
using AutoMapper;
using Domain.Entities;


namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories
{
    public class GetEditBlogsCategoriesServices : IGetEditBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetEditBlogsCategoriesServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public BaseDto<BlogCategoryDto> Execute(int id)
        {
            var blogCategoriesModel = _customDbContext.BlogCategories
                .SingleOrDefault(n => n.Id == id);
            var blogCategories = _mapper.Map<BlogCategoryDto>(blogCategoriesModel);
            
            return new BaseDto<BlogCategoryDto>
            (
                true,
                null,
                _mapper.Map<BlogCategoryDto>(blogCategories)
            );
        }
    }
}