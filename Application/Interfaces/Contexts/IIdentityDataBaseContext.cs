using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Baskets;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces.Contexts
{
    public interface IIdentityDataBaseContext
    {
         DbSet<User> Users { get; set; }
    }
}
