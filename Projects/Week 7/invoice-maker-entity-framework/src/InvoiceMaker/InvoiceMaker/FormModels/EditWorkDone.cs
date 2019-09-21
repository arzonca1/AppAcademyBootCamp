using InvoiceMaker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceMaker.FormModels
{
    public class EditWorkDone
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int WorkTypeId { get; set; }
        public DateTimeOffset StartedOn { get; set; }
    }

    public class EditWorkDoneView : EditWorkDone
    {
        public IList<Client> Clients { get; set; }
        public IList<WorkType> WorkTypes { get; set; }

        public SelectList ClientSelectList
        {
            get
            {
                return new SelectList(Clients, "Id", "Name");
            }
        }

        public SelectList WorkTypeSelectList
        {
            get
            {
                return new SelectList(WorkTypes, "Id", "Name");
            }
        }
    }
}