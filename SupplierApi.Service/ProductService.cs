using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierApi.Service
{
    public class ProductService : IProductService
    {
        private readonly SupplierApiContext _context;

        public ProductService(SupplierApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetProduct(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return null;
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return null;
            }

            return product;
        }

        public async Task Create(string name, int price, int supplierId)
        {
            await _context.AddAsync(new Product(name, price, supplierId));
            await _context.SaveChangesAsync();
        }
    }
}
