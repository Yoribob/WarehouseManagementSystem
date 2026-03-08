namespace WarehouseManagementSystem.Models
{
    public abstract class Document
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public DocStatus Status { get; private set; }
        public List<DocumentItem> Items { get; set; }

        protected Document(int id, string number, int userId)
        {
            Id = id;
            Number = number;
            Date = DateTime.Now;
            UserId = userId;
            Status = DocStatus.Draft;
            Items = new List<DocumentItem>();
        }

        public void Confirm()
        {
            if (Status != DocStatus.Draft)
                throw new InvalidOperationException("Можна провести лише чернетку.");
            Status = DocStatus.Confirmed;
        }

        public void Cancel()
        {
            if (Status == DocStatus.Cancelled)
                throw new InvalidOperationException("Документ вже скасовано.");
            Status = DocStatus.Cancelled;
        }
    }
}