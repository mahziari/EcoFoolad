using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Factory;
using Domain.Entities.IdealCrm;
using Microsoft.EntityFrameworkCore;


namespace Application.Services.FrontEnd.Products.Queries
{
    public interface IGetProductsCategoryFrontEndService
    {
        ResultGetProductsCategoryFrontEndDto Execute(ProductsFiltersDto productsFiltersDto);
    }

    public class GetProductsCategoryFrontEndService : IGetProductsCategoryFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _idealCrmDataBase;
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetProductsCategoryFrontEndService(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext,
            IMapper mapper)
        {
            _idealCrmDataBase = context;
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public ResultGetProductsCategoryFrontEndDto Execute(ProductsFiltersDto productsFiltersDto)
        {
            var secondGroup = _idealCrmDataBase.WsproductSecondGroup
                .FirstOrDefault(s => s.Sgname == productsFiltersDto.MenuName.Replace("-", " "));

            var firstGroup = _idealCrmDataBase.WsproductFirstGroup
                .Where(s => s.PrdFirstGroupId == secondGroup.FirstGroupId)
                .Select(s => s.ParsaPooladMenusId)
                .FirstOrDefault();

            var parsapooladMenu = _idealCrmDataBase.ParsaPooladMenus
                .FirstOrDefault(s => s.ParsaPooladMenusId == firstGroup);


            // Paginate Code
            var resultInEachPage = 1;
            int skip = (productsFiltersDto.PageNum - 1) * resultInEachPage;
            int count = _idealCrmDataBase.Wsproducts
                .Where(p => p.PrdGroupId == secondGroup.PrdSecondGroupId)
                .Count(p => p.PrdInactiveInSale == true);
            var pageId = productsFiltersDto.PageNum;
            var pageCount = (int) Math.Ceiling(count / (double) resultInEachPage);
            // Paginate Code


            var query = _idealCrmDataBase.Wsproducts
                .Include(p => p.PrdUnit)
                // .Include(p => p.PrdSize)
                // .Include(p => p.PrdShpotherSupplier)
                .OrderByDescending(p => p.ProductId)
                .Where(p => p.PrdGroupId == secondGroup.PrdSecondGroupId)
                .Where(p => p.PrdInactiveInSale == true)
                .AsQueryable();

            if (productsFiltersDto.CompanyId != null)
            {
                query = query.Where(p => productsFiltersDto.CompanyId.Any(b => b == p.PrdShpotherSupplierId));
            }

            // if (productsFiltersDto.CatalogTypeId != null)
            // {
            //     query = query.Where(p => p.CatalogTypeId == productsFiltersDto.CatalogTypeId);
            // }

            if (!string.IsNullOrEmpty(productsFiltersDto.SearchKey))
            {
                query = query.Where(p => p.PrdName.Contains(productsFiltersDto.SearchKey));
            }


            // if (productsFiltersDto.AvailableStock == true)
            // {
            //     query = query.Where(p => p.AvailableStock > 0);
            // }


            if (productsFiltersDto.SortType == SortType.Bestselling)
            {
                query = query.Include(p => p.OrderItems)
                    .OrderByDescending(p => p.OrderItems.Count());
            }

            // if (productsFiltersDto.SortType == SortType.MostPopular)
            // {
            //     query = query.Include(p => p.CatalogItemFavourites)
            //         .OrderByDescending(p => p.CatalogItemFavourites.Count());
            // }


            if (productsFiltersDto.SortType == SortType.MostVisited)
            {
                query = query
                    .OrderByDescending(p => p.VisitCount);
            }

            if (productsFiltersDto.SortType == SortType.newest)
            {
                query = query
                    .OrderByDescending(p => p.ProductId);
            }

            if (productsFiltersDto.SortType == SortType.cheapest)
            {
                query = query
                    // .Include(p => p.Discounts)
                    .OrderBy(p => p.PrdPrice);
            }

            if (productsFiltersDto.SortType == SortType.mostExpensive)
            {
                query = query
                    // .Include(p => p.Discounts)
                    .OrderByDescending(p => p.PrdPrice);
            }

            var products = query.Select(p => new GetIndexProductsDto
            {
                ProductId = p.ProductId,
                PrdName = p.PrdName,
                UrlName = parsapooladMenu.UrlName,
                PrdInactiveInSale = p.PrdInactiveInSale,
                RegisterDatePersian = p.RegisterDatePersian,
                PrdUnit = _idealCrmDataBase.WsproductUnits.SingleOrDefault(u => u.ProductUnitId == p.PrdUnitId).Unit,
                PrdMaxQty = p.PrdMaxQty,
                PrdSize = p.PrdSize,
                PrdModel = p.PrdModel,
                PrdPrice = p.PrdPrice,
                PrdDescription = p.PrdDescription,
                DateTime = p.RegisterDate,
            }).Skip(skip).Take(resultInEachPage).ToList();


            var mFactories = _customDbContext.Factories.ToList();
            var factories = _mapper.Map<List<FactoriesDto>>(mFactories);

            return new ResultGetProductsCategoryFrontEndDto
            {
                Products = products,
                PageId = pageId,
                PageCount = pageCount,
                Factories = factories,
            };
        }
    }

    public class ResultGetProductsCategoryFrontEndDto
    {
        public List<GetIndexProductsDto> Products { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
        public string UrlName { get; set; }
        public string CategoryName { get; set; }
        public string MenuName { get; set; }
        public int PageNum { get; set; } = 1;
        public List<FactoriesDto> Factories { get; set; }
    }


    public class GetIndexProductsDto
    {
        public int ProductId { get; set; }
        public string PrdName { get; set; }
        public string UrlName { get; set; }
        public bool? PrdInactiveInSale { get; set; }
        public string RegisterDatePersian { get; set; }
        public DateTime DateTime { get; set; }
        public string PrdUnit { get; set; }
        public int? PrdMaxQty { get; set; }
        public string PrdSize { get; set; }
        public string PrdModel { get; set; }
        public decimal? PrdPrice { get; set; }
        public string PrdDescription { get; set; }
        public GetIndexMenuDto subMenu { get; set; }
    }

    public class FactoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GetIndexMenuDto
    {
        public string Sgname { get; set; }
    }

    public class ProductsFiltersDto
    {
        public int? CatalogTypeId { get; set; }
        public int[] CompanyId { get; set; }
        public bool AvailableStock { get; set; }
        public string SearchKey { get; set; }
        public string CategoryName { get; set; }
        public string MenuName { get; set; }
        public int PageNum { get; set; } = 1;
        public int PageSize { get; set; } = 16;
       
        public SortType SortType { get; set; }
    }

    public enum SortType
    {
        /// <summary>
        /// بدونه مرتب سازی
        /// </summary>
        None = 0,

        /// <summary>
        /// پربازدیدترین
        /// </summary>
        MostVisited = 1,

        /// <summary>
        /// پرفروش‌ترین
        /// </summary>
        Bestselling = 2,

        /// <summary>
        /// محبوب‌ترین
        /// </summary>
        MostPopular = 3,

        /// <summary>
        ///  ‌جدیدترین
        /// </summary>
        newest = 4,

        /// <summary>
        /// ارزان‌ترین
        /// </summary>
        cheapest = 5,

        /// <summary>
        /// گران‌ترین
        /// </summary>
        mostExpensive = 6,
    }
}