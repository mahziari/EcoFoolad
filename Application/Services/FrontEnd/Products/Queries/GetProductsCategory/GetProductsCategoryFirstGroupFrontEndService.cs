using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace Application.Services.FrontEnd.Products.Queries.GetProductsCategory
{
    public class GetProductsCategoryFirstGroupFrontEndService:IGetProductsCategoryFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _idealCrmDataBase;
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetProductsCategoryFirstGroupFrontEndService(IIdealCrmDataBaseContext idealCrmDataBase, ICustomDbContext customDbContext, IMapper mapper)
        {
            _idealCrmDataBase = idealCrmDataBase;
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

     public ResultGetProductsCategoryFrontEndDto Execute(ProductsFiltersDto productsFiltersDto)
        {
            var parsapooladMenus = _idealCrmDataBase.ParsaPooladMenus
                .SingleOrDefault(s => s.UrlName == productsFiltersDto.FirstGroupName.Replace("-"," "));
  
            // Paginate Code
            var resultInEachPage = 16;
            int skip = (productsFiltersDto.PageNum - 1) * resultInEachPage;
            int count = _idealCrmDataBase.Wsproducts
                .Include(p => p.PrdGroup)
                .ThenInclude(p=>p.FirstGroup)
                .ThenInclude(p=>p.ParsaPooladMenus)
                .Where(p => p.PrdGroup.FirstGroup.ParsaPooladMenus.ParsaPooladMenusId == parsapooladMenus.ParsaPooladMenusId)
                .Count(p => p.PrdInactiveInSale == true);
            var pageId = productsFiltersDto.PageNum;
            var pageCount = (int) Math.Ceiling(count / (double) resultInEachPage);
            // Paginate Code

            var query = _idealCrmDataBase.Wsproducts
                .Include(p => p.PrdUnit)
                .Include(p => p.PrdShpotherSupplier)
                .Include(p => p.PrdGroup)
                .ThenInclude(p=>p.FirstGroup)
                .ThenInclude(p=>p.ParsaPooladMenus)
                .Where(p => p.PrdGroup.FirstGroup.ParsaPooladMenus.ParsaPooladMenusId == parsapooladMenus.ParsaPooladMenusId)
                .Where(p => p.PrdInactiveInSale == true)
                .OrderByDescending(p => p.ProductId)
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
                    .OrderByDescending(p => p.OrderItems.Count);
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
                // UrlName = parsapooladMenu.UrlName,
                PrdInactiveInSale = p.PrdInactiveInSale,
                RegisterDatePersian = p.RegisterDatePersian,
                // PrdUnit = _idealCrmDataBase.WsproductUnits.SingleOrDefault(u => u.ProductUnitId == p.PrdUnitId).Unit,
                PrdUnit = p.PrdUnit.Unit,
                PrdMaxQty = p.PrdMaxQty,
                PrdSize = p.PrdSize,
                PrdModel = p.PrdModel,
                PrdPrice = p.PrdPrice,
                PrdDescription = p.PrdDescription,
                DateTime = p.RegisterDate,
                subMenu = new GetIndexMenuDto{ EnSgname = productsFiltersDto.MenuName,},
            }).Skip(skip).Take(resultInEachPage).ToList();


            var mFactories = _customDbContext.Factories.ToList();
            var factories = _mapper.Map<List<FactoriesDto>>(mFactories);
            
            var mCompanies = _idealCrmDataBase.CrmCompany.Where(c=>c.IsFactory).ToList();
            var companies = _mapper.Map<List<CompanyDto>>(mCompanies);
            
            
            return new ResultGetProductsCategoryFrontEndDto
            {
                Products = products,
                PageId = pageId,
                PageCount = pageCount,
                Factories = factories,
                Companies = companies,
            };
        }
    }
}