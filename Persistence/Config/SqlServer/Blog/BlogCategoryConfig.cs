using Domain.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config.SqlServer.Blog
{
    public class BlogCategoryConfig:IEntityTypeConfiguration<BlogCategory>
    {
        public void Configure(EntityTypeBuilder<BlogCategory> builder)
        {
            builder.HasIndex(p => new {p.Name, p.Slug})
                .IsUnique();
           
            builder.Property<string>("Name")
                .HasColumnType("nvarchar(1500)");
            
            builder.Property<string>("Slug")
                .HasColumnType("nvarchar(1500)");
            
            builder.Property<string>("SmallDescription")
                .HasColumnType("nvarchar(MAX)");
            
            builder.Property<string>("LocalTime")
                .HasColumnType("nvarchar(100)");
            
            builder.Property<string>("ImageUrl")
                .HasColumnType("nvarchar(MAX)");
        }
    }
}