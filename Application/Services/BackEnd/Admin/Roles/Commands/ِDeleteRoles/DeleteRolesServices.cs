 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Roles.Commands._ِDeleteRoles
{
    public class DeleteRolesServices : IDeleteRolesServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        public DeleteRolesServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultDeleteRtolesCategoriesDto Execute(int id)
        {
            var blogCategory = _context.CrmCmsNewsGroups.Find(id);
            
            if (blogCategory == null)
            {
                return new ResultDeleteRtolesCategoriesDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }
            
            _context.CrmCmsNewsGroups.Remove(blogCategory);
            _context.SaveChanges();
            return new ResultDeleteRtolesCategoriesDto
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }
}