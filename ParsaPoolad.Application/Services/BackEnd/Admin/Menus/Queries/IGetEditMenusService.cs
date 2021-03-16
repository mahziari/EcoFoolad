using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Menus.Queries
{
    public interface IGetEditMenusService
    {
        ResultGetEditMenusDto Execute(int id);
    }
    public class GetEditMenusService : IGetEditMenusService
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditMenusService(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetEditMenusDto Execute(int id)
        {
            var menu = _context.WsproductFirstGroup
                .Where(f => f.PrdFirstGroupId == id)
                .Select(f => new ResultGetEditMenusDto
                {
                    PrdFirstGroupId = f.PrdFirstGroupId,
                    Fgname = f.Fgname,
                }).FirstOrDefault();
            return new ResultGetEditMenusDto
            {
                PrdFirstGroupId = menu.PrdFirstGroupId,
                Fgname = menu.Fgname
            };
        }
    }
    
   

    public class ResultGetEditMenusDto
    {
        public int PrdFirstGroupId { get; set; }
        public string Fgname { get; set; }
    }
}