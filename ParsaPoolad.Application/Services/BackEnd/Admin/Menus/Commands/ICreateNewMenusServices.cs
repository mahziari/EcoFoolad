using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Commands
{
    public interface ICreateNewMenusServices
    {
        ResultCreateMenusDto Execute(int id,string name);
    }

    public class CreateNewMenusServices:ICreateNewMenusServices {
        private readonly IDataBaseContext _context;

        public CreateNewMenusServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateMenusDto Execute(int id,string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new ResultCreateMenusDto()
                {
                    IsSuccess = false,
                    Message = "نام دسته بندی را وارد نمایید"
                };
            }

            WsproductFirstGroup wsproductFirstGroup = new WsproductFirstGroup()
            {
                ParsaPooladMenusId = (int)id,
                Fgname = name,
                UserId= 57,
                Month1=6,
                Fpid = 1,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
            };

            _context.WsproductFirstGroup.Add(wsproductFirstGroup);
            _context.SaveChanges();

            return new ResultCreateMenusDto()
            {
                IsSuccess = true,
                Message = "دسته بندی با موفقیت اضافه شد"
            };
        }

    }

    public class ResultCreateMenusDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
 