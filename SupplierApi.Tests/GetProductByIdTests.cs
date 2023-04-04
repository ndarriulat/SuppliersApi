using FakeItEasy;
using Moq;
using NUnit.Framework.Constraints;
using SupplierApi.Data;
using SupplierApi.Repository;

namespace SupplierApi.Tests
{
    public class GetProductByIdTests
    {
        private IProductRepository _productRepository;
        private readonly Mock<SupplierApiContext> _context = new();

        [SetUp]
        public void Setup()
        {
            _productRepository = new ProductRepository(_context.Object);
        }

        [Test]
        public void GetProductWhenIdIsNull()
        {
            // Arrange
            int? id = null;

            // Act
            var product = _productRepository.GetProduct(id);

            // Assert
            Assert.IsNull(product);
        }

        [Test]
        public void GetProductWhenProductListIsEmpty()
        {
            // Arrange
            _context.Setup(c => c.Product == null);
            int? id = A.Dummy<int>();

            // Act
            var product = _productRepository.GetProduct(id);

            // Assert
            Assert.IsNull(product);
        }
    }
}