﻿using System.Collections.Generic;
using System.Linq;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Owner.Products.Queries.GetCreateProductsAjax
{

    public interface IGetReturnSubSubMenusAjaxServices
    {
        ResultAjaxReturnSubSubMenusDto Execute(int id);
    }


    public class GetReturnSubSubMenusAjaxServices : IGetReturnSubSubMenusAjaxServices
    {
        private readonly IDataBaseContext _context;

        public GetReturnSubSubMenusAjaxServices(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultAjaxReturnSubSubMenusDto Execute(int id)
        {

            var subSubMenus = _context.WsproductSecondGroup
                .Where(s => s.FirstGroupId==id)
                .Where(s=>s.IsRemoved!=1)
                .Select(s=>new AjaxReturnSubSubMenusDto
                {
                    WsproductSecondGroupId=s.PrdSecondGroupId,
                    Sgname = s.Sgname
                }).ToList();

            return new ResultAjaxReturnSubSubMenusDto
            {
                SubSubMenus = subSubMenus,
            };
        }
    }

    public class ResultAjaxReturnSubSubMenusDto
    {
        public List<AjaxReturnSubSubMenusDto> SubSubMenus { get; set; }
    }


    public class AjaxReturnSubSubMenusDto
    {
        public int WsproductSecondGroupId { get; set; }
        public string Sgname { get; set; }
    }
}