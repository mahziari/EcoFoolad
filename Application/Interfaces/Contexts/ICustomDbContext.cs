using System.Threading;
using System.Threading.Tasks;
using Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using Domain.Entities;
using Domain.Entities.AboutUs;
using Domain.Entities.Baskets;
using Domain.Entities.Blogs;
using Domain.Entities.Experts;
using Domain.Entities.Factory;
using Domain.Entities.FileManagers;
using Domain.Entities.Footer;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces.Contexts
{
    public interface ICustomDbContext
    {
         DbSet<Slider> Sliders { get; set; }
         DbSet<Product>  Products { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<UserAddress> UserAddresses { get; set; } 
        DbSet<Order> Orders { get; set; } 
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Factory> Factories { get; set; }
        DbSet<FileManager> FileManagers { get; set; }
        DbSet<Footer> Footers { get; set; }
        DbSet<BlogCategory> BlogCategories { get; set; } 
        DbSet<Blog> Blogs { get; set; } 
        DbSet<AboutUs> AboutUs { get; set; }
        DbSet<Expert> Experts { get; set; }


        
        
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
