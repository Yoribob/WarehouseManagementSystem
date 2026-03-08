namespace WarehouseManagementSystem.Models
{
    public enum UserRole
    {
        Admin,
        Storekeeper,
        Manager
    }

    public enum DocStatus
    {
        Draft,
        Confirmed,
        Cancelled
    }

    public enum MovementType
    {
        Receipt,
        Issue,
        Transfer
    }
}