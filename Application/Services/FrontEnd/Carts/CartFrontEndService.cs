using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Common.Dto;
using Domain.Entities.Carts;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.FrontEnd.Carts
{
    public class CartFrontEndService : ICartFrontEndService
    {
        private readonly ICustomDbContext _context;
        private readonly UserManager<User> _userManager;

        public CartFrontEndService(ICustomDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ResultDto AddToCart(long productId, Guid BrowserId)
        {
            var cart = _context.Carts.FirstOrDefault(p => p.BrowserId == BrowserId && p.Finished == false);
            if (cart == null)
            {
                Cart newCart = new Cart()
                {
                    Finished = false,
                    BrowserId = BrowserId,
                };
                _context.Carts.Add(newCart);
                _context.SaveChanges();
                cart = newCart;
            }

            var product = _context.Products.FirstOrDefault(p => p.PrdCrmId == productId);

            var cartItem = _context.CartItems.FirstOrDefault(p => p.ProductId == product.Id && p.CartId == cart.Id);
            if (cartItem != null)
            {
                cartItem.Count++;
                _context.SaveChanges();
            }
            else
            {
                CartItem newCartItem = new CartItem()
                {
                    Cart = cart,
                    Count = 1,
                    Price = product.PrdPrice,
                    Product = product,
                };
                _context.CartItems.Add(newCartItem);
                _context.SaveChanges();
            }

            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"محصول  {product.PrdName} با موفقیت به سبد خرید شما اضافه شد ",
            };
        }
        
        public ResultDto<CartDto> GetMyCart(Guid BrowserId, string userId)
        {
            var cart = _context.Carts
                .Include(p => p.CartItems)
                .ThenInclude(p => p.Product)
                // .ThenInclude(p => p.ProductImages)
                .Where(p => p.BrowserId == BrowserId && p.Finished == false)
                .OrderByDescending(p => p.Id)
                .FirstOrDefault();

            if (cart == null)
            {
                return new ResultDto<CartDto>()
                {
                    Data = new CartDto()
                    {
                        CartItems = new List<CartItemDto>()
                    },
                    IsSuccess = false,
                };
            }

            if (userId != null)
            {
                var user = _userManager.FindByIdAsync(userId).Result;
                cart.User = user;
                _context.SaveChanges();
            }


            return new ResultDto<CartDto>()
            {
                Data = new CartDto()
                {
                    ProductCount = cart.CartItems!.Count,
                    SumAmount = cart.CartItems.Sum(p => p.Price * p.Count),
                    CartItems = cart.CartItems.Select(p => new CartItemDto
                    {
                        Count = p.Count,
                        Price = p.Price,
                        ProductName = p.Product.PrdName,
                        Id = p.Id,
                        // Images = p.Product?.ProductImages?.FirstOrDefault()?.Src ?? "",
                    }).ToList(),
                },
                IsSuccess = true,
            };
        }
        public ResultDto Add(long cartItemId)
        {
            var cartItem = _context.CartItems.Find(cartItemId);
            cartItem.Count++;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
            };
        }


        public ResultDto LowOff(long CartItemId)
        {
            var cartItem = _context.CartItems.Find(CartItemId);

            if (cartItem.Count <= 1)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                };
            }

            cartItem.Count--;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
            };
        }

        public ResultDto RemoveFromCart(long ProductId, Guid BrowserId)
        {
            var cartitem = _context.CartItems.FirstOrDefault(p => p.Cart.BrowserId == BrowserId);
            if (cartitem != null)
            {
                cartitem.IsRemoved = true;
                cartitem.RemoveTime = DateTime.Now;
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "محصول از سبد خرید شما حذف شد"
                };
            }
            else
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }
        }
    }
}