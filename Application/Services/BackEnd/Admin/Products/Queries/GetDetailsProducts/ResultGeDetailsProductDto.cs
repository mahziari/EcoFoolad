using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Products.Queries.GetDetailsProducts
{
    public class ResultGeDetailsProductDto
    {
        public WsproductSecondGroup PrdGroupId { get; set; }
        public string PrdCode { get; set; }
        public string PrdName { get; set; }
        public string PrdSize { get; set; }
        public int? PrdMaxQty { get; set; }
        public string PrdDescription { get; set; }
        public string PrdModel { get; set; }
        public string RegisterDatePersian { get; set; }
        public decimal? PrdPrice { get; set; }
        public ResultGetDetailsUnitProductDto UnitProducts { get; set; }
        public ResultGetDetailsCompanyProductDto CompanyProducts { get; set; }
    }
}