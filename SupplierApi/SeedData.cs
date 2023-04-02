//using Microsoft.EntityFrameworkCore;
//using SupplierApi.Data;
//using SupplierApi;

//public static class SeedData
//{
//    public static void Initialize(IServiceProvider serviceProvider)
//    {
//        using (var context = new SupplierApiContext(
//            serviceProvider.GetRequiredService<
//                DbContextOptions<SupplierApiContext>>()))
//        {
//            // Look for any Suppliers.
//            if (context.Product.Any())
//            {
//                return;   // DB has been seeded
//            }
//            //context.Supplier.AddRange(
//            //    new Supplier
//            //    {
//            //        Name = "Cold Drinks Supplier",
//            //        Description = "The best supplier in terms of sodas and other soft drinks",
//            //    },
//            //    new Supplier
//            //    {
//            //        Name = "Cheese & Co.",
//            //        Description = "Cheese provider, used to be called The Farm",
//            //    },
//            //    new Supplier
//            //    {
//            //        Name = "Cookies ABC",
//            //        Description = "Cookies, sweets and other food products",
//            //    }
//            //);
//            //context.Product.AddRange(
//            //    new Product
//            //    {
//            //        Name = "Pepsi",
//            //        Price = 100
//            //    },
//            //    new Product
//            //    {
//            //        Name = "Tomato",
//            //        Price = 15
//            //    },
//            //    new Product
//            //    {
//            //        Name = "Toilet Paper",
//            //        Price = 30
//            //    },
//            //    new Product
//            //    {
//            //        Name = "Gouda Cheese",
//            //        Price = 20
//            //    },
//            //    new Product
//            //    {
//            //        Name = "Chocolate Cookies",
//            //        Price = 70
//            //    },
//            //    new Product
//            //    {
//            //        Name = "Strawberry candies",
//            //        Price = 1
//            //    }
//            //);
//            //context.SaveChanges();
//        }
//    }
//}