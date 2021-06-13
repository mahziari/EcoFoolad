using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Attributes;


namespace Domain.Entities.Orders
{
    [Auditable]
    public class Order
    {
        public long Id { get; set; }
        public string UserId { get;private set; }
        public DateTime OrderDate { get;private set; }=DateTime.Now;
        public Address Address { get;private set; }
        public PaymentMethod PaymentMethod { get;private set; }
        public PaymentStatus PaymentStatus { get;private set; }
        public OrderStatus OrderStatus { get;private set; }
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();


        public Order(string userId, Address address,List<OrderItem> orderItems, PaymentMethod paymentMethod)
        {
            UserId = userId;
            Address = address;
            _orderItems = orderItems;
            PaymentMethod = paymentMethod;
        }

        public int TotalPrice()
        {
           return _orderItems.Sum(o => o.UnitPrice * o.Unit);
        }

        public Order()
        {
             
        }

    }

    [Auditable]
    public class OrderItem
    {
        public long Id { get; set; }
        public long ProductId { get; private set; }
        public string ProductName { get; private set; }
        public int UnitPrice { get; private set; }
        public int Unit { get; private set; }

        public OrderItem(long productId,string productName, int unitPrice, int unit)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Unit = unit;
        }

        public OrderItem()
        {
            
        }
    }

    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PostalAddress { get; set; }
        public string ReciverName  { get; set; }

        public Address(string state,string city,string zipCode,string postalAddress,string reciverName)
        {
            State = state;
            this.City = city;
            ZipCode = zipCode;
            PostalAddress = postalAddress;
            ReciverName = reciverName;
        }
    }

    public enum PaymentMethod
    {
        OnlinePayment=0,
        PaymentOnTheSpot=1
    }

    public enum PaymentStatus
    {
        Paid=1,
        WaitingForPayment=0
    }
    public enum OrderStatus
    {
        Processing=0,
        Delivered=1,
        Returned=2,
        Canceled=3
    }
}