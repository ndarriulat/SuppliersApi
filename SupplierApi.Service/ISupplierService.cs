using SupplierApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierApi.Service
{
    public interface ISupplierService
    {
        public Task<IEnumerable<Supplier>> GetSuppliers();
        public Task<Supplier> GetSupplier(int? id);
    }
}
