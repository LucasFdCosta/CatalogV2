using CatalogV2.Domain.Entities;

namespace CatalogV2.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetByIdAsync(int? id);
        Task<Category> CreateAsync(Category Category);
        Task<Category> UpdateAsync(Category Category);
        Task<Category> RemoveAsync(Category Category);
    }
}
