using System.IO.Compression;
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
            // services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
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
                    "application/font-woff",
                    "application/x-font-ttf",
                    "application/atom+xml",
                    "application/xaml+xml",
                    "application/octet-strea",
                    // General
                    "text/plain",
                    // Static files
                    "text/css",
                    "application/javascript",
                    // MVC
                    "text/html",
                    "text/xml",
                    "text/json",
                    "application/xml",
                    "application/json",
                    // WebAssembly
                    "application/wasm",
                });
            });

            return services;
        }
    }
}