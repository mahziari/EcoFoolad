using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Interfaces.FacadPatterns.BackEnd.Owner;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.BackEnd.Admin.Blogs.FacadPattern;
using Application.Services.BackEnd.Admin.BlogsCategories.FacadPattern;
using Application.Services.BackEnd.Admin.Company.FacadPattern;
using Application.Services.BackEnd.Admin.Factory.FacadPattern;
using Application.Services.BackEnd.Admin.FileManager.FacadPattern;
using Application.Services.BackEnd.Admin.Footers;
using Application.Services.BackEnd.Admin.Home.FacadPattern;
using Application.Services.BackEnd.Admin.Menus.FacadPattern;
using Application.Services.BackEnd.Admin.Products.FacadPattern;
using Application.Services.BackEnd.Admin.Roles.FacadPattern;
using Application.Services.BackEnd.Admin.Sliders.FacadPattern;
using Application.Services.BackEnd.Admin.Users.FacadPattern;
using Application.Services.BackEnd.Owner.Home.FacadPattern;
using Application.Services.BackEnd.Owner.Products.FacadPattern;
using Application.Services.BackEnd.Owner.Profile.FacadPattern;
using Application.Services.BackEnd.User.Addresses;
using Application.Services.BackEnd.User.Home;
using Application.Services.BackEnd.User.Orders;
using Application.Services.FrontEnd.Basket;
using Application.Services.FrontEnd.Blogs.FacadPattern;
using Application.Services.FrontEnd.Common;
using Application.Services.FrontEnd.Common.Footers.FacadPattern;
using Application.Services.FrontEnd.Common.Menus.FacadPattern;
using Application.Services.FrontEnd.Home.FacadPattern;
using Application.Services.FrontEnd.Orders;
using Application.Services.FrontEnd.Payments;
using Application.Services.FrontEnd.Products.FacadPattern;
using Application.Services.FrontEnd.SiteMaps.FacadPattern;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.FacadConfig
{
    public static class FacadConfig
    {
        public static IServiceCollection AddFacadService(this IServiceCollection services, IConfiguration configuration)
        {
            //------ Interface Services
            services.AddScoped<IMenusFrontEndFacad, MenusFrontEndFacad>();
            services.AddScoped<IHomeFrontEndFacad, HomeFrontEndFacad>();
            services.AddScoped<IBlogsFrontEndFacad, BlogsFrontEndFacad>();
            services.AddScoped<IProductsFrontEndFacad, ProductsFrontEndFacad>();
            services.AddTransient<IBasketService, BasketService>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<IPaymentsServices, PaymentsServices>();
            services.AddTransient<IFootersFrontEndFacad, FootersFrontEndFacad>();
            services.AddScoped<ISiteSetting, SiteSetting>();
            services.AddScoped<ISiteMapFacad, SiteMapFacad>();
            //------ Admin Panel Services
            services.AddScoped<IMenusFacad, MenusFacad>();
            services.AddScoped<IProductsFacad, ProductsFacad>();
            services.AddScoped<IBlogsCategoriesFacad, BlogsCategoriesFacad>();
            services.AddScoped<IBlogsFacad, BlogsFacad>();
            services.AddScoped<IRolesFacad, RolesFacad>();
            services.AddScoped<IUsersFacad, UsersFacad>();
            services.AddScoped<ISlidersFacad, SlidersFacad>();
            services.AddScoped<ICompanyFacad, CompanyFacad>();
            services.AddScoped<IFactoryFacad, FactoryFacad>();
            services.AddScoped<IHomeFacad, HomeFacad>();
            services.AddScoped<IFileManagerFacad, FileManagerFacad>();
            services.AddScoped<IFootersServices, FootersServices>();
            //------ Owner Panel Services
            services.AddScoped<IOwnerProductsFacad, OwnerProductsFacad>();
            services.AddScoped<IOwnerHomeFacad, OwnerHomeFacad>();
            services.AddScoped<IOwnerProfileFacad, OwnerProfileFacad>();
            //------ User Panel Services
            services.AddTransient<IUserAddressServices, UserAddressServices>();
            services.AddTransient<IUserOrdersServices, UserOrdersServices>();
            services.AddTransient<IUserHomeServices, UserHomeServices>();

            
            return services;

        }
    }
}