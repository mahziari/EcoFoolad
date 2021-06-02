using System;
using Common.Dto;

namespace Application.Services.FrontEnd.Carts
{
    public interface ICartFrontEndService
    {
        ResultDto AddToCart(long productId, Guid BrowserId);
        ResultDto RemoveFromCart(long UserId, Guid BrowserId);
        ResultDto<CartDto> GetMyCart(Guid BrowserId, string UserId);
        ResultDto Add(long cartItemId);
        ResultDto LowOff(long cartItemId);
    }
}