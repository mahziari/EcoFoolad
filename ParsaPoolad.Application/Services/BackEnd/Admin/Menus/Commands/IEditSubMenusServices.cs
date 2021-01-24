using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Commands
{
    public interface IEditSubMenusServices
    {
        ResultEditSubMenusDto Execute(string name,int id);
    }
    public class EditSubMenusServices : IEditSubMenusServices
    {
        private readonly IDataBaseContext _context;

        public EditSubMenusServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultEditSubMenusDto Execute(string name,int id)
        {
            var menu = _context.WsproductSecondGroup.Find(id);

            if (menu == null)
            {
                return new ResultEditSubMenusDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            menu.Sgname = name;
            _context.SaveChanges();

            return new ResultEditSubMenusDto()
            {
                IsSuccess = true,
                Message = "با موفقیت ویرایش شد"
            };
        }

    }

    public class ResultEditSubMenusDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}