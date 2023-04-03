using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using SupplierApi.Repository;

namespace SupplierApi.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _supplierRepository.GetSuppliers();
        }

        public async Task<Supplier> GetSupplier(int? id)
        {
            return await _supplierRepository.GetSupplier(id);
        }
    }
}