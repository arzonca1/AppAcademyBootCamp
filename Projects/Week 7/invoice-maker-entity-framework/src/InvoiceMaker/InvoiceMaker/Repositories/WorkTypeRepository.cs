using InvoiceMaker.Data;
using InvoiceMaker.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Repositories
{
    public class WorkTypeRepository
    {

        private Context _context; 

        public WorkTypeRepository(Context context)
        {
            _context = context; 
        }

        public IList<WorkType> GetWorkTypes()
        {
            return _context.WorkType.ToList();
        }

        public WorkType GetWorkType(int id)
        {
            return _context.WorkType.SingleOrDefault(wt => wt.Id == id);
        }

        public void Insert(WorkType workType)
        {
            _context.WorkType.Add(workType);
            _context.SaveChanges();
        }

        public void Update(WorkType workType)
        {
            _context.WorkType.Attach(workType);
            _context.Entry(workType).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }    
    }
}