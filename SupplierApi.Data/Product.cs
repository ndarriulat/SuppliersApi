namespace SupplierApi.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int SupplierId { get; set; }

        public Product()
        {
            
        }

        public Product(string name, int price, int supplierId)
        {
            Name = name;
            Price = price;
            SupplierId = supplierId;
        }
    }
}
