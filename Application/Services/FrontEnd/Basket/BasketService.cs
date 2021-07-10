using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Owner.Products.Queries;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.FrontEnd.Basket
{
    public class BasketService : IBasketService
    {
        private readonly ICustomDbContext _context;
        private readonly IIdealCrmDataBaseContext _idealCrmDataBaseContext;
        public BasketService(ICustomDbContext context, IIdealCrmDataBaseContext idealCrmDataBaseContext)
        {
            _context = context;
            _idealCrmDataBaseContext = idealCrmDataBaseContext;
        }

        public void AddItemToBasket(long basketId, long productId, int quantity = 1)
        {
            var basket = _context.Baskets.FirstOrDefault(p => p.Id == basketId);
            if (basket == null) throw new Exception("");

            var product = _context.Products.First(p => p.PrdCrmId==productId);
            basket.AddItem(product.Id, quantity, product.PrdPrice);
            _context.SaveChanges();
        }

        public BasketDto GetBasketForUser(string userId)
        {
            var basket = _context.Baskets
                .Include(p => p.Items)
                .ThenInclude(p => p.Product)
                // .ThenInclude(p => p.CatalogItemImages)
                .SingleOrDefault(p => p.BuyerId == userId);
            if (basket == null)
            {
                return null;
            }
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    ProductId = item.ProductId,
                    Id = item.Id,
                    ProductName = item.Product.PrdName,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    // ImageUrl = uriComposerService.ComposeImageUri(item?.CatalogItem?.CatalogItemImages?.FirstOrDefault()?.Src ?? ""),
                }).ToList(),
            };
        }

        public BasketDto GetOrCreateBasketForUser(string buyerId)
        {
            var basket = _context.Baskets
                .Include(p => p.Items)
                .ThenInclude(p => p.Product)
                // .ThenInclude(p => p.CatalogItemImages)
                .SingleOrDefault(p => p.BuyerId == buyerId);
            if (basket == null)
            {
                // create Basket
                return CreateBasketForUser(buyerId);
            }
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    ProductId = item.ProductId,
                    Id = item.Id,
                    ProductName = item.Product.PrdName,
                    subMenuEnSgname =GetFirstMenu(item.Product.PrdGroupId),
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    // ImageUrl = uriComposerService.ComposeImageUri(item?.CatalogItem?.CatalogItemImages?.FirstOrDefault()?.Src ?? ""),
                }).ToList(),
            };

        }

        public bool RemoveItemFromBasket(int itemId)
        {
            var item = _context.BasketItems.SingleOrDefault(p => p.Id == itemId);
            _context.BasketItems.Remove(item);
            _context.SaveChanges();
            return true;
        }

        public bool SetQuantities(int itemId, int quantity)
        {
            var item = _context.BasketItems.SingleOrDefault(p => p.Id == itemId);
            item.SetQuantity(quantity);
            _context.SaveChanges();
            return true;
        }

        public void TransferBasket(string anonymousId, string userId)
        {
            var anonymousBasket = _context.Baskets
                .Include(b=>b.Items)
                .SingleOrDefault(p => p.BuyerId == anonymousId);
            if (anonymousBasket == null) return;
            var userBasket = _context.Baskets.SingleOrDefault(p => p.BuyerId == userId);
            if (userBasket == null)
            {
                userBasket = new Domain.Entities.Baskets.Basket(userId);
                _context.Baskets.Add(userBasket);
            }

            foreach (var item in anonymousBasket.Items)
            {
                userBasket.AddItem(item.ProductId, item.Quantity, item.UnitPrice);
            }
            _context.Baskets.Remove(anonymousBasket);
            _context.SaveChanges();
        }
        
        private BasketDto CreateBasketForUser(string buyerId)
        {
            Domain.Entities.Baskets.Basket basket = new Domain.Entities.Baskets.Basket(buyerId);
            _context.Baskets.Add(basket);
            _context.SaveChanges();
            return new BasketDto
            {
                BuyerId = basket.BuyerId,
                Id = basket.Id,
            };
        }



        private string GetFirstMenu(int productGroupId)
        {
            var secondGroup = _idealCrmDataBaseContext.WsproductSecondGroup
                .Include(s => s.FirstGroup)
                .ThenInclude(s => s.ParsaPooladMenus)
                .Where(s => s.PrdSecondGroupId == productGroupId)
                .Select(s=>s.FirstGroup.ParsaPooladMenus.UrlName)
                .First();
            
            return secondGroup;
        }
    }
}