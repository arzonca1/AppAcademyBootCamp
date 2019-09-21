using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public interface ILineItem
    {
        [NotMapped]
        int Id { get; set; }
        [NotMapped]
        decimal Amount { get; }
        [NotMapped]
        string Description { get; }
        [NotMapped]
        DateTimeOffset When { get; }
    }
}