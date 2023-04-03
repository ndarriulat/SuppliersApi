using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupplierApi;
using SupplierApi.Data;
using SupplierApi.Service;

namespace SupplierApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuppliersController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(SupplierApiContext context, ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [Route("/Suppliers/Index")]
        [HttpGet]
        public async Task<IEnumerable<Supplier>> Index()
        {
            return await _supplierService.GetSuppliers();
        }

        [Route("/Suppliers/GetById")]
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            var supplier = await _supplierService.GetSupplier(id);
            if (supplier != null)
            {
                return Json(supplier);
            }
            else
            {
                return NotFound();
            }
        }


    }
}
