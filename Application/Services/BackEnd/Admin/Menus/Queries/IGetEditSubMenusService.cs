using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.Menus.Queries
{
    public interface IGetEditSubMenusService
    {
        ResultGetEditSubMenusDto Execute(int id);
    }
    public class GetEditSubMenusService : IGetEditSubMenusService
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetEditSubMenusService(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetEditSubMenusDto Execute(int id)
        {
            var menu = _context.WsproductSecondGroup
                .Where(s => s.PrdSecondGroupId == id)
                .Select(s => new ResultGetEditSubMenusDto
                {
                    PrdSecondGroupId = s.PrdSecondGroupId,
                    Sgname = s.Sgname
                }).FirstOrDefault();
           
            return new ResultGetEditSubMenusDto
            {
                PrdSecondGroupId = menu.PrdSecondGroupId,
                Sgname = menu.Sgname
            };
            
        }
    }

    public class ResultGetEditSubMenusDto
    {
        public int PrdSecondGroupId { get; set; }
        public string Sgname { get; set; }
    }
}