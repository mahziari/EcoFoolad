using System;
using Domain.Entities.IdealCrm;
using Domain.Entities.Orders;

namespace Domain.Entities.Payments
{
    public class Payment
    {
        public Guid Id { get; set; }
        public int Amount { get;private set; }
        public bool IsPay { get;private set; } = false;
        public DateTime? DatePay { get;private set; }
        public string Authority { get;private set; }
        public string RefIdf { get; private set; } = "0";
        public Order Order { get; private set; } 
        public long OrderId { get; private set; }

        public Payment(int amount, long orderId)
        {
            Amount = amount;
            OrderId = orderId;
        }

        public void PaymentIsDone(string authority,string refIdf )
        {
            IsPay = true;
            DatePay=DateTime.Now;
            Authority = authority;
            RefIdf = refIdf;
        }
    }
}