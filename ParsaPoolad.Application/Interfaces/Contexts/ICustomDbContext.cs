using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Interfaces.Contexts
{
    public interface ICustomDbContext
    {
        DbSet<Sliders> Sliders { get; set; } 
        DbSet<Claims> Claims { get; set; }
        DbSet<User> User { get; set; }
        DbSet<Role> Role { get; set; }


        int SaveChanges(bool acceptAllChangesSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        
    }
}
