using CatalogV2.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatalogV2.Infrastructure.EntitiesConfiguration
{
    public class CategoryConfiguration
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.ImageUrl).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Category(1, "Eletronics", "eletronics.jpg"),
                new Category(2, "Food", "food.jpg"),
                new Category(3, "Furniture", "furniture.jpg")
            );
        }
    }
}
