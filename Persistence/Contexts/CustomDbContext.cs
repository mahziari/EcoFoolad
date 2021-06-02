using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Entities.Carts;
using Domain.Entities.Finances;
using Domain.Entities.IdealCrm;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Persistence.Seeds;


namespace  Persistence.Contexts
{
    public class CustomDbContext : DbContext, ICustomDbContext
    {
        // public CustomDbContext()
        // {
        // }

        public CustomDbContext(DbContextOptions<CustomDbContext> options)
            : base(options)
        {
        }
        
        

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Claims> Claims { get; set; }
        
        public DbSet<Product>  Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<RequestPay> RequestPays { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyQueryFilter(modelBuilder);
            modelBuilder.ClaimsSeed();
        }

        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<CartItem>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<RequestPay>().HasQueryFilter(p => !p.IsRemoved);
        }
    }
}