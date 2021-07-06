using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebMarkupMin.AspNetCore5;

namespace Infrastructure.Configuration.HtmlMinifyConfig
{
    public static class HtmlMinifyConfig
    {
        public static IServiceCollection AddWebMarkupMinService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddWebMarkupMin(options =>
            {
                options.AllowMinificationInDevelopmentEnvironment = false;
            }).AddHtmlMinification(options =>
            {
                options.MinificationSettings.RemoveHtmlComments = true;
                options.MinificationSettings.RemoveHtmlCommentsFromScriptsAndStyles = true;
                options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
                options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
                options.MinificationSettings.RemoveOptionalEndTags = true;
                options.MinificationSettings.RemoveTagsWithoutContent = true;
                options.MinificationSettings.MinifyEmbeddedCssCode = true;
                options.MinificationSettings.MinifyEmbeddedJsCode = true;
                options.MinificationSettings.MinifyInlineCssCode = true;
                options.MinificationSettings.MinifyInlineJsCode = true;
            });

            return services;
        }
    }
}