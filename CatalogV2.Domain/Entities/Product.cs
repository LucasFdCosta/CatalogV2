using CatalogV2.Domain.Validation;

namespace CatalogV2.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Product> Products { get; set; }

        public Product(string name, string imageUrl)
        {
            ValidateDomain(name, imageUrl);
        }

        public Product(int id, string name, string imageUrl)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id.");
            Id = id;
            ValidateDomain(name, imageUrl);
        }

        private void ValidateDomain(string name, string imageUrl)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "The property 'name' is required");

            DomainExceptionValidation.When(string.IsNullOrEmpty(imageUrl),
                "The property 'imageUrl' is required");

            DomainExceptionValidation.When(name.Length < 3,
               "The 'name' has to have at least 3 caracters");

            DomainExceptionValidation.When(imageUrl.Length < 5,
                "The 'imageUrl' has to have at least 5 caracters");

            Name = name;
            ImageUrl = imageUrl;
        }
    }
}
