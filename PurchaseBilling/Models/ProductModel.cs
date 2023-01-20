﻿using System.ComponentModel.DataAnnotations;

namespace PurchaseBilling.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set;}
    }
}
