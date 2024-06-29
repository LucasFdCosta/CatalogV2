using CatalogV2.Domain.Entities;
using CatalogV2.Domain.Interfaces;
using CatalogV2.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CatalogV2.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _context.Add(category);

            await _context.SaveChangesAsync();

            return category;
        }

        public async Task<Category> GetByIdAsync(int? id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            try
            {
                var categories = await _context.Categories.ToListAsync();
                return categories;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _context.Update(category);

            await _context.SaveChangesAsync();

            return category;
        }

        public async Task<Category> RemoveAsync(Category category)
        {
            _context.Remove(category);

            await _context.SaveChangesAsync();

            return category;
        }
    }
}
