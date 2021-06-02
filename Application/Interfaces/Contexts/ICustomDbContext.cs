using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Carts;
using Domain.Entities.Finances;
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
         DbSet<Cart> Carts { get; set; }
         DbSet<CartItem> CartItems { get; set; }
         DbSet<RequestPay> RequestPays { get; set; }

        
        
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
