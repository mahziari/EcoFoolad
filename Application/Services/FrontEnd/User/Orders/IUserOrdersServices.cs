using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.FrontEnd.User.Orders
{
    public interface IUserOrdersServices
    {
        List<UserOrdersDto> GetUserOrders(string userId);
        BaseDto<UserOrdersDto> GetDetailsUserOrders(long orderId);
    }


    public class UserOrdersServices : IUserOrdersServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public UserOrdersServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public List<UserOrdersDto> GetUserOrders(string userId)
        {
            var orders = _customDbContext.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.UserId == userId)
                .OrderByDescending(o=>o.Id)
                .ToList();
            var data = _mapper.Map<List<UserOrdersDto>>(orders);
            return data;
        }
        
        public BaseDto<UserOrdersDto> GetDetailsUserOrders(long orderId)
        {
            var orders = _customDbContext.Orders
                .Include(o => o.OrderItems)
                .SingleOrDefault(o => o.Id == orderId);
            var data = _mapper.Map<UserOrdersDto>(orders);
            return new BaseDto<UserOrdersDto>
            (
                true,
                null,
                _mapper.Map<UserOrdersDto>(data)
            );
        }
    }



    public class UserOrdersDto
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}