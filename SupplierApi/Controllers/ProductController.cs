using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using SupplierApi.Service;

namespace SupplierApi.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(SupplierApiContext context, IProductService productService)
        {
            _productService = productService;
        }

        [Route("/Product/Index")]
        [HttpGet]
        public async Task<IEnumerable<Product>> Index()
        {
            return await _productService.GetProducts();
        }

        [Route("/GetById")]
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            var product = await _productService.GetProduct(id);

            if (product != null)
            {
                return Json(product);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("/Create")]
        [HttpPost]
        public async Task<ActionResult> Create(string name, int price, int supplierId)
        {
            await _productService.Create(name, price, supplierId);
            return Ok();
        }

    }
}
