using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Queries
{
    public interface IGetMenusService
    {
        ResultGetMenusDto Execute();
    }

    public class GetMenusService : IGetMenusService
    {
        private readonly IDataBaseContext _context;

        public GetMenusService(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetMenusDto Execute()
        {
            var menus = _context.ParsaPooladMenus
                .Include(f => f.WsproductFirstGroup)
                .Select(f => new GetMenu1Dto
                {
                    ParsaPooladMenusId = f.ParsaPooladMenusId,
                    Name = f.Name,
                    Sub = f.WsproductFirstGroup
                        .Where(first => first.IsRemoved == null)
                        .Select(first => new GetMenu2Dto {
                        PrdFirstGroupId = first.PrdFirstGroupId,
                        Fgname = first.Fgname,
                        SubSub=first.WsproductSecondGroup
                        .Where(secound => secound.IsRemoved == null)
                        .Select(secound=> new GetMenu3Dto {
                            WsproductSecondGroupId = secound.PrdSecondGroupId,
                            Sgname = secound.Sgname,
                        }).ToList()
                    }).ToList()
                }).ToList();

            return new ResultGetMenusDto
            {
                Menus = menus,
            };
        }
    }

    public class ResultGetMenusDto
    {
        public List<GetMenu1Dto> Menus { get; set; }
    }


    public class GetMenu1Dto
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
        public List<GetMenu2Dto> Sub { get; set; }
    }

    public class GetMenu2Dto
    {
        public int PrdFirstGroupId { get; set; }
        public string Fgname { get; set; }
        public List<GetMenu3Dto> SubSub { get; set; }
    }

    public class GetMenu3Dto
    {
        public int WsproductSecondGroupId { get; set; }
        public string Sgname { get; set; }
    }
}
