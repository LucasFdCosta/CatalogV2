using CatalogV2.Domain.Entities;
using CatalogV2.Domain.Interfaces;
using CatalogV2.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CatalogV2.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Add(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            //return await _context.Produtos.FindAsync(id);
            return await _context.Products.Include(c => c.Category).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _context.Update(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _context.Remove(product);

            await _context.SaveChangesAsync();

            return product;
        }
    }
}
