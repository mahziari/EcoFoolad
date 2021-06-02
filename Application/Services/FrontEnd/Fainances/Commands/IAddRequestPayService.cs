using System;
using Application.Interfaces.Contexts;
using Common.Dto;
using Domain.Entities.Finances;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace Application.Services.FrontEnd.Fainances.Commands
{
    public interface IAddRequestPayService
    {
        ResultDto<ResultRequestPayDto> Execute(int Amount, string UserId);
    }


    public class AddRequestPayService : IAddRequestPayService
    {
        private readonly ICustomDbContext _context;
        private readonly UserManager<User> _userManager;
        public AddRequestPayService(ICustomDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public ResultDto<ResultRequestPayDto> Execute(int Amount, string UserId)
        {
            var user = _userManager.FindByIdAsync(UserId).Result;
            RequestPay requestPay = new RequestPay()
            {
                Amount = Amount,
                Guid = Guid.NewGuid(),
                IsPay = false,
                User = user,

            };
            _context.RequestPays.Add(requestPay);
            _context.SaveChanges();

            return new ResultDto<ResultRequestPayDto>()
            {
                Data = new ResultRequestPayDto
                {
                    guid = requestPay.Guid,
                    Amount=requestPay.Amount,
                    Email=user.Email,
                    RequestPayId=requestPay.Id,
                },
                IsSuccess = true,
            };
        }
    }

    public class ResultRequestPayDto
    {
        public Guid guid { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }
        public long RequestPayId { get; set; }
    }
}
