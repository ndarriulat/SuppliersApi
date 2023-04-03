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


        //// POST: ProductController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
