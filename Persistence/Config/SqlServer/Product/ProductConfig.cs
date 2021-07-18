using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config.SqlServer.Product
{

    public class ProductConfig : IEntityTypeConfiguration<Domain.Entities.Products.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Products.Product> builder)
        {
            builder.Property<string>("LocalTime")
                .HasColumnType("nvarchar(100)");
           
            builder.Property<int>("VisitCount")
                .HasDefaultValue(0);
        }
    }
}