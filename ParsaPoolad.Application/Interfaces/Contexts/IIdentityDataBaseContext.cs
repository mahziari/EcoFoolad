using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using ParsaPoolad.Domain.Entities.DbTwoEntities;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Interfaces.Contexts
{
    public interface IIdentityDataBaseContext
    {
        DbSet<Sliders> Sliders { get; set; } 
        DbSet<Claims> Claims { get; set; }


        int SaveChanges(bool acceptAllChangesSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        
    }
}
