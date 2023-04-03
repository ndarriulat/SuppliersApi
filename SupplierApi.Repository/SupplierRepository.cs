using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierApi.Repository
{
    public class SupplierRepository: ISupplierRepository
    {
        private readonly SupplierApiContext _context;

        public SupplierRepository(SupplierApiContext context)
        {
            _context = context;
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

        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _context.Supplier.ToListAsync();
        }
    }
}
