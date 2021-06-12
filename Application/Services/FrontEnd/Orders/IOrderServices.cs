using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.FrontEnd.Orders
{
    public interface IOrderServices
    {
        long CreateOrder(long basketId, int userAddressId, PaymentMethod paymentMethod);
    }

    public class OrderServices : IOrderServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public OrderServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public long CreateOrder(long basketId, int userAddressId, PaymentMethod paymentMethod)
        {
            var basket = _customDbContext.Baskets
                .Include(b => b.Items)
                .SingleOrDefault(b => b.Id == basketId);
            long[] ids = basket.Items.Select(i => i.ProductId).ToArray();
            var productsiItems = _customDbContext.Products.Where(p => ids.Contains(p.Id));

            var orderItems = basket.Items.Select(basketItem =>
            {
                var productsiItem = productsiItems.First(c => c.Id == basketItem.ProductId);
                var orderItem = new OrderItem(productsiItem.Id, productsiItem.PrdName, productsiItem.PrdPrice,
                    basketItem.Quantity);
                return orderItem;
            }).ToList();


            var userAddress = _customDbContext.UserAddresses.SingleOrDefault(a => a.Id == userAddressId);
            var address = _mapper.Map<Address>(userAddress);
            var order = new Order(basket.BuyerId, address, orderItems, paymentMethod);
            _customDbContext.Orders.Add(order);
            _customDbContext.Baskets.Remove(basket);
            _customDbContext.SaveChanges();
            return order.Id;
        }
    }
}