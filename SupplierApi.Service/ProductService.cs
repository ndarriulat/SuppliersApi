using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierApi.Service
{
    public class ProductService
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
    }
}
