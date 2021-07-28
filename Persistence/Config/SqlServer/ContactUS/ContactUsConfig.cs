using Domain.Entities.ContactUs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config.SqlServer.ContactUS
{
    public class ContactUsConfig:IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
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