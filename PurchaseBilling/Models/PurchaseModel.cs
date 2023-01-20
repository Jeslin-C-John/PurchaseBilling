using System.ComponentModel.DataAnnotations;

namespace PurchaseBilling.Models
{
    public class PurchaseModel
    {
        [Key]
        public int PurchaseId { get; set; }
        public int BillingId { get; set; }
        public int ProductId { get;set; }
        public int Quantity { get; set; }
    }
}
