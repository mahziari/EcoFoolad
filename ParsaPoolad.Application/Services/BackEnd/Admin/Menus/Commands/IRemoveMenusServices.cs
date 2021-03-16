using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Commands
{
    public interface IRemoveMenusServices
    {
        ResultRemoveMenusDto Execute(int id);
    }
    public class RemoveMenusServices : IRemoveMenusServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public RemoveMenusServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultRemoveMenusDto Execute(int id)
        {
            var menu = _context.WsproductFirstGroup.Find(id);

            if (menu == null)
            {
                return new ResultRemoveMenusDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            menu.IsRemoved = 1;
            _context.SaveChanges();

            return new ResultRemoveMenusDto()
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }

    public class ResultRemoveMenusDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}