namespace WarehouseManagementSystem.Models
{
    public class DocumentItem
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public DocumentItem(int id, int documentId, int productId,
                            decimal quantity, decimal price)
        {
            Id = id;
            DocumentId = documentId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public decimal GetTotal() => Quantity * Price;
    }
}