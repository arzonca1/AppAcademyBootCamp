using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class FeeLineItem : ILineItem
    {
        public FeeLineItem(string description, decimal amount, DateTimeOffset when)
        {
            Amount = amount;
            Description = description;
            When = when;
        }

        public int Id { get; set;}
        [Required]
        public string Description { get; private set; }
        [Required]
        public decimal Amount { get; private set; }
        public DateTimeOffset When { get; private set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}