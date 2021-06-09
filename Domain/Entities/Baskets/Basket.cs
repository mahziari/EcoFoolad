using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Attributes;
using Domain.Entities.Products;

namespace Domain.Entities.Baskets
{
    [Auditable]
    public class Basket
    {
        public long Id { get; set; }
        public string BuyerId { get; private set; }
        private readonly List<BasketItem> _items = new List<BasketItem>();
        public ICollection<BasketItem> Items => _items.AsReadOnly();
        public Basket(string buyerId)
        {
            this.BuyerId = buyerId;
        }

        public void AddItem(long productId, int quantity, int unitPrice)
        {
            if (!Items.Any(p => p.ProductId == productId))
            {
                _items.Add(new BasketItem(productId, quantity, unitPrice));
                return;
            }
            var existingItem = Items.FirstOrDefault(p => p.ProductId == productId);
            existingItem.AddQuantity(quantity);
        }
    }


    [Auditable]
    public class BasketItem
    {
        public long Id { get; set; }
        public int UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public long ProductId { get; private set; }
        public Product Product { get; private set; }
        public long BasketId { get; private set; }
        public BasketItem(long productId, int quantity, int unitPrice)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            SetQuantity(quantity);
        }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
