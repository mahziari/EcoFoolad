using System.Collections.Generic;

namespace Application.Services.FrontEnd.Search
{
    public interface IResultHeaderSearchServices
    {
        List<ProductsSearchDto> ResultSearch(string keyup);
    }

    public class ProductsSearchDto
    {
        public long Id { get; set; }
        public string PrdName { get; set; }
        public string RegisterDatePersian { get; set; }
    }
}