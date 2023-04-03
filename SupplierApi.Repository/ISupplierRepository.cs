using SupplierApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierApi.Repository
{
    public interface ISupplierRepository
    {
        public Task<IEnumerable<Supplier>> GetSuppliers();
        public Task<Supplier> GetSupplier(int? id);
    }
}
