using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.FrontEnd.Payments
{
    public interface IPaymentsServices
    {
        PaymentOfOrderDto PayForOrder(long orderId);
    }

    public class PaymentsServices : IPaymentsServices
    {
        private readonly ICustomDbContext _customDbContext;

        public PaymentsServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }

        public PaymentOfOrderDto PayForOrder(long orderId)
        {
            var order = _customDbContext.Orders
                .Include(o => o.OrderItems)
                .SingleOrDefault(o => o.Id == orderId);
            if (order == null) throw new Exception("");
            var payments = _customDbContext.Payments
                .SingleOrDefault(p => p.OrderId == order.Id);

            if (payments==null)
            {
                payments = new Payment(order.TotalPrice(), order.Id);
                _customDbContext.Payments.Add(payments);
                _customDbContext.SaveChanges();

            }

            return new PaymentOfOrderDto
            {
                Amount = payments.Amount,
                // paymentId = payments.Id,
                // PaymentMethod = payments.PaymentMethod,
            };

        }

    }
    
   

    public class PaymentOfOrderDto
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}