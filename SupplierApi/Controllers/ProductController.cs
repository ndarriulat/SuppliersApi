using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;

namespace SupplierApi.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private readonly SupplierApiContext _context;

        public ProductController(SupplierApiContext context)
        {
            _context = context;
        }

        // GET: ProductController
        [Route("/Product/Index")]
        [HttpGet]
        public async Task<IEnumerable<Product>> Index()
        {
            return await _context.Product.ToListAsync();
        }

        // GET: ProductController/Details/5
        [Route("/Details")]
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Supplier == null)
            {
                return NotFound();
            }

            var supplier = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return Json(supplier);
        }

        // GET: ProductController/Create
        [Route("/Create")]
        [HttpPost]
        public async Task<ActionResult> Create(string name, int price, int supplierId)
        {
            await _context.AddAsync(new Product(name, price, supplierId));
            await _context.SaveChangesAsync();
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
