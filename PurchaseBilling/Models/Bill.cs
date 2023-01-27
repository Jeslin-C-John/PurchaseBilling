namespace PurchaseBilling.Models
{
    public class Bill
    {
        public int BillingId { get; set; }
        public DateOnly BillDate { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int Amount { get; set; }

    }
}
