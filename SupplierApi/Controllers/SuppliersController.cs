﻿using System;
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
        private readonly SupplierApiContext _context;
        private readonly SupplierService _supplierService;

        public SuppliersController(SupplierApiContext context, SupplierService supplierService)
        {
            _supplierService = supplierService;
            _context = context;
        }

        // GET: Suppliers
        [Route("/Suppliers/Index")]
        [HttpGet]
        public async Task<IEnumerable<Supplier>> Index()
        {
            return await _supplierService.GetSuppliers();
        }

        //GET: Suppliers/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Supplier == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return Json(supplier);
        }

        //// GET: Suppliers/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Suppliers/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Description")] Supplier supplier)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(supplier);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(supplier);
        //}

        //// GET: Suppliers/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Supplier == null)
        //    {
        //        return NotFound();
        //    }

        //    var supplier = await _context.Supplier.FindAsync(id);
        //    if (supplier == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(supplier);
        //}

        //// POST: Suppliers/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Supplier supplier)
        //{
        //    if (id != supplier.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(supplier);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SupplierExists(supplier.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(supplier);
        //}

        //// GET: Suppliers/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Supplier == null)
        //    {
        //        return NotFound();
        //    }

        //    var supplier = await _context.Supplier
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (supplier == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(supplier);
        //}

        //// POST: Suppliers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Supplier == null)
        //    {
        //        return Problem("Entity set 'SupplierApiContext.Supplier'  is null.");
        //    }
        //    var supplier = await _context.Supplier.FindAsync(id);
        //    if (supplier != null)
        //    {
        //        _context.Supplier.Remove(supplier);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SupplierExists(int id)
        //{
        //  return (_context.Supplier?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
