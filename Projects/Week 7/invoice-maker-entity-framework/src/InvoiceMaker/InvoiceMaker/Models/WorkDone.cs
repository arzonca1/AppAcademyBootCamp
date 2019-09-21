using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class WorkDone
    {
        private Client _client;
        private WorkType _workType;
        
        public WorkDone() { }

        public WorkDone(int id, Client client, WorkType workType)
        {
            Id = id;
            _client = client;
            _workType = workType;
            PopulateFields(client, workType);
            StartedOn = DateTimeOffset.Now;
        }

        public WorkDone(int id, Client client, WorkType workType, 
            DateTimeOffset startedOn)
            : this(id, client, workType)
        {
            StartedOn = startedOn;
        }

        public WorkDone(int id, Client client, WorkType workType, 
            DateTimeOffset startedOn, DateTimeOffset endedOn)
            : this(id, client, workType, startedOn)
        {
            EndedOn = endedOn;
        }

        public void PopulateFields(Client client, WorkType workType)
        {
            ClientId = client.Id;
            ClientName = client.Name;
            WorkTypeId = workType.Id;
            WorkTypeName = workType.Name;
//            InvoiceId = 0; 


        }

        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public int WorkTypeId { get; set; }
        [Required]
        public string WorkTypeName { get; set; }
        [Required]
        public DateTimeOffset StartedOn { get; set; }
        public DateTimeOffset? EndedOn { get; set; }
//        [Required]
//        public int InvoiceId { get; set; }
//        [Required]
//        public Invoice Invoice { get; set; }
        public void Finished()
        {
            if (EndedOn == null)
            {
                EndedOn = DateTimeOffset.Now;
            }
        }

        public decimal? GetTotal()
        {
            decimal? total = null;

            if (EndedOn != null)
            {
                total = _workType.Rate * (decimal)(EndedOn.Value - StartedOn).TotalHours;
            }

            return total;
        }
    }
}