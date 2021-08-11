using Application.Services.BackEnd.Admin.BlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.FluentValidationConfig
{
    public static class FluentValidationService
    {
        public static IServiceCollection AddFluentValidationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IValidator<CreateBlogCategoryDto>, CreateBlogCategoryValidator>();
            services.AddTransient<IValidator<EditBlogCategoryDto>, EditBlogCategoryValidator>();
            return services;
        }
    }
}