using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PurchaseBilling.Models;

namespace PurchaseBilling.Data
{
    public class DboContext : DbContext
    {
        public DbSet<BillingModel> Billings { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PurchaseModel> Purchases { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PAVILION;Initial Catalog=PurchaseBilling;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
