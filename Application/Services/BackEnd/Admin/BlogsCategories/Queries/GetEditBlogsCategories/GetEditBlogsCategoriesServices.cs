using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;


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


        public ResultGetEditBlogsCategoriesDto Execute(int id)
        {
            var blogCategoriesModel = _customDbContext.BlogCategories
                .SingleOrDefault(n => n.Id == id);
            var blogCategories = _mapper.Map<GetEditBlogsCategoriesDto>(blogCategoriesModel);

            return new ResultGetEditBlogsCategoriesDto
            {
                BlogCategories = blogCategories,
            };
        }
    }
}