using System.Collections.Generic;
using Domain.Entities.IdealCrm;

namespace Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto
{
    public class ResultGetProductsCategoryFrontEndDto
    {
        public List<GetIndexProductsDto> Products { get; set; }
        public ParsaPooladMenus FirstMenuName { get; set; }
        public WsproductFirstGroup SecoundMenuName { get; set; }
        public WsproductSecondGroup ThirdMenuName { get; set; }
        public List<FactoriesDto> Factories { get; set; }
        public List<CompanyDto> Companies { get; set; }
        public List<ExpertsDto> Experts { get; set; }
    }
}