using System.Linq;
using Application.Interfaces.Contexts;


namespace  Application.Services.BackEnd.Admin.Products.Queries.GetCreateProducts
{
    public class GetCreateProductServices : IGetCreateProductServices
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetCreateProductServices(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }


        public ResultGetCreateProductsDto Execute()
        {
            var menus = _context.ParsaPooladMenus
                .Select(s=>new GetCreateMenusDto
                {
                    ParsaPooladMenusId=s.ParsaPooladMenusId,
                    Name = s.Name
                }).ToList();

            var company = _context.CrmCompany
                .Select(c => new GetCreateCompanyDto
                {
                    CompanyId=c.CompanyId,
                    CmpName=c.CmpName
                }).ToList();
            
            var productsUnit = _context.WsproductUnits
                .Select(c => new GetCreateProductsUnitDto
                {
                    ProductUnitId=c.ProductUnitId,
                    Unit=c.Unit
                }).ToList();

            return new ResultGetCreateProductsDto
            {
                Menus = menus,
                Company = company,
                ProductsUnit = productsUnit,
            };
        }
    }
}