using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupplierApi;

namespace SupplierApi.Data
{
    public class SupplierApiContext : DbContext
    {
        public SupplierApiContext (DbContextOptions<SupplierApiContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Supplier { get; set; } = default!;
        public DbSet<Product> Product{ get; set; } = default!;

    }
}
