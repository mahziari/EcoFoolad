using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsFrontEndService
    {
        ResultGetProductsFrontEndDto Execute();
    }

    public class GetProductsFrontEndService : IGetProductsFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _parsapooladContext;

        public GetProductsFrontEndService(IIdealCrmDataBaseContext context, ICustomDbContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }


        public ResultGetProductsFrontEndDto Execute()
        {
            var products = _context.Wsproducts
                // .Where(s => s.PrdInactiveInSale = true)
                .Select(s => new GetProductsDto
                {
                    ProductId = s.ProductId,
                    PrdGroupId = s.PrdGroupId,
                    PrdCode = s.PrdCode,
                    PrdName = s.PrdName,
                    PrdSize = s.PrdSize,
                    PrdUnitId = s.PrdUnitId,
                    PrdMaxQty = s.PrdMaxQty,
                    RegisterDatePersian = s.RegisterDatePersian,
                    PrdModel = s.PrdModel,
                    PrdPrice = s.PrdPrice
                }).ToList();
            
            
            var menus = _context.ParsaPooladMenus
                .Include(f => f.WsproductFirstGroup)
                .Select(f => new GetMenu1Dto
                {
                    ParsaPooladMenusId = f.ParsaPooladMenusId,
                    Name = f.Name,
                    UrlName=f.UrlName,
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
                        }).ToList(),
                    Image=f.Image
                }).ToList();


            return new ResultGetProductsFrontEndDto
            {
                Products = products,
                Menus = menus,
            };
        }
    }

    public class ResultGetProductsFrontEndDto
    {
        public List<GetProductsDto> Products { get; set; }
        public List<GetMenu1Dto> Menus { get; set; }
    }


    public class GetProductsDto
    {
        public int ProductId { get; set; }
        public int PrdGroupId { get; set; }
        public string PrdCode { get; set; }
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int? PrdUnitId { get; set; }
        public int? PrdMaxQty { get; set; }
        public string RegisterDatePersian { get; set; }
        public string PrdModel { get; set; }
        public int PrdShpotherSupplierId { get; set; }
        public decimal? PrdPrice { get; set; }
    }
    
    
    
    public class GetMenu1Dto
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; }
        public string Image { get; set; }
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