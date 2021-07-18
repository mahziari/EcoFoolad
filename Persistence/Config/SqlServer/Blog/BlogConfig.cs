using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config.SqlServer.Blog
{
    public class BlogConfig:IEntityTypeConfiguration<Domain.Entities.Blogs.Blog>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Blogs.Blog> builder)
        {
            builder.HasIndex(p => new { p.BlogCategoryId,p.Title, p.Slug})
                .IsUnique();
           
            builder.Property<string>("Title")
                .HasColumnType("nvarchar(1500)");
           
            builder.Property<string>("Slug")
                .HasColumnType("nvarchar(1500)");
           
            builder.Property<string>("SmallDescription")
                .HasColumnType("nvarchar(MAX)");
           
            builder.Property<string>("Body")
                .HasColumnType("ntext");
           
            builder.Property<string>("LocalTime")
                .HasColumnType("nvarchar(100)");
            
            builder.Property<string>("Author")
                .HasColumnType("nvarchar(200)");
            
            builder.Property<string>("ImageUrl")
                .HasColumnType("nvarchar(MAX)");
           
            builder.Property<int>("VisitCount")
                .HasDefaultValue(0);
        }
    }
}