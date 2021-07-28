using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config.SqlServer.AboutUs
{
    public class AboutUsConfig:IEntityTypeConfiguration<Domain.Entities.AboutUs.AboutUs>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.AboutUs.AboutUs> builder)
        {
            builder.Property<string>("ImageUrl")
                .HasColumnType("nvarchar(1500)");
            
            builder.Property<string>("Body")
                .HasColumnType("ntext");
            
            builder.Property<string>("Member1")
                .HasColumnType("nvarchar(1500)");
            
            builder.Property<string>("Member2")
                .HasColumnType("nvarchar(1500)");
            
            builder.Property<string>("Member3")
                .HasColumnType("nvarchar(1500)");
        }  
    }
}