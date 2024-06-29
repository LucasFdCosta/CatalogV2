using CatalogV2.Domain.Validation;

namespace CatalogV2.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string ImageUrl { get; private set; }
        public int Stock { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public void Update(string name, string description, decimal price, string imageUrl, int stock, DateTime createdAt, int categoryId)
        {
            ValidateDomain(name, description, price, imageUrl, stock, createdAt);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, string imageUrl, int stock, DateTime createdAt)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "The property 'name' is required");

            DomainExceptionValidation.When(name.Length < 3, "The 'name' has to have at least 3 caracters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "The property 'description' is required");

            DomainExceptionValidation.When(description.Length < 5, "The 'name' has to have at least 5 caracters");

            DomainExceptionValidation.When(price < 0, "The property 'price' has to be greater than 0");

            DomainExceptionValidation.When(imageUrl?.Length > 250, "The property 'name' cannot exceed 250 caracters");

            DomainExceptionValidation.When(stock < 0, "The property 'stock' has to be greater than 0");

            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            Stock = stock;
            CreatedAt = createdAt;
        }
    }
}
