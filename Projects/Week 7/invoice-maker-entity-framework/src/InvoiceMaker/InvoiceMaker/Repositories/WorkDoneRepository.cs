using InvoiceMaker.Data;
using InvoiceMaker.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Repositories
{
    public class WorkDoneRepository
    {
        private Context _context;

        public WorkDoneRepository(Context context)
        {
            _context = context;
        }

        public List<WorkDone> GetWorkDone()
        {
            return _context.WorkDones.ToList();
        }

        public WorkDone GetWorkDone(int id)
        {
            return _context.WorkDones.SingleOrDefault(wd => wd.Id == id);
        }

        public void Insert(WorkDone workDone)
        {
            _context.WorkDones.Add(workDone);
            _context.SaveChanges();
        }

        public void Update(WorkDone workDone)
        {
            _context.WorkDones.Attach(workDone);
            _context.Entry(workDone).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}