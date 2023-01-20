using System.ComponentModel.DataAnnotations;

namespace PurchaseBilling.Models
{
    public class BillingModel
    {
        [Key]
        public int BillingId { get; set; }
        public DateTime BillDate { get; set; }
        public int UserID { get; set;}
    }
}
