 

using Application.Interfaces.Contexts;

namespace  Application.Services.BackEnd.Admin.Menus.Commands
{
    public interface IEditMenusServices
    {
        ResultEditMenusServices Execute(string name,int id);
    }
    public class EditMenusServices : IEditMenusServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public EditMenusServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultEditMenusServices Execute(string name,int id)
        {
            var menu = _context.WsproductFirstGroup.Find(id);

            if (menu == null)
            {
                return new ResultEditMenusServices()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            menu.Fgname = name;
            _context.SaveChanges();

            return new ResultEditMenusServices()
            {
                IsSuccess = true,
                Message = "با موفقیت ویرایش شد"
            };
        }

    }

    public class ResultEditMenusServices
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}