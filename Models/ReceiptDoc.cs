namespace WarehouseManagementSystem.Models
{
    public class ReceiptDoc : Document
    {
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public ReceiptDoc(int id, string number, int userId, int supplierId)
            : base(id, number, userId)
        {
            SupplierId = supplierId;
        }
    }
}