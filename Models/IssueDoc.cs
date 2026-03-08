namespace WarehouseManagementSystem.Models
{
    public class IssueDoc : Document
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public IssueDoc(int id, string number, int userId, int customerId)
            : base(id, number, userId)
        {
            CustomerId = customerId;
        }
    }
}