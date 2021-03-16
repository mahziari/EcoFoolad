using ParsaPoolad.Application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Commands
{
    public interface IRemoveSubMenusServices
    {
        ResultRemoveSubMenusDto Execute(int id);
    }
    public class RemoveSubMenusServices : IRemoveSubMenusServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public RemoveSubMenusServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultRemoveSubMenusDto Execute(int id)
        {
            var menu = _context.WsproductSecondGroup.Find(id);

            if (menu == null)
            {
                return new ResultRemoveSubMenusDto()
                {
                    IsSuccess = false,
                    Message = "یافت نشد"
                };
            }

            menu.IsRemoved = 1;
            _context.SaveChanges();

            return new ResultRemoveSubMenusDto()
            {
                IsSuccess = true,
                Message = "با موفقیت حذف شد"
            };
        }

    }

    public class ResultRemoveSubMenusDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
