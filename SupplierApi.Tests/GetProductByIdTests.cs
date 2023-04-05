using FakeItEasy;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework.Constraints;
using SupplierApi.Data;
using SupplierApi.Repository;
using SupplierApi.Service;

namespace SupplierApi.Tests
{
    public class GetProductByIdTests
    {
        private IProductService? _productService;
        private readonly Mock<IProductRepository> _productRepositoryMock = new();

        [Test]
        public async Task GetProductWhenIdIsNull()
        {
            // Arrange
            int? id = null;
            _productService = new ProductService(_productRepositoryMock.Object);

            // Act
            var product = await _productService.GetProduct(id);

            // Assert
            Assert.IsNull(product);
        }

        [Test]
        public async Task GetProductWhenProductListIsEmpty()
        {
            // Arrange
            int? id = A.Dummy<int>();
            _productService = new ProductService(_productRepositoryMock.Object);

            // Act
            var product = await _productService.GetProduct(id);

            // Assert
            Assert.IsNull(product);
        }

        [Test]
        public async Task GetProductWhenProductIsValid()
        {
            // Arrange
            var productId = 500;
            var productName = "Test Product";
            var productPrice = 120;
            var productSupplierId = 15;
            _productRepositoryMock
                .Setup(p => p.GetProduct(productId))
                .ReturnsAsync(new Product { Id = productId, 
                    Name = productName, 
                    Price = productPrice, 
                    SupplierId = productSupplierId });
            
            _productService = new ProductService(_productRepositoryMock.Object);

            // Act
            var product = await _productService.GetProduct(productId);

            // Assert
            _productRepositoryMock.Verify(p => p.GetProduct(productId));
            Assert.That(product, Is.Not.Null);
            Assert.That(product.Name, Is.EqualTo(productName));
            Assert.That(product.Price, Is.EqualTo(productPrice));
            Assert.That(product.SupplierId, Is.EqualTo(productSupplierId));
        }


    }
}