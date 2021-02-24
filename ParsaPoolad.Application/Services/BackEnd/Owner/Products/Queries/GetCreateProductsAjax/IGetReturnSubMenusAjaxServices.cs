using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries.GetCreateProductsAjax
{
    public interface IGetReturnSubMenusAjaxServices
    {
        ResultAjaxReturnSubMenusDto Execute(int id);
    }


    public class GetReturnSubMenusAjaxServices : IGetReturnSubMenusAjaxServices
    {
        private readonly IDataBaseContext _context;

        public GetReturnSubMenusAjaxServices(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultAjaxReturnSubMenusDto Execute(int id)
        {

            var subMenus = _context.WsproductFirstGroup
                .Where(s => s.ParsaPooladMenusId==id)
                .Where(s=>s.IsRemoved!=1)
                .Select(s=>new AjaxReturnSubMenusDto
                {
                    PrdFirstGroupId=s.PrdFirstGroupId,
                    Fgname = s.Fgname
                }).ToList();


            return new ResultAjaxReturnSubMenusDto
            {
                SubMenus = subMenus,
            };
        }
    }

    public class ResultAjaxReturnSubMenusDto
    {
        public List<AjaxReturnSubMenusDto> SubMenus { get; set; }
    }


    public class AjaxReturnSubMenusDto
    {
        public int PrdFirstGroupId { get; set; }
        public string Fgname { get; set; }
    }
 
  
  

}