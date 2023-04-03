using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;

namespace SupplierApi.Service
{
    public class SupplierService : ISupplierService
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

        public async Task<Supplier> GetSupplier(int? id)
        {
            if (id == null || _context.Supplier == null)
            {
                return null;
            }

            var supplier = await _context.Supplier
                .FirstOrDefaultAsync(m => m.Id == id);

            if (supplier == null)
            {
                return null;
            }

            return supplier;
        }
    }
}