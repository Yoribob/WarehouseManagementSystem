namespace WarehouseManagementSystem.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }

        public Category(int id, string name, string description = "")
        {
            Id = id;
            Name = name;
            Description = description;
            Products = new List<Product>();
        }
    }
}