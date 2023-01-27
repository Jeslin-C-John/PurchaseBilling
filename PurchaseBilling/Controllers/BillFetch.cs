using Microsoft.AspNetCore.Mvc;
using PurchaseBilling.Data;
using PurchaseBilling.Models;

namespace PurchaseBilling.Controllers
{
    public class BillFetch : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BillingModel e)
        {
            var BillingId=e.BillingId;

            DboContext ContextObj = new DboContext();

            var BillDetails = (from d in ContextObj.Purchases

                               join b in ContextObj.Products
                               on d.ProductId equals b.ProductId

                               join c in ContextObj.Billings
                               on d.BillingId equals c.BillingId

                               join a in ContextObj.Users
                               on c.UserID equals a.UserId



                               select new
                               {
                                   UserId = a.UserId,
                                   UserName = a.UserName,
                                   Address = a.Address,
                                   Phone = a.Phone,
                                   BillingId = c.BillingId,
                                   BillDate = c.BillDate,

                                   ProductId= b.ProductId,
                                   ProductName= b.ProductName,
                                   ProductPrice=b.Price,
                                   ProductQuantity=d.Quantity,
                                   Amount = b.Price * d.Quantity


                               })
                         .Where(c => c.BillingId == e.BillingId)
                         .ToList();

           


            var BillList = new List<Bill>();
            for(int i = 0; i < BillDetails.Count; i++)
            {
                var BillObj=new Bill();

                BillObj.BillingId = BillDetails[i].BillingId;
                BillObj.UserId= BillDetails[i].UserId;
                BillObj.UserName= BillDetails[i].UserName;
                BillObj.Address= BillDetails[i].Address;
                BillObj.Phone= BillDetails[i].Phone;

                string? LongStringDate = BillDetails[i].BillDate.ToString();
                string? ShortStringDate = LongStringDate.Substring(0, 10);
                DateOnly.TryParse(ShortStringDate, out DateOnly DateOnlyShort);
                BillObj.BillDate= DateOnlyShort;

                BillObj.ProductId= BillDetails[i].ProductId;
                BillObj.ProductName= BillDetails[i].ProductName;
                BillObj.Price = BillDetails[i].ProductPrice;
                BillObj.Quantity = BillDetails[i].ProductQuantity;
                BillObj.Amount = BillDetails[i].Amount;

                BillList.Add(BillObj);
            }



            return View("Bill", BillList);
        }
    }
}
