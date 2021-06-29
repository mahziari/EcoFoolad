using System;
using Application.Interfaces.Contexts;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories
{
    public class CreateBlogsCategoriesServices : ICreateBlogsCategoriesServices
    {

        private readonly IIdealCrmDataBaseContext _context;
        public CreateBlogsCategoriesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto)
        {
            
            var blogs = new CrmCmsNewsGroups()
            {
                GroupName=createBlogsCategoriesServicesDto.GroupName,
                en_GroupName=createBlogsCategoriesServicesDto.en_GroupName,
                Description= createBlogsCategoriesServicesDto.Description,
                Color = createBlogsCategoriesServicesDto.Color,
                FaIcon = createBlogsCategoriesServicesDto.FaIcon,
                IsActive = true,
                UserId = 57,
                Month1 = 6,
                FirstRegisterUserId = 57,
                FirstRegisterDate = DateTime.Now,
                FirstRegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                RegisterDate = DateTime.Now,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                LocalTime = DateTime.Now.ToString("s")+"+"+TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),
                AppType = "web",
                LanguageId = 1065
            };

            _context.CrmCmsNewsGroups.Add(blogs);
            _context.SaveChanges();

            return new ResultCreateBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "بلاگ با موفقیت اضافه شد"
            };

        }
    }
}