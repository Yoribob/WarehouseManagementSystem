namespace WarehouseManagementSystem.Models
{
    public class StockMovement
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public MovementType Type { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Date { get; set; }
        public int DocumentId { get; set; }

        public StockMovement(int id, int productId, MovementType type,
                             decimal quantity, int documentId)
        {
            Id = id;
            ProductId = productId;
            Type = type;
            Quantity = quantity;
            Date = DateTime.Now;
            DocumentId = documentId;
        }
    }
}