using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class Invoice
    {
        public Invoice() { }
        public Invoice(string invoiceNumber)
        {
            InvoiceNumber = invoiceNumber;
            WorkDoneItems = new List<WorkDone>();
            FeeLineItems = new List<FeeLineItem>();
            Status = InvoiceStatus.Open;
        }

        public Invoice(string invoiceNumber, InvoiceStatus status)
            : this(invoiceNumber)
        {
            Status = status;
        }

        public int Id { get; set; }
        [Required]
        public string InvoiceNumber { get;  set; }
        [Required]
        public InvoiceStatus Status { get;  set; }
        public List<WorkDone> WorkDoneItems { get; set; }
        public List<FeeLineItem> FeeLineItems { get; set; }

        public void FinalizeInvoice()
        {
            if (Status == InvoiceStatus.Open)
            {
                Status = InvoiceStatus.Finalized;
            }
        }

        public void CloseInvoice()
        {
            if (Status == InvoiceStatus.Finalized)
            {
                Status = InvoiceStatus.Closed;
            }
        }

        public void AddWorkLineItem(WorkDone workDone)
        {
            WorkDoneItems.Add(workDone);
        }

        public void AddFeeLineItem(string description, decimal amount, DateTimeOffset when)
        {
            FeeLineItems.Add(new FeeLineItem(description, amount, when));
        }

        public override string ToString()
        {
            return "";
        }
    }
}