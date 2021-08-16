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
                .Single(s => s.UrlName == productsFiltersDto.FirstGroupName.Replace("-"," "));

            var query = _idealCrmDataBase.Wsproducts
                .Include(p => p.PrdGroup)
                .Where(p => p.PrdGroup.FirstGroup.ParsaPooladMenus.ParsaPooladMenusId == parsapooladMenus.ParsaPooladMenusId)
                .Where(p => p.PrdInactiveInSale == true)
                .OrderByDescending(p => p.PrdPrice)
                .Take(10)
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
                PrdCode = p.PrdCode,
                PrdName = p.PrdName,
                PrdInactiveInSale = p.PrdInactiveInSale,
                RegisterDatePersian = p.RegisterDatePersian,
                PrdUnit = p.PrdUnit,
                PrdShpotherSupplier = p.PrdShpotherSupplier,
                PrdMaxQty = p.PrdMaxQty,
                PrdSize = p.PrdSize,
                PrdModel = p.PrdModel,
                PrdPrice = p.PrdPrice,
                PrdDescription = p.PrdDescription,
                DateTime = p.RegisterDate,
                subMenu = new GetIndexMenuDto{ EnSgname = productsFiltersDto.FirstGroupName,},
            }).ToList();


            var mFactories = _customDbContext.Factories.ToList();
            var factories = _mapper.Map<List<FactoriesDto>>(mFactories);
            
            var mCompanies = _idealCrmDataBase.CrmCompany
                .Where(c=>c.IsFactory)
                .Where(c=>c.ParsaPooladMenusId==parsapooladMenus.ParsaPooladMenusId)
                .ToList();
            var companies = _mapper.Map<List<CompanyDto>>(mCompanies);

            var expertModel = _customDbContext.Experts.ToList();
            var experts = _mapper.Map<List<ExpertsDto>>(expertModel);
            
            
            return new ResultGetProductsCategoryFrontEndDto
            {
                FirstMenuName=parsapooladMenus,
                Products = products,
                Factories = factories,
                Companies = companies,
                Experts = experts,
            };
        }
    }
}