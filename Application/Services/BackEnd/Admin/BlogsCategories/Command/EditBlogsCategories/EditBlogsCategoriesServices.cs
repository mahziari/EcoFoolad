 
using System;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using AutoMapper;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories
{
    public class EditBlogsCategoriesServices:IEditBlogsCategoriesServices 
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public EditBlogsCategoriesServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        public ResultEditBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto,
            CrmCmsNewsGroups crmCmsNewsGroups, int id)
        {
            var blogCategoryModel = _customDbContext.BlogCategories.Find(id);
            
            var blogCategory = _mapper.Map<EditBlogsServicesDto>(blogCategoryModel);
            _customDbContext.SaveChanges();
            

            return new ResultEditBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "دسته بندی بلاگ با موفقیت ویرایش شد"
            };
        }
    }
    
    public class BlogCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public bool IsActive { get; set; }
        public string RegisterUserId { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
        public string LocalTime { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}