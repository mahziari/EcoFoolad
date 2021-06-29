 
using Application.Interfaces.Contexts;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories
{
    public class EditBlogsCategoriesServices:IEditBlogsCategoriesServices {
        private readonly IIdealCrmDataBaseContext _context;

        public EditBlogsCategoriesServices(IIdealCrmDataBaseContext context )
        {
            _context = context;
        }

        public ResultEditBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto,
            CrmCmsNewsGroups crmCmsNewsGroups, int id)
        {
            
            var blogCategory = _context.CrmCmsNewsGroups.Find(id);
            
            blogCategory.GroupName = createBlogsCategoriesServicesDto.GroupName;
            blogCategory.en_GroupName = createBlogsCategoriesServicesDto.en_GroupName;
            blogCategory.Description = createBlogsCategoriesServicesDto.Description;
            blogCategory.Color = createBlogsCategoriesServicesDto.Color;
            blogCategory.FaIcon = createBlogsCategoriesServicesDto.FaIcon;
            _context.SaveChanges();

            return new ResultEditBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "دسته بندی بلاگ با موفقیت ویرایش شد"
            };
        }
    }
}