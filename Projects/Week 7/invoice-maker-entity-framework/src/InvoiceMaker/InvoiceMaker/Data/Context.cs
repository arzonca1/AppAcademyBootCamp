using InvoiceMaker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Data
{
    public class Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<WorkDone> WorkDones { get; set; }
        public DbSet<FeeLineItem> FeeLineItems { get; set;}
        public DbSet<WorkType> WorkType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Client>().HasMany(c => c.Invoices);
            //modelBuilder.Entity<Invoice>().HasMany(i => i.FeeLineItems);
            //modelBuilder.Entity<Invoice>().HasMany(i => i.WorkDoneItems);
            modelBuilder.Entity<Client>().HasMany(c => c.FeeLineItems);
            modelBuilder.Entity<Client>().HasMany(c => c.WorkDoneItems);
            
            

        }
    }
}