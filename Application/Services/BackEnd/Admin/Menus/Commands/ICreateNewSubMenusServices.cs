 
using  Domain.Entities.IdealCrm;
using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Menus.Commands
{
     public interface ICreateNewSubMenusServices
    {
        ResultCreateSubMenusDto Execute(int id, string name);
    }

    public class CreateNewSubMenusServices : ICreateNewSubMenusServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public CreateNewSubMenusServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateSubMenusDto Execute(int id, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new ResultCreateSubMenusDto()
                {
                    IsSuccess = false,
                    Message = "نام دسته بندی را وارد نمایید"
                };
            }

            WsproductSecondGroup wsproductSecondGroup = new WsproductSecondGroup()
            {
                FirstGroupId = id,
                Sgname = name,
                UserId = 56,
                Month1 = 6,
                Fpid = 1,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                
            };

            _context.WsproductSecondGroup.Add(wsproductSecondGroup);
            _context.SaveChanges();

            return new ResultCreateSubMenusDto()
            {
                IsSuccess = true,
                Message = "دسته بندی با موفقیت اضافه شد"
            };
        }

    }

    public class ResultCreateSubMenusDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
