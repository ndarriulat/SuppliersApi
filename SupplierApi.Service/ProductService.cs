using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using SupplierApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierApi.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        public async Task<Product> GetProduct(int? id)
        {
            return await _productRepository.GetProduct(id);
        }

        public async Task Create(string name, int price, int supplierId)
        {
            await _productRepository.Create(name, price, supplierId);  
        }
    }
}
