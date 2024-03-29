﻿using System.ComponentModel.DataAnnotations;

namespace PurchaseBilling.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
