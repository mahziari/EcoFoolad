namespace Application.Services.FrontEnd.Basket
{
    public class BasketItemDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string subMenuEnSgname { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}