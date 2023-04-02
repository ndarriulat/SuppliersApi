using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;

namespace SupplierApi.Service
{
    public class SupplierService
    {
        private readonly SupplierApiContext _context;

        public SupplierService(SupplierApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliers() 
        {
            return await _context.Supplier.ToListAsync();
        }
    }
}