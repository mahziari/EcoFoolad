namespace Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto
{
    public class ProductsFiltersDto
    {
        public string MenuName { get; set; }
        public string SecoundGroupName { get; set; }
        public string FirstGroupName { get; set; }
        
        public int? CatalogTypeId { get; set; }
        public int[] CompanyId { get; set; }
        public bool AvailableStock { get; set; }
        public string SearchKey { get; set; }
        public string CategoryName { get; set; }
        public SortType SortType { get; set; }
    }
}