using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Baskets;
using Domain.Entities.Factory;
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
         DbSet<Claims> Claims { get; set; }
         DbSet<Product>  Products { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<UserAddress> UserAddresses { get; set; } 
        DbSet<Order> Orders { get; set; } 
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Factory> Factories { get; set; }


        
        
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
