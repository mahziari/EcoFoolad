namespace Application.Services.FrontEnd.Carts
{
    public class CartItemDto
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string Images { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}