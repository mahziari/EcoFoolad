using System.Collections.Generic;

namespace Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto
{
    public class ResultGetProductsCategoryFrontEndDto
    {
        public List<GetIndexProductsDto> Products { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
        public string UrlName { get; set; }
        public string CategoryName { get; set; }
        public string MenuName { get; set; }
        public int PageNum { get; set; } = 1;
        public List<FactoriesDto> Factories { get; set; }
        public List<CompanyDto> Companies { get; set; }
    }
}