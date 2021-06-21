using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Entities.Attributes;
using Domain.Entities.Baskets;
using Domain.Entities.Factory;
using Domain.Entities.FileManager;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Persistence.Seeds;


namespace  Persistence.Contexts
{
    public class CustomDbContext : DbContext, ICustomDbContext
    {
        public CustomDbContext()
        {
        }

        public CustomDbContext(DbContextOptions<CustomDbContext> options)
            : base(options)
        {
        }
        
        

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Claims> Claims { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FileManager> FileManagers { get; set; }
        
        
        
        
         protected override void OnModelCreating(ModelBuilder builder)
         {
             builder.HasDefaultSchema("dbo");
             
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute), true).Length > 0)
                {
                    builder.Entity(entityType.Name).Property<DateTime>("InsertTime").HasDefaultValue(DateTime.Now);
                    builder.Entity(entityType.Name).Property<DateTime?>("UpdateTime");
                    builder.Entity(entityType.Name).Property<DateTime?>("RemoveTime");
                    builder.Entity(entityType.Name).Property<bool>("IsRemoved").HasDefaultValue(false);
                }
            }
           
            builder.Entity<Product>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<BasketItem>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<Basket>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);

            builder.Entity<Order>().OwnsOne(o => o.Address);
            
            builder.ClaimsSeed();
            
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified ||
                p.State == EntityState.Added ||
                p.State == EntityState.Deleted
                );
            
            foreach (var item in modifiedEntries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());

                var inserted = entityType.FindProperty("InsertTime");
                var updated = entityType.FindProperty("UpdateTime");
                var RemoveTime = entityType.FindProperty("RemoveTime");
                var IsRemoved = entityType.FindProperty("IsRemoved");
                
                if (item.State == EntityState.Added && inserted != null)
                {
                    item.Property("InsertTime").CurrentValue = DateTime.Now;
                }
                if (item.State == EntityState.Modified && updated != null)
                {
                    item.Property("UpdateTime").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Deleted && RemoveTime != null && IsRemoved != null)
                {
                    item.Property("RemoveTime").CurrentValue = DateTime.Now;
                    item.Property("IsRemoved").CurrentValue = true;
                    item.State = EntityState.Modified;
                }
            }
            return base.SaveChanges();
        }
    }
}