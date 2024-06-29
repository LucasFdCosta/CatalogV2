using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogV2.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The 'name' is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The 'description' is required")]
        [MinLength(5)]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The 'price' is required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [MaxLength(250)]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "The 'stock' is required")]
        [Range(1, 9999)]
        public int Stock { get; set; }

        [Required(ErrorMessage = "The 'CreatedAt' is required")]
        public DateTime CreatedAt { get; set; }
        public int CategoryId { get; set; }
    }
}
