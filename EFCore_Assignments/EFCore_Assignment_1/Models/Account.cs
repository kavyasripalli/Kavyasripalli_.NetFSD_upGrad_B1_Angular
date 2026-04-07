using System;
using System.ComponentModel.DataAnnotations;

namespace EFCore_Assignment_1.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string AccountType { get; set; }

        public string Customer { get; set; }

        public decimal Balance { get; set; }

        public string Branch { get; set; }

        public DateTime CreateDate { get; set; }
    }
}