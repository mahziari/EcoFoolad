using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.ConfigResponseCompression
{
    public static class ConfigResponseCompression
    {
        public static IServiceCollection AddResponseCompressionServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = System.IO.Compression.CompressionLevel.Optimal;
            });

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.Providers.Add<GzipCompressionProvider>();
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    "image/svg+xml",
                    "image/jpeg",
                    "image/jpg",
                    "image/png",
                    "application/font-woff2",
                    "application/atom+xml",
                    // General
                    "text/plain",
                    // Static files
                    "text/css",
                    "application/javascript",
                    // MVC
                    "text/html",
                    "application/xml",
                    "text/xml",
                    "application/json",
                    "text/json",
                    // WebAssembly
                    "application/wasm",
                });
            });
            
            return services;
        }
    }
}