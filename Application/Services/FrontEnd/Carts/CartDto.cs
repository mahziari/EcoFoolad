using System.Collections.Generic;

namespace Application.Services.FrontEnd.Carts
{
    public class CartDto
    {
        public int ProductCount { get; set; }
        public int SumAmount { get; set; }
        public List<CartItemDto> CartItems { get; set; }
    }
}