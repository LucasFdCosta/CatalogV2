using CatalogV2.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatalogV2.Infrastructure.EntitiesConfiguration
{
    public class ProductConfiguration
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            
            builder.Property(p => p.Price).HasPrecision(10, 2);
            builder.Property(p => p.ImageUrl).HasMaxLength(250);
            builder.Property(p => p.Stock).HasDefaultValue(1).IsRequired();
            builder.Property(p => p.CreatedAt).IsRequired();

            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
