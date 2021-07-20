using System;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Entities.Attributes;
using Domain.Entities.Baskets;
using Domain.Entities.Blogs;
using Domain.Entities.Factory;
using Domain.Entities.FileManager;
using Domain.Entities.Footer;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Domain.Entities.Products;
using Domain.Entities.Users;
using Persistence.Config.SqlServer.Blog;
using Persistence.Config.SqlServer.Product;
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
        public DbSet<Footer> Footers { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        
        
        
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
            builder.Entity<Blog>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<BlogCategory>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);

            builder.Entity<Order>().OwnsOne(o => o.Address);
            
            builder.ClaimsSeed();
            builder.FootersSeed();
            
            Config(builder);
            
            base.OnModelCreating(builder);
        }
         
         
         private static void Config(ModelBuilder builder)
         {
             builder.ApplyConfiguration(new BlogConfig());
             builder.ApplyConfiguration(new BlogCategoryConfig());
             builder.ApplyConfiguration(new ProductConfig());
         }  

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified ||
                p.State == EntityState.Added || p.State == EntityState.Deleted);
            
            foreach (var item in modifiedEntries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());

                var inserted = entityType.FindProperty("InsertTime");
                var updated = entityType.FindProperty("UpdateTime");
                var removeTime = entityType.FindProperty("RemoveTime");
                var isRemoved = entityType.FindProperty("IsRemoved");
                
                if (item.State == EntityState.Added && inserted != null)
                {
                    item.Property("InsertTime").CurrentValue = DateTime.Now;
                }
                if (item.State == EntityState.Modified && updated != null)
                {
                    item.Property("UpdateTime").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Deleted && removeTime != null && isRemoved != null)
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