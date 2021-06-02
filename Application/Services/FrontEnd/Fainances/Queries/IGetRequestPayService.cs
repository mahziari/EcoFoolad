using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Common.Dto;

namespace Application.Services.FrontEnd.Fainances.Queries
{
    public interface IGetRequestPayService
    {
        ResultDto<RequestPayDto> Execute(Guid guid);
    }

    public class GetRequestPayService : IGetRequestPayService
    {
        private readonly ICustomDbContext _context;
        public GetRequestPayService(ICustomDbContext context)
        {
            _context = context;
        }
        public ResultDto<RequestPayDto> Execute(Guid guid)
        {
            var requestPay = _context.RequestPays.FirstOrDefault(p => p.Guid == guid);

            if (requestPay != null)
            {
                return new ResultDto<RequestPayDto>()
                {
                    Data = new RequestPayDto()
                    {
                        Amount = requestPay.Amount,
                    }
                };
            }
            else
            {
                throw new Exception("request pay not found");
            }
        }
    }

    public class RequestPayDto
    {
        public int Amount { get; set; }
    }
}
