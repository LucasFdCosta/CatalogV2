using System.ComponentModel.DataAnnotations;

namespace CatalogV2.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The 'name' is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The 'imageUrl' is required")]
        [MinLength(5)]
        [MaxLength(250)]
        public string ImageUrl { get; set; }
    }
}
