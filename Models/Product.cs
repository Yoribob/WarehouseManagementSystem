namespace WarehouseManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public int CategoryId { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public decimal MinQuantity { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, string sku, int categoryId,
                       string unit, decimal minQuantity, decimal price)
        {
            Id = id;
            Name = name;
            SKU = sku;
            CategoryId = categoryId;
            Unit = unit;
            Quantity = 0;
            MinQuantity = minQuantity;
            Price = price;
        }

        public bool IsLowStock() => Quantity <= MinQuantity;

        public override string ToString() => $"{Name} ({SKU}) - {Quantity} {Unit}";
    }
}